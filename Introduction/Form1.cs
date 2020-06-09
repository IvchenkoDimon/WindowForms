using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Introduction
{
	public partial class Form1 : Form
	{
		Font def_font;
		public Form1()
		{
			InitializeComponent();

			start_form_parametrs();

			def_font = cb_showdate.Font;

			
		}

		private void main_timer_Tick(object sender, EventArgs e)
		{
			//this.lb_time.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
			this.lb_time.Text = DateTime.Now.ToLongTimeString();
			this.lb_date.Text = DateTime.Now.ToLongDateString(); 
			//if (cb_showdate.Checked)
			//	this.lb_date.Visible = true;
			//else
			//	this.lb_date.Visible = false;
			
		}

		private void cb_showdate_CheckedChanged(object sender, EventArgs e)
		{
			this.lb_date.Visible = this.cb_showdate.Checked;
		}
		private void cb_autostart_CheckedChanged(object sender, EventArgs e)
		{
			RegistryKey my_key;

			if (this.cb_autostart.Checked)
			{
				my_key = Registry.LocalMachine.OpenSubKey(@"SOFTWAREMicrosoftWindowsCurrentVersionRun", true);
				my_key.SetValue("Ivchenko", Application.ExecutablePath);
			}
			else
			{
				my_key = Registry.LocalMachine.OpenSubKey(@"SOFTWAREMicrosoftWindowsCurrentVersionRun", true);
				my_key.DeleteValue("Ivchenko");
			}
		}
		private void cb_showdate_MouseHover(object sender, EventArgs e)
		{
			
			this.cb_showdate.Font = new Font(def_font, FontStyle.Bold);
			this.cb_showdate.ForeColor = Color.Red;
		}

		private void cb_showdate_MouseLeave(object sender, EventArgs e)
		{
			this.cb_showdate.Font = new Font(def_font, FontStyle.Regular);
			this.cb_showdate.ForeColor = Color.Yellow;
		}
		private void start_form_parametrs()
		{
			this.StartPosition = FormStartPosition.Manual;
			this.Size = new Size(300, 150);
			this.TransparencyKey = BackColor;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);
			//Variant 2
			//Point pt = Screen.PrimaryScreen.WorkingArea.Location;
			//pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
			//this.Location = pt;
		}

		
	}
}
