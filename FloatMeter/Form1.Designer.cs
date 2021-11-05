
namespace FloatMeter
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
            this.usLabel = new System.Windows.Forms.Label();
            this.upSpeedLabel = new System.Windows.Forms.Label();
            this.downSpeedLabel = new System.Windows.Forms.Label();
            this.dsLabel = new System.Windows.Forms.Label();
            this.uploadLabel = new System.Windows.Forms.Label();
            this.udLabel = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.ddLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.positionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlPos = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPos = new System.Windows.Forms.ToolStripMenuItem();
            this.trPos = new System.Windows.Forms.ToolStripMenuItem();
            this.bootMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.netComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usLabel
            // 
            this.usLabel.AutoSize = true;
            this.usLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usLabel.ForeColor = System.Drawing.Color.White;
            this.usLabel.Location = new System.Drawing.Point(12, 7);
            this.usLabel.Name = "usLabel";
            this.usLabel.Size = new System.Drawing.Size(37, 18);
            this.usLabel.TabIndex = 0;
            this.usLabel.Text = "Up:";
            // 
            // upSpeedLabel
            // 
            this.upSpeedLabel.AutoSize = true;
            this.upSpeedLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.upSpeedLabel.Location = new System.Drawing.Point(52, 7);
            this.upSpeedLabel.Name = "upSpeedLabel";
            this.upSpeedLabel.Size = new System.Drawing.Size(118, 18);
            this.upSpeedLabel.TabIndex = 1;
            this.upSpeedLabel.Text = "0000.00 KB/s";
            // 
            // downSpeedLabel
            // 
            this.downSpeedLabel.AutoSize = true;
            this.downSpeedLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.downSpeedLabel.Location = new System.Drawing.Point(202, 7);
            this.downSpeedLabel.Name = "downSpeedLabel";
            this.downSpeedLabel.Size = new System.Drawing.Size(118, 18);
            this.downSpeedLabel.TabIndex = 3;
            this.downSpeedLabel.Text = "0000.00 KB/s";
            // 
            // dsLabel
            // 
            this.dsLabel.AutoSize = true;
            this.dsLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsLabel.ForeColor = System.Drawing.Color.White;
            this.dsLabel.Location = new System.Drawing.Point(162, 7);
            this.dsLabel.Name = "dsLabel";
            this.dsLabel.Size = new System.Drawing.Size(37, 18);
            this.dsLabel.TabIndex = 2;
            this.dsLabel.Text = "Dn:";
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLabel.ForeColor = System.Drawing.Color.White;
            this.uploadLabel.Location = new System.Drawing.Point(360, 7);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(102, 18);
            this.uploadLabel.TabIndex = 5;
            this.uploadLabel.Text = "0000.00 KB";
            // 
            // udLabel
            // 
            this.udLabel.AutoSize = true;
            this.udLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udLabel.ForeColor = System.Drawing.Color.White;
            this.udLabel.Location = new System.Drawing.Point(320, 7);
            this.udLabel.Name = "udLabel";
            this.udLabel.Size = new System.Drawing.Size(37, 18);
            this.udLabel.TabIndex = 4;
            this.udLabel.Text = "Up:";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadLabel.ForeColor = System.Drawing.Color.White;
            this.downloadLabel.Location = new System.Drawing.Point(511, 7);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(102, 18);
            this.downloadLabel.TabIndex = 7;
            this.downloadLabel.Text = "0000.00 KB";
            // 
            // ddLabel
            // 
            this.ddLabel.AutoSize = true;
            this.ddLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLabel.ForeColor = System.Drawing.Color.White;
            this.ddLabel.Location = new System.Drawing.Point(471, 7);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(37, 18);
            this.ddLabel.TabIndex = 6;
            this.ddLabel.Text = "Dn:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionMenu,
            this.shrinkMenu,
            this.bootMenu,
            this.topmostMenu,
            this.netComboBox,
            this.toolStripSeparator1,
            this.exitMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 209);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // positionMenu
            // 
            this.positionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlPos,
            this.tcPos,
            this.trPos});
            this.positionMenu.Name = "positionMenu";
            this.positionMenu.Size = new System.Drawing.Size(184, 32);
            this.positionMenu.Text = "Position";
            // 
            // tlPos
            // 
            this.tlPos.Name = "tlPos";
            this.tlPos.Size = new System.Drawing.Size(194, 34);
            this.tlPos.Text = "TopLeft";
            this.tlPos.Click += new System.EventHandler(this.tlPos_Click);
            // 
            // tcPos
            // 
            this.tcPos.Name = "tcPos";
            this.tcPos.Size = new System.Drawing.Size(194, 34);
            this.tcPos.Text = "TopCenter";
            this.tcPos.Click += new System.EventHandler(this.tcPos_Click);
            // 
            // trPos
            // 
            this.trPos.Name = "trPos";
            this.trPos.Size = new System.Drawing.Size(194, 34);
            this.trPos.Text = "TopRight";
            this.trPos.Click += new System.EventHandler(this.trPos_Click);
            // 
            // bootMenu
            // 
            this.bootMenu.CheckOnClick = true;
            this.bootMenu.Name = "bootMenu";
            this.bootMenu.Size = new System.Drawing.Size(184, 32);
            this.bootMenu.Text = "Start at boot";
            this.bootMenu.Click += new System.EventHandler(this.bootMenu_Click);
            // 
            // topmostMenu
            // 
            this.topmostMenu.CheckOnClick = true;
            this.topmostMenu.Name = "topmostMenu";
            this.topmostMenu.Size = new System.Drawing.Size(184, 32);
            this.topmostMenu.Text = "TopMost";
            this.topmostMenu.Click += new System.EventHandler(this.topmostMenu_Click);
            // 
            // netComboBox
            // 
            this.netComboBox.Name = "netComboBox";
            this.netComboBox.Size = new System.Drawing.Size(121, 33);
            this.netComboBox.SelectedIndexChanged += new System.EventHandler(this.netComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(184, 32);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // shrinkMenu
            // 
            this.shrinkMenu.CheckOnClick = true;
            this.shrinkMenu.Name = "shrinkMenu";
            this.shrinkMenu.Size = new System.Drawing.Size(184, 32);
            this.shrinkMenu.Text = "Auto-Shrink";
            this.shrinkMenu.Click += new System.EventHandler(this.shrinkMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(622, 34);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.ddLabel);
            this.Controls.Add(this.uploadLabel);
            this.Controls.Add(this.udLabel);
            this.Controls.Add(this.downSpeedLabel);
            this.Controls.Add(this.dsLabel);
            this.Controls.Add(this.upSpeedLabel);
            this.Controls.Add(this.usLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FloatMeter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usLabel;
        private System.Windows.Forms.Label upSpeedLabel;
        private System.Windows.Forms.Label downSpeedLabel;
        private System.Windows.Forms.Label dsLabel;
        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.Label udLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Label ddLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem positionMenu;
        private System.Windows.Forms.ToolStripMenuItem tlPos;
        private System.Windows.Forms.ToolStripMenuItem tcPos;
        private System.Windows.Forms.ToolStripMenuItem trPos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem topmostMenu;
        private System.Windows.Forms.ToolStripMenuItem bootMenu;
        private System.Windows.Forms.ToolStripComboBox netComboBox;
        private System.Windows.Forms.ToolStripMenuItem shrinkMenu;
    }
}

