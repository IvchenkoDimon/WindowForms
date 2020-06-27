using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime startDate = dateTimePickerStart.Value;
			DateTime endDate = dateTimePickerEnd.Value;
			//labelResult.Text = $"{ startDate.ToString()}\n{endDate.ToString()}";
			if (radioButtonYears.Checked)
			{
				//if ((endDate - startDate).Days > 365) labelResult.Text = (endDate.Year - startDate.Year).ToString() + " лет";
				//else labelResult.Text = 0 + " лет"; 
				labelResult.Text = ((endDate - startDate).TotalDays / 365).ToString();
			}
			//TimeSpan ts = endDate - startDate;
			//labelResult.Text = ts.TotalDays.ToString();
			if (radioButtonMounthes.Checked)
			{
				labelResult.Text = (Math.Floor((endDate - startDate).TotalDays / 12)).ToString() + " месяца";
			}
			if (radioButtonWeeks.Checked)
			{
				labelResult.Text = (Math.Floor((endDate - startDate).TotalDays / 7)).ToString() + " недели";
			}
			if (radioButtonDays.Checked)
			{
				labelResult.Text = (Math.Floor((endDate - startDate).TotalDays)).ToString() + " дня";
			}
			if (radioButtonHours.Checked)
			{
				labelResult.Text = (Math.Floor((endDate - startDate).TotalHours)).ToString() + " часа";
			}
			if (radioButtonMinutes.Checked)
			{
				labelResult.Text = (Math.Floor((endDate - startDate).TotalMinutes)).ToString() + " минуты";
			}
			if (radioButtonFull.Checked)
			{
				//labelResult.Text = (endDate - startDate
			}
		}
	}
}
