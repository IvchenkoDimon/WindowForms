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
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuSystemTray.SuspendLayout();
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
			this.lb_date.Location = new System.Drawing.Point(50, 46);
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
			this.cb_autostart.BackColor = System.Drawing.Color.ForestGreen;
			this.cb_autostart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_autostart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_autostart.ForeColor = System.Drawing.Color.Yellow;
			this.cb_autostart.Location = new System.Drawing.Point(156, 127);
			this.cb_autostart.Name = "cb_autostart";
			this.cb_autostart.Size = new System.Drawing.Size(115, 31);
			this.cb_autostart.TabIndex = 3;
			this.cb_autostart.Text = "autostart";
			this.cb_autostart.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cb_autostart.UseVisualStyleBackColor = true;
			this.cb_autostart.CheckedChanged += new System.EventHandler(this.cb_autostart_CheckedChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuSystemTray;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "My Clock";
			this.notifyIcon1.Visible = true;
			// 
			// contextMenuSystemTray
			// 
			this.contextMenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.contextMenuSystemTray.Name = "contextMenuSystemTray";
			this.contextMenuSystemTray.Size = new System.Drawing.Size(150, 92);
			this.contextMenuSystemTray.Text = "Text of menu";
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Checked = true;
			this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
			this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// hideToolStripMenuItem
			// 
			this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
			this.hideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hideToolStripMenuItem.Text = "Hide";
			this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.ClientSize = new System.Drawing.Size(325, 184);
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
			this.contextMenuSystemTray.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer main_timer;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.Label lb_date;
		private System.Windows.Forms.CheckBox cb_showdate;
		private System.Windows.Forms.CheckBox cb_autostart;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuSystemTray;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}

