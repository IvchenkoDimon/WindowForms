namespace Introduction
{
	partial class MyClockSettings
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
			this.cb_clockTopMost = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cb_showdate = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cb_clockTopMost
			// 
			this.cb_clockTopMost.AutoSize = true;
			this.cb_clockTopMost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_clockTopMost.Location = new System.Drawing.Point(13, 13);
			this.cb_clockTopMost.Name = "cb_clockTopMost";
			this.cb_clockTopMost.Size = new System.Drawing.Size(147, 23);
			this.cb_clockTopMost.TabIndex = 0;
			this.cb_clockTopMost.Text = "Поверх всех окон";
			this.cb_clockTopMost.UseVisualStyleBackColor = true;
			this.cb_clockTopMost.Click += new System.EventHandler(this.cb_clockTopMost_Click);
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(241, 135);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(323, 135);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cb_showdate
			// 
			this.cb_showdate.AutoSize = true;
			this.cb_showdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_showdate.Location = new System.Drawing.Point(13, 43);
			this.cb_showdate.Name = "cb_showdate";
			this.cb_showdate.Size = new System.Drawing.Size(137, 23);
			this.cb_showdate.TabIndex = 3;
			this.cb_showdate.Text = "Показывать дату";
			this.cb_showdate.UseVisualStyleBackColor = true;
			this.cb_showdate.Click += new System.EventHandler(this.cb_showdate_Click);
			// 
			// MyClockSettings
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(410, 173);
			this.Controls.Add(this.cb_showdate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cb_clockTopMost);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MyClockSettings";
			this.Text = "MyClockSettings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cb_clockTopMost;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cb_showdate;
	}
}