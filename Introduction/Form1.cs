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
		DateTime timeToShutdown;
		Font def_font;
		public ToolStripMenuItem AlwaysOnTopToolStripMenuItem
		{
			get
			{
				return alwaysOnTopToolStripMenuItem;
			}
		}
		public Label Lb_date
		{
			get
			{
				return lb_date;
			}
			set
			{
				lb_date = value;
			}
		}

		public DateTime TimeToShutdown
		{
			get=> timeToShutdown;
			set => timeToShutdown = value;
		}
		public Form1()
		{
			InitializeComponent();
			start_form_parametrs();
			def_font = cb_showdate.Font;

			timeToShutdown = DateTime.MaxValue;
			
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
			const string name = "Ivchenko Software®";
			string ExePath = Application.ExecutablePath;
			RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\"); ;

				if (cb_autostart.Checked)
					reg.SetValue(name, ExePath);
				else
					reg.DeleteValue(name);

				reg.Close();
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
			this.Size = new Size(250, 230);
			//this.TransparencyKey = BackColor;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 25);
		}
		public void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			alwaysOnTopToolStripMenuItem.Checked = this.TopMost = this.TopMost ? false : true;
		}
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void showToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void hideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyClockSettings mcs = new MyClockSettings(this);
			mcs.Show();
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void settingsToolStripMenuItem_DoubleClick(object sender, EventArgs e)
		{
			MyClockSettings msc = new MyClockSettings(this);
			msc.Show();
		}

		private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShutdownForm sf = new ShutdownForm(this);

			sf.Show();
		}
	}
}
