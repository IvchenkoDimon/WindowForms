namespace Shutdown_Timer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.comboBoxAction = new System.Windows.Forms.ComboBox();
			this.radioButtonAccurateTime = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.lb_time = new System.Windows.Forms.Label();
			this.lb_hours = new System.Windows.Forms.Label();
			this.lb_minutes = new System.Windows.Forms.Label();
			this.trackBarHours = new System.Windows.Forms.TrackBar();
			this.trackBarMinutes = new System.Windows.Forms.TrackBar();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.sysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).BeginInit();
			this.sysTrayContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxAction
			// 
			this.comboBoxAction.AccessibleName = "";
			this.comboBoxAction.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.comboBoxAction.FormattingEnabled = true;
			this.comboBoxAction.Items.AddRange(new object[] {
            "Lock Screen",
            "Log out",
            "Sleep",
            "Shutdown"});
			this.comboBoxAction.Location = new System.Drawing.Point(12, 12);
			this.comboBoxAction.Name = "comboBoxAction";
			this.comboBoxAction.Size = new System.Drawing.Size(308, 21);
			this.comboBoxAction.TabIndex = 1;
			// 
			// radioButtonAccurateTime
			// 
			this.radioButtonAccurateTime.AutoSize = true;
			this.radioButtonAccurateTime.Checked = true;
			this.radioButtonAccurateTime.Location = new System.Drawing.Point(13, 46);
			this.radioButtonAccurateTime.Name = "radioButtonAccurateTime";
			this.radioButtonAccurateTime.Size = new System.Drawing.Size(31, 17);
			this.radioButtonAccurateTime.TabIndex = 2;
			this.radioButtonAccurateTime.TabStop = true;
			this.radioButtonAccurateTime.Text = "в";
			this.radioButtonAccurateTime.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(60, 46);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(54, 17);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "через";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// lb_time
			// 
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_time.Location = new System.Drawing.Point(248, 39);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(71, 25);
			this.lb_time.TabIndex = 4;
			this.lb_time.Text = "00:00";
			this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_hours
			// 
			this.lb_hours.AutoSize = true;
			this.lb_hours.Location = new System.Drawing.Point(9, 94);
			this.lb_hours.Name = "lb_hours";
			this.lb_hours.Size = new System.Drawing.Size(35, 13);
			this.lb_hours.TabIndex = 7;
			this.lb_hours.Text = "Часы";
			// 
			// lb_minutes
			// 
			this.lb_minutes.AutoSize = true;
			this.lb_minutes.Location = new System.Drawing.Point(9, 145);
			this.lb_minutes.Name = "lb_minutes";
			this.lb_minutes.Size = new System.Drawing.Size(46, 13);
			this.lb_minutes.TabIndex = 8;
			this.lb_minutes.Text = "Минуты";
			// 
			// trackBarHours
			// 
			this.trackBarHours.LargeChange = 1;
			this.trackBarHours.Location = new System.Drawing.Point(60, 77);
			this.trackBarHours.Maximum = 23;
			this.trackBarHours.Name = "trackBarHours";
			this.trackBarHours.Size = new System.Drawing.Size(259, 45);
			this.trackBarHours.TabIndex = 9;
			this.trackBarHours.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarHours.ValueChanged += new System.EventHandler(this.trackBarHours_ValueChanged);
			// 
			// trackBarMinutes
			// 
			this.trackBarMinutes.LargeChange = 10;
			this.trackBarMinutes.Location = new System.Drawing.Point(60, 128);
			this.trackBarMinutes.Maximum = 59;
			this.trackBarMinutes.Name = "trackBarMinutes";
			this.trackBarMinutes.Size = new System.Drawing.Size(259, 45);
			this.trackBarMinutes.TabIndex = 10;
			this.trackBarMinutes.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarMinutes.ValueChanged += new System.EventHandler(this.trackBarMinutes_ValueChanged);
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(12, 179);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(142, 47);
			this.buttonApply.TabIndex = 11;
			this.buttonApply.Text = "Применить";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(178, 179);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(142, 47);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Выход";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// systemTray
			// 
			this.systemTray.ContextMenuStrip = this.sysTrayContextMenu;
			this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
			this.systemTray.Text = "IDS  Timer";
			this.systemTray.DoubleClick += new System.EventHandler(this.systemTray_DoubleClick);
			// 
			// sysTrayContextMenu
			// 
			this.sysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.sysTrayContextMenu.Name = "sysTrayContextMenu";
			this.sysTrayContextMenu.Size = new System.Drawing.Size(104, 48);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// mainTimer
			// 
			this.mainTimer.Enabled = true;
			this.mainTimer.Interval = 1000;
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 236);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.trackBarMinutes);
			this.Controls.Add(this.trackBarHours);
			this.Controls.Add(this.lb_minutes);
			this.Controls.Add(this.lb_hours);
			this.Controls.Add(this.lb_time);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButtonAccurateTime);
			this.Controls.Add(this.comboBoxAction);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "IDS Timer";
			((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
			this.sysTrayContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxAction;
		private System.Windows.Forms.RadioButton radioButtonAccurateTime;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.Label lb_hours;
		private System.Windows.Forms.Label lb_minutes;
		private System.Windows.Forms.TrackBar trackBarHours;
		private System.Windows.Forms.TrackBar trackBarMinutes;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.NotifyIcon systemTray;
		private System.Windows.Forms.ContextMenuStrip sysTrayContextMenu;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Timer mainTimer;
	}
}

