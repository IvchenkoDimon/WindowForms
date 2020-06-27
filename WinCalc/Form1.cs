using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
	public partial class mainForm : Form
	{
		double a;
		double b;
		public mainForm()
		{
			InitializeComponent();
		}

		private void buttonplus_Click(object sender, EventArgs e)
		{
			if(a == 0)
			{
				a = Convert.ToDouble(textBox1.Text);
			}
			else
			{
				b = Convert.ToDouble(textBox1.Text);
				a += b;
				b = 0;
				textBox1.Text = a.ToString();
			}
		}
	}
}
