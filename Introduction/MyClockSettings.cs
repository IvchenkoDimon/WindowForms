using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
	public partial class MyClockSettings : Form
	{
		Form1 parent;
		public MyClockSettings(Form1 parent)
		{
			InitializeComponent();
			this.parent = parent;
			this.cb_clockTopMost.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
			this.cb_showdate.Checked = parent.Lb_date.Visible;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cb_clockTopMost_Click(object sender, EventArgs e)
		{
			//cb_clockTopMost.Checked  = 
			//	Application.OpenForms[0].TopMost = 
			//	Application.OpenForms[0].TopMost ? false : true;
			parent.alwaysOnTopToolStripMenuItem_Click(sender, e);
			cb_clockTopMost.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
		}

		private void cb_showdate_Click(object sender, EventArgs e)
		{
			parent.Lb_date.Visible = this.cb_showdate.Checked = parent.Lb_date.Visible ? false : true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			
		}
	}
}
