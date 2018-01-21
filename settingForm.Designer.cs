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
            this.label1.Location = new System.Drawing.Point(59, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "正円";
            // 
            // tyouhoukei
            // 
            this.tyouhoukei.Location = new System.Drawing.Point(94, 11);
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
            this.tyouhoukei.Size = new System.Drawing.Size(64, 19);
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
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "縦";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(94, 82);
            this.HeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(64, 19);
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
            this.label3.Location = new System.Drawing.Point(71, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "横";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(94, 153);
            this.WidthBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(64, 19);
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
            this.tyouhoukriBar.Location = new System.Drawing.Point(12, 36);
            this.tyouhoukriBar.Maximum = 1000;
            this.tyouhoukriBar.Minimum = 50;
            this.tyouhoukriBar.Name = "tyouhoukriBar";
            this.tyouhoukriBar.Size = new System.Drawing.Size(146, 45);
            this.tyouhoukriBar.SmallChange = 10;
            this.tyouhoukriBar.TabIndex = 6;
            this.tyouhoukriBar.TickFrequency = 50;
            this.tyouhoukriBar.Value = 300;
            this.tyouhoukriBar.ValueChanged += new System.EventHandler(this.tyouhoukriBar_ValueChanged);
            // 
            // HeightBar
            // 
            this.HeightBar.LargeChange = 50;
            this.HeightBar.Location = new System.Drawing.Point(12, 107);
            this.HeightBar.Maximum = 1000;
            this.HeightBar.Minimum = 50;
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Size = new System.Drawing.Size(146, 45);
            this.HeightBar.SmallChange = 10;
            this.HeightBar.TabIndex = 7;
            this.HeightBar.TickFrequency = 50;
            this.HeightBar.Value = 300;
            this.HeightBar.ValueChanged += new System.EventHandler(this.HeightBar_ValueChanged);
            // 
            // WidthBar
            // 
            this.WidthBar.LargeChange = 50;
            this.WidthBar.Location = new System.Drawing.Point(12, 178);
            this.WidthBar.Maximum = 1000;
            this.WidthBar.Minimum = 50;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(146, 45);
            this.WidthBar.SmallChange = 10;
            this.WidthBar.TabIndex = 8;
            this.WidthBar.TickFrequency = 50;
            this.WidthBar.Value = 300;
            this.WidthBar.ValueChanged += new System.EventHandler(this.WidthBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "不透明度";
            // 
            // toumeiBox
            // 
            this.toumeiBox.Location = new System.Drawing.Point(94, 229);
            this.toumeiBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.toumeiBox.Name = "toumeiBox";
            this.toumeiBox.Size = new System.Drawing.Size(64, 19);
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
            this.toumeiBar.Location = new System.Drawing.Point(12, 254);
            this.toumeiBar.Maximum = 100;
            this.toumeiBar.Minimum = 10;
            this.toumeiBar.Name = "toumeiBar";
            this.toumeiBar.Size = new System.Drawing.Size(146, 45);
            this.toumeiBar.TabIndex = 11;
            this.toumeiBar.TickFrequency = 10;
            this.toumeiBar.Value = 100;
            this.toumeiBar.ValueChanged += new System.EventHandler(this.toumeiBar_ValueChanged);
            // 
            // toukaCheckBox
            // 
            this.toukaCheckBox.AutoSize = true;
            this.toukaCheckBox.Location = new System.Drawing.Point(72, 305);
            this.toukaCheckBox.Name = "toukaCheckBox";
            this.toukaCheckBox.Size = new System.Drawing.Size(72, 16);
            this.toukaCheckBox.TabIndex = 12;
            this.toukaCheckBox.Text = "背景透過";
            this.toukaCheckBox.UseVisualStyleBackColor = true;
            this.toukaCheckBox.CheckedChanged += new System.EventHandler(this.toukaCheckBox_CheckedChanged);
            // 
            // secHndCheckBox
            // 
            this.secHndCheckBox.AutoSize = true;
            this.secHndCheckBox.Location = new System.Drawing.Point(72, 327);
            this.secHndCheckBox.Name = "secHndCheckBox";
            this.secHndCheckBox.Size = new System.Drawing.Size(86, 16);
            this.secHndCheckBox.TabIndex = 13;
            this.secHndCheckBox.Text = "秒針ぬるぬる";
            this.secHndCheckBox.UseVisualStyleBackColor = true;
            this.secHndCheckBox.CheckedChanged += new System.EventHandler(this.secHndCheckBox_CheckedChanged);
            // 
            // minHandCheckBox
            // 
            this.minHandCheckBox.AutoSize = true;
            this.minHandCheckBox.Location = new System.Drawing.Point(72, 350);
            this.minHandCheckBox.Name = "minHandCheckBox";
            this.minHandCheckBox.Size = new System.Drawing.Size(86, 16);
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
            this.dateCheckBox.Location = new System.Drawing.Point(72, 372);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(72, 16);
            this.dateCheckBox.TabIndex = 15;
            this.dateCheckBox.Text = "日付表示";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 403);
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
    }
}