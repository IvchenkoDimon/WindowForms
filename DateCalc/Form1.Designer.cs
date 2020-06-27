namespace DateCalc
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.radioButtonYears = new System.Windows.Forms.RadioButton();
			this.radioButtonMounthes = new System.Windows.Forms.RadioButton();
			this.radioButtonWeeks = new System.Windows.Forms.RadioButton();
			this.radioButtonDays = new System.Windows.Forms.RadioButton();
			this.radioButtonHours = new System.Windows.Forms.RadioButton();
			this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.radioButtonFull = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Location = new System.Drawing.Point(29, 13);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerStart.TabIndex = 0;
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Location = new System.Drawing.Point(251, 13);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerEnd.TabIndex = 1;
			// 
			// radioButtonYears
			// 
			this.radioButtonYears.AutoSize = true;
			this.radioButtonYears.Checked = true;
			this.radioButtonYears.Location = new System.Drawing.Point(26, 39);
			this.radioButtonYears.Name = "radioButtonYears";
			this.radioButtonYears.Size = new System.Drawing.Size(52, 17);
			this.radioButtonYears.TabIndex = 2;
			this.radioButtonYears.TabStop = true;
			this.radioButtonYears.Text = "Years";
			this.radioButtonYears.UseVisualStyleBackColor = true;
			// 
			// radioButtonMounthes
			// 
			this.radioButtonMounthes.AutoSize = true;
			this.radioButtonMounthes.Location = new System.Drawing.Point(26, 62);
			this.radioButtonMounthes.Name = "radioButtonMounthes";
			this.radioButtonMounthes.Size = new System.Drawing.Size(72, 17);
			this.radioButtonMounthes.TabIndex = 3;
			this.radioButtonMounthes.TabStop = true;
			this.radioButtonMounthes.Text = "Mounthes";
			this.radioButtonMounthes.UseVisualStyleBackColor = true;
			// 
			// radioButtonWeeks
			// 
			this.radioButtonWeeks.AutoSize = true;
			this.radioButtonWeeks.Location = new System.Drawing.Point(26, 85);
			this.radioButtonWeeks.Name = "radioButtonWeeks";
			this.radioButtonWeeks.Size = new System.Drawing.Size(59, 17);
			this.radioButtonWeeks.TabIndex = 4;
			this.radioButtonWeeks.TabStop = true;
			this.radioButtonWeeks.Text = "Weeks";
			this.radioButtonWeeks.UseVisualStyleBackColor = true;
			// 
			// radioButtonDays
			// 
			this.radioButtonDays.AutoSize = true;
			this.radioButtonDays.Location = new System.Drawing.Point(29, 111);
			this.radioButtonDays.Name = "radioButtonDays";
			this.radioButtonDays.Size = new System.Drawing.Size(49, 17);
			this.radioButtonDays.TabIndex = 5;
			this.radioButtonDays.TabStop = true;
			this.radioButtonDays.Text = "Days";
			this.radioButtonDays.UseVisualStyleBackColor = true;
			// 
			// radioButtonHours
			// 
			this.radioButtonHours.AutoSize = true;
			this.radioButtonHours.Location = new System.Drawing.Point(29, 134);
			this.radioButtonHours.Name = "radioButtonHours";
			this.radioButtonHours.Size = new System.Drawing.Size(53, 17);
			this.radioButtonHours.TabIndex = 6;
			this.radioButtonHours.TabStop = true;
			this.radioButtonHours.Text = "Hours";
			this.radioButtonHours.UseVisualStyleBackColor = true;
			// 
			// radioButtonMinutes
			// 
			this.radioButtonMinutes.AutoSize = true;
			this.radioButtonMinutes.Location = new System.Drawing.Point(29, 157);
			this.radioButtonMinutes.Name = "radioButtonMinutes";
			this.radioButtonMinutes.Size = new System.Drawing.Size(62, 17);
			this.radioButtonMinutes.TabIndex = 7;
			this.radioButtonMinutes.TabStop = true;
			this.radioButtonMinutes.Text = "Minutes";
			this.radioButtonMinutes.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(284, 126);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 71);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelResult.Location = new System.Drawing.Point(187, 62);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(76, 25);
			this.labelResult.TabIndex = 9;
			this.labelResult.Text = "label1";
			// 
			// radioButtonFull
			// 
			this.radioButtonFull.AutoSize = true;
			this.radioButtonFull.Location = new System.Drawing.Point(29, 180);
			this.radioButtonFull.Name = "radioButtonFull";
			this.radioButtonFull.Size = new System.Drawing.Size(41, 17);
			this.radioButtonFull.TabIndex = 10;
			this.radioButtonFull.TabStop = true;
			this.radioButtonFull.Text = "Full";
			this.radioButtonFull.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 201);
			this.Controls.Add(this.radioButtonFull);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButtonMinutes);
			this.Controls.Add(this.radioButtonHours);
			this.Controls.Add(this.radioButtonDays);
			this.Controls.Add(this.radioButtonWeeks);
			this.Controls.Add(this.radioButtonMounthes);
			this.Controls.Add(this.radioButtonYears);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.dateTimePickerStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerStart;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.RadioButton radioButtonYears;
		private System.Windows.Forms.RadioButton radioButtonMounthes;
		private System.Windows.Forms.RadioButton radioButtonWeeks;
		private System.Windows.Forms.RadioButton radioButtonDays;
		private System.Windows.Forms.RadioButton radioButtonHours;
		private System.Windows.Forms.RadioButton radioButtonMinutes;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.RadioButton radioButtonFull;
	}
}

