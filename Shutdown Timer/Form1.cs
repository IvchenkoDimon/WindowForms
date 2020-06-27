using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Shutdown_Timer
{
	
	public partial class MainForm : Form
	{
		DateTime time;
		[DllImport("user32.dll")]
		public static extern void LockWorkStation();
		[DllImport("user32.dll")]
		public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

		public MainForm()
		{
			InitializeComponent();
			comboBoxAction.SelectedIndex = 0;
		}

		private void systemTray_DoubleClick(object sender, EventArgs e)
		{
			this.Show();
			systemTray.Visible = false;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			time = DateTime.Parse(lb_time.Text);
			if(time<DateTime.Now)
			{
				MessageBox.Show("Выберете другое время", "IDS Timer");
				return;
			}
			//MessageBox.Show(comboBoxAction.SelectedItem.ToString(), "IDS Timer");
			this.Hide();
			systemTray.Text = comboBoxAction.SelectedItem.ToString()+ " в " + lb_time.Text;
			systemTray.Visible = true;


			MessageBox.Show(time.ToString(), comboBoxAction.SelectedItem.ToString() + " - IDS Timer ");
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			systemTray_DoubleClick(sender, e);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void trackBarHours_ValueChanged(object sender, EventArgs e)
		{
			string hours = lb_time.Text.Split(':').First();
			string minutes = lb_time.Text.Split(':').Last();
			if(trackBarHours.Value<10) hours = "0" + trackBarHours.Value.ToString();
			else hours = trackBarHours.Value.ToString();
			lb_time.Text = $"{ hours}:{ minutes}";

		}

		private void trackBarMinutes_ValueChanged(object sender, EventArgs e)
		{
			string hours = lb_time.Text.Split(':').First();
			string minutes = lb_time.Text.Split(':').Last();
			if(trackBarMinutes.Value<10) minutes = "0"+ trackBarMinutes.Value.ToString();
			else minutes = trackBarMinutes.Value.ToString();
			lb_time.Text = $"{ hours}:{ minutes}";
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			//this.Text = DateTime.Now.ToString();
			//systemTray.Text = DateTime.Now.ToString();
			if(time.Hour == DateTime.Now.Hour && time.Minute == DateTime.Now.Minute && DateTime.Now.Second == 0)
			{
				//MessageBox.Show("Выключение...");
				//LockWorkStation();
				switch(comboBoxAction.SelectedIndex)
				{
					case 0: LockWorkStation();break;
					case 1: ExitWindowsEx(0,0);break;
				}
			}
		}
	}
}
