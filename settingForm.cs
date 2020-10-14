using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace アナログ時計だほっとけい
{
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            //フォームの位置指定
            this.Top = ((Form1)this.Owner).Top;
            this.Left = ((Form1)this.Owner).Left + ((Form1)this.Owner).Width / 2;

            //フォームの大きさ取得
            HeightBox.Value = ((Form1)this.Owner).Height;
            WidthBox.Value = ((Form1)this.Owner).Width;
            //長方形ボックスには、縦・横の数値が同じときに値を入れる
            if(HeightBox.Value == WidthBox.Value)
            {
                tyouhoukei.Value = HeightBox.Value;
            }

            //フォームの不透明度の取得
            toumeiBox.Value = (decimal)((Form1)this.Owner).Opacity * 100;

            //背景透過の可否の取得
            toukaCheckBox.Checked = ((Form1)this.Owner).touka;

            //ぬるぬる
            secHndCheckBox.Checked = ((Form1)this.Owner).secHandCheck;
            minHandCheckBox.Checked = ((Form1)this.Owner).minHandCheck;
            dateCheckBox.Checked = ((Form1)this.Owner).dateCheck;

            //クロマキー
            if (((Form1)this.Owner).TransparencyKey == Color.Empty)
            {
                ChromakeyCheckBox.Checked = true;
            }
            else
            {
                ChromakeyCheckBox.Checked = false;
            }

        }

        private void tyouhoukei_ValueChanged(object sender, EventArgs e)
        {
            HeightBox.Value = tyouhoukei.Value;
            WidthBox.Value = tyouhoukei.Value;
            tyouhoukriBar.Value = (int)tyouhoukei.Value;
        }

        private void HeightBox_ValueChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Height = (int)HeightBox.Value;
            HeightBar.Value = (int)HeightBox.Value;
        }

        private void WidthBox_ValueChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Width = (int)WidthBox.Value;
            WidthBar.Value = (int)WidthBox.Value;
        }

        private void settingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form1)this.Owner).設定ToolStripMenuItem.Checked = false;
        }

        private void tyouhoukriBar_ValueChanged(object sender, EventArgs e)
        {
            tyouhoukei.Value = tyouhoukriBar.Value;
        }

        private void HeightBar_ValueChanged(object sender, EventArgs e)
        {
            HeightBox.Value = HeightBar.Value;
        }

        private void WidthBar_ValueChanged(object sender, EventArgs e)
        {
            WidthBox.Value = WidthBar.Value;
        }

        private void toumeiBox_ValueChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Opacity = (double)toumeiBox.Value / 100;
            toumeiBar.Value = (int)toumeiBox.Value;
        }

        private void toumeiBar_ValueChanged(object sender, EventArgs e)
        {
            toumeiBox.Value = toumeiBar.Value;
        }

        private void toukaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).touka = toukaCheckBox.Checked;
        }

        private void secHndCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).secHandCheck = secHndCheckBox.Checked;
        }

        private void minHandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).minHandCheck = minHandCheckBox.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //メインフォームの情報取得
            toukaCheckBox.Checked = ((Form1)this.Owner).touka;
            secHndCheckBox.Checked = ((Form1)this.Owner).secHandCheck;
            minHandCheckBox.Checked = ((Form1)this.Owner).minHandCheck;
            dateCheckBox.Checked = ((Form1)this.Owner).dateCheck;
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((Form1)this.Owner).dateCheck = dateCheckBox.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ((Form1)this.Owner).TransparencyKey = Color.Empty;
            }
            else
            {
                ((Form1)this.Owner).TransparencyKey = ((Form1)this.Owner).BackColor;
            }
        }
    }
}
