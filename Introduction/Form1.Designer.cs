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
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.cb_clockMode = new System.Windows.Forms.ComboBox();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
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
			this.lb_time.Location = new System.Drawing.Point(52, 40);
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
			this.lb_date.Location = new System.Drawing.Point(4, 77);
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
			this.cb_showdate.Location = new System.Drawing.Point(2, 115);
			this.cb_showdate.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.cb_showdate.Name = "cb_showdate";
			this.cb_showdate.Size = new System.Drawing.Size(125, 31);
			this.cb_showdate.TabIndex = 2;
			this.cb_showdate.Text = "Show date";
			this.cb_showdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cb_showdate.UseVisualStyleBackColor = true;
			this.cb_showdate.Visible = false;
			this.cb_showdate.CheckedChanged += new System.EventHandler(this.cb_showdate_CheckedChanged);
			this.cb_showdate.MouseLeave += new System.EventHandler(this.cb_showdate_MouseLeave);
			this.cb_showdate.MouseHover += new System.EventHandler(this.cb_showdate_MouseHover);
			// 
			// cb_autostart
			// 
			this.cb_autostart.AutoSize = true;
			this.cb_autostart.BackColor = System.Drawing.Color.CornflowerBlue;
			this.cb_autostart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_autostart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_autostart.ForeColor = System.Drawing.Color.Yellow;
			this.cb_autostart.Location = new System.Drawing.Point(2, 159);
			this.cb_autostart.Name = "cb_autostart";
			this.cb_autostart.Size = new System.Drawing.Size(115, 31);
			this.cb_autostart.TabIndex = 3;
			this.cb_autostart.Text = "autostart";
			this.cb_autostart.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cb_autostart.UseVisualStyleBackColor = false;
			this.cb_autostart.CheckedChanged += new System.EventHandler(this.cb_autostart_CheckedChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuSystemTray;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "My Clock";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.settingsToolStripMenuItem_DoubleClick);
			// 
			// contextMenuSystemTray
			// 
			this.contextMenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.shutdownToolStripMenuItem,
            this.toolStripMenuItem2,
            this.alwaysOnTopToolStripMenuItem,
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
			this.contextMenuSystemTray.Name = "contextMenuSystemTray";
			this.contextMenuSystemTray.Size = new System.Drawing.Size(181, 176);
			this.contextMenuSystemTray.Text = "Text of menu";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.ForeColor = System.Drawing.Color.Yellow;
			this.checkBox1.Location = new System.Drawing.Point(2, 138);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(179, 31);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Show Stopwatch";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_close.FlatAppearance.BorderSize = 0;
			this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_close.ForeColor = System.Drawing.Color.Yellow;
			this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_close.Location = new System.Drawing.Point(2, 6);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(30, 31);
			this.btn_close.TabIndex = 5;
			this.btn_close.Text = "X";
			this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// cb_clockMode
			// 
			this.cb_clockMode.BackColor = System.Drawing.Color.CornflowerBlue;
			this.cb_clockMode.DropDownWidth = 130;
			this.cb_clockMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_clockMode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_clockMode.ForeColor = System.Drawing.Color.Yellow;
			this.cb_clockMode.FormattingEnabled = true;
			this.cb_clockMode.Items.AddRange(new object[] {
            "Show date",
            "Show Stopwatch",
            "Show Timer"});
			this.cb_clockMode.Location = new System.Drawing.Point(38, 6);
			this.cb_clockMode.Name = "cb_clockMode";
			this.cb_clockMode.Size = new System.Drawing.Size(179, 31);
			this.cb_clockMode.TabIndex = 6;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
			// 
			// shutdownToolStripMenuItem
			// 
			this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
			this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.shutdownToolStripMenuItem.Text = "Shutdown";
			this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(267, 246);
			this.Controls.Add(this.cb_clockMode);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.checkBox1);
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
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.ComboBox cb_clockMode;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		public System.Windows.Forms.ToolStripMenuItem AlwaysOnTop
		{
			get
			{
				return alwaysOnTopToolStripMenuItem;
			}
		}
	}
}

