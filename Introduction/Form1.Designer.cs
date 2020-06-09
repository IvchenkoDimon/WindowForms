namespace Introduction
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.main_timer = new System.Windows.Forms.Timer(this.components);
			this.lb_time = new System.Windows.Forms.Label();
			this.lb_date = new System.Windows.Forms.Label();
			this.cb_showdate = new System.Windows.Forms.CheckBox();
			this.cb_autostart = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// main_timer
			// 
			this.main_timer.Enabled = true;
			this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
			// 
			// lb_time
			// 
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_time.ForeColor = System.Drawing.Color.Yellow;
			this.lb_time.Location = new System.Drawing.Point(149, 0);
			this.lb_time.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(84, 40);
			this.lb_time.TabIndex = 0;
			this.lb_time.Text = "Time";
			// 
			// lb_date
			// 
			this.lb_date.AutoSize = true;
			this.lb_date.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_date.ForeColor = System.Drawing.Color.Yellow;
			this.lb_date.Location = new System.Drawing.Point(63, 52);
			this.lb_date.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.lb_date.Name = "lb_date";
			this.lb_date.Size = new System.Drawing.Size(84, 40);
			this.lb_date.TabIndex = 1;
			this.lb_date.Text = "Date";
			this.lb_date.Visible = false;
			// 
			// cb_showdate
			// 
			this.cb_showdate.AutoSize = true;
			this.cb_showdate.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.cb_showdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_showdate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_showdate.ForeColor = System.Drawing.Color.Yellow;
			this.cb_showdate.Location = new System.Drawing.Point(156, 98);
			this.cb_showdate.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.cb_showdate.Name = "cb_showdate";
			this.cb_showdate.Size = new System.Drawing.Size(125, 31);
			this.cb_showdate.TabIndex = 2;
			this.cb_showdate.Text = "Show date";
			this.cb_showdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cb_showdate.UseVisualStyleBackColor = true;
			this.cb_showdate.CheckedChanged += new System.EventHandler(this.cb_showdate_CheckedChanged);
			this.cb_showdate.MouseLeave += new System.EventHandler(this.cb_showdate_MouseLeave);
			this.cb_showdate.MouseHover += new System.EventHandler(this.cb_showdate_MouseHover);
			// 
			// cb_autostart
			// 
			this.cb_autostart.AutoSize = true;
			this.cb_autostart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_autostart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_autostart.ForeColor = System.Drawing.Color.Yellow;
			this.cb_autostart.Location = new System.Drawing.Point(156, 142);
			this.cb_autostart.Name = "cb_autostart";
			this.cb_autostart.Size = new System.Drawing.Size(115, 31);
			this.cb_autostart.TabIndex = 3;
			this.cb_autostart.Text = "autostart";
			this.cb_autostart.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cb_autostart.UseVisualStyleBackColor = true;
			this.cb_autostart.CheckedChanged += new System.EventHandler(this.cb_autostart_CheckedChanged);
			this.cb_autostart.MouseLeave += new System.EventHandler(this.cb_showdate_MouseLeave);
			this.cb_autostart.MouseHover += new System.EventHandler(this.cb_showdate_MouseHover);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.ClientSize = new System.Drawing.Size(300, 196);
			this.Controls.Add(this.cb_autostart);
			this.Controls.Add(this.cb_showdate);
			this.Controls.Add(this.lb_date);
			this.Controls.Add(this.lb_time);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.Name = "Form1";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MyClock";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Black;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer main_timer;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.Label lb_date;
		private System.Windows.Forms.CheckBox cb_showdate;
		private System.Windows.Forms.CheckBox cb_autostart;
	}
}

