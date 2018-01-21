namespace アナログ時計だほっとけい
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.背景透過ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.秒針ぬるぬるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分針ぬるぬるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.日付表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景透過ToolStripMenuItem,
            this.秒針ぬるぬるToolStripMenuItem,
            this.分針ぬるぬるToolStripMenuItem,
            this.日付表示ToolStripMenuItem,
            this.toolStripSeparator1,
            this.設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 170);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // 背景透過ToolStripMenuItem
            // 
            this.背景透過ToolStripMenuItem.Name = "背景透過ToolStripMenuItem";
            this.背景透過ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.背景透過ToolStripMenuItem.Text = "背景透過";
            this.背景透過ToolStripMenuItem.Click += new System.EventHandler(this.背景透過ToolStripMenuItem_Click);
            // 
            // 秒針ぬるぬるToolStripMenuItem
            // 
            this.秒針ぬるぬるToolStripMenuItem.Name = "秒針ぬるぬるToolStripMenuItem";
            this.秒針ぬるぬるToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.秒針ぬるぬるToolStripMenuItem.Text = "秒針ぬるぬる";
            this.秒針ぬるぬるToolStripMenuItem.Click += new System.EventHandler(this.秒針ぬるぬるToolStripMenuItem_Click);
            // 
            // 分針ぬるぬるToolStripMenuItem
            // 
            this.分針ぬるぬるToolStripMenuItem.Name = "分針ぬるぬるToolStripMenuItem";
            this.分針ぬるぬるToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.分針ぬるぬるToolStripMenuItem.Text = "分針ぬるぬる";
            this.分針ぬるぬるToolStripMenuItem.Click += new System.EventHandler(this.分針ぬるぬるToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.CheckOnClick = true;
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("終了ToolStripMenuItem.Image")));
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "アナログ時計だほっとけい";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // 日付表示ToolStripMenuItem
            // 
            this.日付表示ToolStripMenuItem.Name = "日付表示ToolStripMenuItem";
            this.日付表示ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.日付表示ToolStripMenuItem.Text = "日付表示";
            this.日付表示ToolStripMenuItem.Click += new System.EventHandler(this.日付表示ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "アナログ時計";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 背景透過ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 秒針ぬるぬるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分針ぬるぬるToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 日付表示ToolStripMenuItem;
    }
}

