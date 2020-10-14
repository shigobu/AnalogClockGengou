namespace アナログ時計だほっとけい
{
    partial class settingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tyouhoukei = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.NumericUpDown();
            this.tyouhoukriBar = new System.Windows.Forms.TrackBar();
            this.HeightBar = new System.Windows.Forms.TrackBar();
            this.WidthBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.toumeiBox = new System.Windows.Forms.NumericUpDown();
            this.toumeiBar = new System.Windows.Forms.TrackBar();
            this.toukaCheckBox = new System.Windows.Forms.CheckBox();
            this.secHndCheckBox = new System.Windows.Forms.CheckBox();
            this.minHandCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.ChromakeyCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tyouhoukei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyouhoukriBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toumeiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toumeiBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "正円";
            // 
            // tyouhoukei
            // 
            this.tyouhoukei.Location = new System.Drawing.Point(125, 14);
            this.tyouhoukei.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tyouhoukei.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tyouhoukei.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tyouhoukei.Name = "tyouhoukei";
            this.tyouhoukei.Size = new System.Drawing.Size(85, 22);
            this.tyouhoukei.TabIndex = 1;
            this.tyouhoukei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tyouhoukei.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tyouhoukei.ValueChanged += new System.EventHandler(this.tyouhoukei_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "縦";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(125, 102);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(85, 22);
            this.HeightBox.TabIndex = 3;
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.HeightBox.ValueChanged += new System.EventHandler(this.HeightBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "横";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(125, 191);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(85, 22);
            this.WidthBox.TabIndex = 5;
            this.WidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.WidthBox.ValueChanged += new System.EventHandler(this.WidthBox_ValueChanged);
            // 
            // tyouhoukriBar
            // 
            this.tyouhoukriBar.LargeChange = 50;
            this.tyouhoukriBar.Location = new System.Drawing.Point(16, 45);
            this.tyouhoukriBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tyouhoukriBar.Maximum = 1000;
            this.tyouhoukriBar.Minimum = 50;
            this.tyouhoukriBar.Name = "tyouhoukriBar";
            this.tyouhoukriBar.Size = new System.Drawing.Size(195, 56);
            this.tyouhoukriBar.SmallChange = 10;
            this.tyouhoukriBar.TabIndex = 6;
            this.tyouhoukriBar.TickFrequency = 50;
            this.tyouhoukriBar.Value = 300;
            this.tyouhoukriBar.ValueChanged += new System.EventHandler(this.tyouhoukriBar_ValueChanged);
            // 
            // HeightBar
            // 
            this.HeightBar.LargeChange = 50;
            this.HeightBar.Location = new System.Drawing.Point(16, 134);
            this.HeightBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightBar.Maximum = 1000;
            this.HeightBar.Minimum = 50;
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Size = new System.Drawing.Size(195, 56);
            this.HeightBar.SmallChange = 10;
            this.HeightBar.TabIndex = 7;
            this.HeightBar.TickFrequency = 50;
            this.HeightBar.Value = 300;
            this.HeightBar.ValueChanged += new System.EventHandler(this.HeightBar_ValueChanged);
            // 
            // WidthBar
            // 
            this.WidthBar.LargeChange = 50;
            this.WidthBar.Location = new System.Drawing.Point(16, 222);
            this.WidthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthBar.Maximum = 1000;
            this.WidthBar.Minimum = 50;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(195, 56);
            this.WidthBar.SmallChange = 10;
            this.WidthBar.TabIndex = 8;
            this.WidthBar.TickFrequency = 50;
            this.WidthBar.Value = 300;
            this.WidthBar.ValueChanged += new System.EventHandler(this.WidthBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "不透明度";
            // 
            // toumeiBox
            // 
            this.toumeiBox.Location = new System.Drawing.Point(125, 286);
            this.toumeiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toumeiBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.toumeiBox.Name = "toumeiBox";
            this.toumeiBox.Size = new System.Drawing.Size(85, 22);
            this.toumeiBox.TabIndex = 10;
            this.toumeiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toumeiBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.toumeiBox.ValueChanged += new System.EventHandler(this.toumeiBox_ValueChanged);
            // 
            // toumeiBar
            // 
            this.toumeiBar.Location = new System.Drawing.Point(16, 318);
            this.toumeiBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toumeiBar.Maximum = 100;
            this.toumeiBar.Minimum = 10;
            this.toumeiBar.Name = "toumeiBar";
            this.toumeiBar.Size = new System.Drawing.Size(195, 56);
            this.toumeiBar.TabIndex = 11;
            this.toumeiBar.TickFrequency = 10;
            this.toumeiBar.Value = 100;
            this.toumeiBar.ValueChanged += new System.EventHandler(this.toumeiBar_ValueChanged);
            // 
            // toukaCheckBox
            // 
            this.toukaCheckBox.AutoSize = true;
            this.toukaCheckBox.Location = new System.Drawing.Point(96, 381);
            this.toukaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toukaCheckBox.Name = "toukaCheckBox";
            this.toukaCheckBox.Size = new System.Drawing.Size(89, 19);
            this.toukaCheckBox.TabIndex = 12;
            this.toukaCheckBox.Text = "背景透過";
            this.toukaCheckBox.UseVisualStyleBackColor = true;
            this.toukaCheckBox.CheckedChanged += new System.EventHandler(this.toukaCheckBox_CheckedChanged);
            // 
            // secHndCheckBox
            // 
            this.secHndCheckBox.AutoSize = true;
            this.secHndCheckBox.Location = new System.Drawing.Point(96, 409);
            this.secHndCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secHndCheckBox.Name = "secHndCheckBox";
            this.secHndCheckBox.Size = new System.Drawing.Size(107, 19);
            this.secHndCheckBox.TabIndex = 13;
            this.secHndCheckBox.Text = "秒針ぬるぬる";
            this.secHndCheckBox.UseVisualStyleBackColor = true;
            this.secHndCheckBox.CheckedChanged += new System.EventHandler(this.secHndCheckBox_CheckedChanged);
            // 
            // minHandCheckBox
            // 
            this.minHandCheckBox.AutoSize = true;
            this.minHandCheckBox.Location = new System.Drawing.Point(96, 438);
            this.minHandCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minHandCheckBox.Name = "minHandCheckBox";
            this.minHandCheckBox.Size = new System.Drawing.Size(107, 19);
            this.minHandCheckBox.TabIndex = 14;
            this.minHandCheckBox.Text = "分針ぬるぬる";
            this.minHandCheckBox.UseVisualStyleBackColor = true;
            this.minHandCheckBox.CheckedChanged += new System.EventHandler(this.minHandCheckBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(96, 465);
            this.dateCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(89, 19);
            this.dateCheckBox.TabIndex = 15;
            this.dateCheckBox.Text = "日付表示";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // ChromakeyCheckBox
            // 
            this.ChromakeyCheckBox.AutoSize = true;
            this.ChromakeyCheckBox.Location = new System.Drawing.Point(96, 491);
            this.ChromakeyCheckBox.Name = "ChromakeyCheckBox";
            this.ChromakeyCheckBox.Size = new System.Drawing.Size(85, 19);
            this.ChromakeyCheckBox.TabIndex = 16;
            this.ChromakeyCheckBox.Text = "クロマキー";
            this.ChromakeyCheckBox.UseVisualStyleBackColor = true;
            this.ChromakeyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 521);
            this.Controls.Add(this.ChromakeyCheckBox);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.minHandCheckBox);
            this.Controls.Add(this.secHndCheckBox);
            this.Controls.Add(this.toukaCheckBox);
            this.Controls.Add(this.toumeiBar);
            this.Controls.Add(this.toumeiBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WidthBar);
            this.Controls.Add(this.HeightBar);
            this.Controls.Add(this.tyouhoukriBar);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tyouhoukei);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "settingForm";
            this.ShowInTaskbar = false;
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingForm_FormClosing);
            this.Load += new System.EventHandler(this.settingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tyouhoukei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyouhoukriBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toumeiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toumeiBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tyouhoukei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HeightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WidthBox;
        private System.Windows.Forms.TrackBar tyouhoukriBar;
        private System.Windows.Forms.TrackBar HeightBar;
        private System.Windows.Forms.TrackBar WidthBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown toumeiBox;
        private System.Windows.Forms.TrackBar toumeiBar;
        private System.Windows.Forms.CheckBox toukaCheckBox;
        public System.Windows.Forms.CheckBox secHndCheckBox;
        private System.Windows.Forms.CheckBox minHandCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox ChromakeyCheckBox;
    }
}