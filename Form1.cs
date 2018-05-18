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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap clock;
        private void Form1_Load(object sender, EventArgs e)
        {
            //背景色を指定する
            this.BackColor = Color.Green;
            //透明を指定する
            this.TransparencyKey = Color.Green;
            clock = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            clock.MakeTransparent(TransparencyKey);

            //現在時刻の取得
            nowTime = DateTime.Now;

            //コマンドライン引数を取得
            string[] cmds = Environment.GetCommandLineArgs();
            //透過
            if(Array.IndexOf(cmds, "/touka") > 0)
            {
                touka = true;
            }
            //秒針
            if(Array.IndexOf(cmds, "/secHand") > 0)
            {
                secHandCheck = true;
            }
            //分針
            if(Array.IndexOf(cmds, "/minHand") > 0)
            {
                minHandCheck = true;
            }
            //日付
            if(Array.IndexOf(cmds, "/date") > 0)
            {
                dateCheck = true;
            }
            //透明度
            int index = Array.IndexOf(cmds, "/Opacity");
            if(index > 0 && index +1 < cmds.Length)
            {
                try
                {
                    if (int.Parse(cmds[index + 1]) > 9)
                    {
                        this.Opacity = int.Parse(cmds[index + 1]) / 100d;
                    }
                    else
                    {
                        this.Opacity = 0.1;
                    }
                }
                catch
                {

                }
            }
            //大きさ
            index = Array.IndexOf(cmds, "/size");
            if (index > 0 && index + 1 < cmds.Length)
            {
                try
                {
                    int size = int.Parse(cmds[index + 1]);
                    if (49 < size && size < 1001)
                    {
                        this.Size = new Size(size, size);
                    }
                    else
                    {
                        this.Size = new Size(300, 300);
                    }
                }
                catch
                {

                }
            }
        }

        private void clokLine()
        {
            Graphics g = Graphics.FromImage(clock);

            int centerX = pictureBox1.Width / 2;        //中心X軸
            int centerY = pictureBox1.Height / 2;       //中心Y軸

            g.DrawEllipse(Pens.White, 1, 1, pictureBox1.Width - 3, pictureBox1.Height - 3); //時計の縁

            //文字盤の線を描く
            for (int i = 0; i < 60; i++)
            {
                //座標をだす
                double lineLength = 1d - 0.1;
                double lineTipX = centerX + (centerX * Math.Cos((Math.PI / 30) * i));
                double lineX = centerX + (centerX * Math.Cos((Math.PI / 30) * i)) * lineLength;
                double lineTipY = centerY + (centerY * Math.Sin((Math.PI / 30) * i));
                double lineY = centerY + (centerY * Math.Sin((Math.PI / 30) * i)) * lineLength;
                double lineEdgeX = lineX - (1 * Math.Cos((Math.PI / 30) * i));
                double lineEdgeY = lineY - (1 * Math.Sin((Math.PI / 30) * i));
                //描画
                Pen line = new Pen(Color.Black, 1);
                Pen FiveLine = new Pen(Color.Black, 6);
                Pen FiveLineEdge = new Pen(Color.White, 8);
                if (i % 5 == 0)
                {
                    g.DrawLine(FiveLineEdge, (float)lineTipX, (float)lineTipY, (float)lineEdgeX, (float)lineEdgeY);
                    g.DrawLine(FiveLine, (float)lineTipX, (float)lineTipY, (float)lineX, (float)lineY);
                }
                else
                {
                    g.DrawLine(line, (float)lineTipX, (float)lineTipY, (float)lineX, (float)lineY);
                }
            }
            //円を描く
            g.DrawEllipse(Pens.Black, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);

            g.Dispose();
        }

        DateTime nowTime;
        public bool touka = false;
        public bool secHandCheck = false;
        public bool minHandCheck = false;
        public bool dateCheck = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(clock);
            SolidBrush clockBackColor;
            if (touka)
            {
                clockBackColor = new SolidBrush(Color.Green);
            }
            else
            {
                clockBackColor = new SolidBrush(Color.White);
            }

            //円を描く
            g.FillEllipse(clockBackColor, 0, 0, pictureBox1.Width-1, pictureBox1.Height-1);
            
            int centerX = pictureBox1.Width / 2;        //中心X軸
            int centerY = pictureBox1.Height / 2;       //中心Y軸
            
            //現在時刻の取得
            nowTime = DateTime.Now;
            //時間の12時間表示
            double nowHour = nowTime.Hour;
            if (nowHour > 12)
            {
                nowHour = nowHour - 12;
            }
            //ぬるぬる計算
            double nowSecond = nowTime.Second;                  //秒針
            if(secHandCheck)
            {
                nowSecond = nowSecond + (double)nowTime.Millisecond / 1000;
            }
            double nowMinute = nowTime.Minute;                  //分針
            if(minHandCheck && nowSecond >= 59)
            {
                nowMinute = nowMinute + (double)nowTime.Millisecond / 1000;
            }
            nowHour = nowHour + nowMinute/*(double)nowTime.Minute*/ / 60;    //時針

            //針先端の座標算出
            //時針
            double houHandLength = 0.5;
            double houHandTipX = centerX + (centerX * ((Math.Cos(((nowHour * Math.PI) / 6) - (Math.PI / 2))))) * houHandLength;
            double houHandTipY = centerY + (centerY * ((Math.Sin(((nowHour * Math.PI) / 6) - (Math.PI / 2))))) * houHandLength;
            //分針
            double minHandLength = 0.84;
            double minHandTipX = centerX + (centerX * ((Math.Cos(((nowMinute * Math.PI) / 30) - (Math.PI / 2))))) * minHandLength;
            double minHandTipY = centerY + (centerY * ((Math.Sin(((nowMinute * Math.PI) / 30) - (Math.PI / 2))))) * minHandLength;
            //秒針
            double secHandLength = 0.97;
            double secHandTipX = centerX + (centerX * ((Math.Cos(((nowSecond * Math.PI) / 30) - (Math.PI / 2))))) * secHandLength;
            double secHandTipY = centerY + (centerY * ((Math.Sin(((nowSecond * Math.PI) / 30) - (Math.PI / 2))))) * secHandLength;
            double secHandOppositeX = centerX + (centerX * ((Math.Cos(((nowSecond * Math.PI) / 30) + (Math.PI / 2))))) * (secHandLength * 0.2);    //反対側の座標
            double secHandOppositeY = centerY + (centerY * ((Math.Sin(((nowSecond * Math.PI) / 30) + (Math.PI / 2))))) * (secHandLength * 0.2);    //反対側の座標
            //縁の先端の座標算出
            //時針
            double houEdgeTipX = houHandTipX + (1 * ((Math.Cos(((nowHour * Math.PI) / 6) - (Math.PI / 2)))));
            double houEdgeTipY = houHandTipY + (1 * ((Math.Sin(((nowHour * Math.PI) / 6) - (Math.PI / 2)))));
            //分針
            double minEdgeTipX = minHandTipX + (1 * ((Math.Cos(((nowTime.Minute * Math.PI) / 30) - (Math.PI / 2)))));
            double minEdgeTipY = minHandTipY + (1 * ((Math.Sin(((nowTime.Minute * Math.PI) / 30) - (Math.PI / 2)))));
            //秒針
            double secEdgeTipX = secHandTipX + (1 * ((Math.Cos(((nowTime.Second * Math.PI) / 30) - (Math.PI / 2)))));
            double secEdgeTipY = secHandTipY + (1 * ((Math.Sin(((nowTime.Second * Math.PI) / 30) - (Math.PI / 2)))));
            double secEdgeOppositeX = secHandOppositeX + (1 * ((Math.Cos(((nowTime.Second * Math.PI) / 30) + (Math.PI / 2)))));
            double secEdgeOppositeY = secHandOppositeY + (1 * ((Math.Sin(((nowTime.Second * Math.PI) / 30) + (Math.PI / 2)))));

            //縁の描画
            Pen houEdge = new Pen(Color.White, 10);          //時針の縁ペン指定
            g.DrawLine(houEdge, centerX, centerY, (float)houEdgeTipX, (float)houEdgeTipY);
            Pen minEdge = new Pen(Color.White, 7);          //分針の縁ペン指定
            g.DrawLine(minEdge, centerX, centerY, (float)minEdgeTipX, (float)minEdgeTipY);
            Pen secEdge = new Pen(Color.White, 4);          //秒針の縁ペン指定
            g.DrawLine(secEdge, (float)secEdgeOppositeX, (float)secEdgeOppositeY, (float)secEdgeTipX, (float)secEdgeTipY);
            clokLine();         //文字盤の線の描画
            //針本体の描画
            Pen hou = new Pen(Color.Black, 8);          //時針のペン指定
            g.DrawLine(hou, centerX, centerY, (float)houHandTipX, (float)houHandTipY);
            Pen min = new Pen(Color.Black, 5);          //分針のペン指定
            g.DrawLine(min, centerX, centerY, (float)minHandTipX, (float)minHandTipY);
            Pen sec = new Pen(Color.Red, 2);          //秒針のペン指定
            g.DrawLine(sec, (float)secHandOppositeX, (float)secHandOppositeY, (float)secHandTipX, (float)secHandTipY);

            //中心の円
            SolidBrush centerCircle = new SolidBrush(Color.Red);
            g.FillEllipse(centerCircle, centerX - 7, centerY - 7, 14, 14);
            g.FillEllipse(Brushes.White, centerX - 4, centerY - 4, 8, 8);

            //日付の描画
            if(dateCheck)
            {
                Font fnt = new Font("Meiryo", pictureBox1.Height / 11);
                RectangleF yearbasyo = new RectangleF(0, pictureBox1.Height / 4, pictureBox1.Width, pictureBox1.Height / 4);
                RectangleF datebasyo = new RectangleF(0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 4);
                StringFormat sf = new StringFormat();
                //文字を真ん中に表示
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                //文字列作成
                System.Globalization.CultureInfo ci =new System.Globalization.CultureInfo("ja-JP", false);
                ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();

                string year = nowTime.ToString("gy年", ci);
                string date = nowTime.ToString("M月d日(ddd)", ci);

                //描画
                //背景白枠
                int[,] rectMargin = new int[,]{ { -1, -1},
                                                {  1, -1},
                                                {  1,  1},
                                                { -1,  1}};
                for (int i = 0; i < 4; i++)
                {
                    RectangleF yRect = new RectangleF(yearbasyo.X + rectMargin[i, 0], yearbasyo.Y + rectMargin[i, 1], yearbasyo.Width, yearbasyo.Height);
                    RectangleF dRect = new RectangleF(datebasyo.X + rectMargin[i, 0], datebasyo.Y + rectMargin[i, 1], datebasyo.Width, datebasyo.Height);
                    g.DrawString(year, fnt, Brushes.White, yRect, sf);
                    g.DrawString(date, fnt, Brushes.White, dRect, sf);

                }

                //本体
                g.DrawString(year, fnt, Brushes.Black, yearbasyo, sf);
                g.DrawString(date, fnt, Brushes.Black, datebasyo, sf);

                fnt.Dispose();
            }

            g.Dispose();

            pictureBox1.Image = clock;
            pictureBox1.Refresh();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        settingForm setForm;
        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(設定ToolStripMenuItem.Checked)
            {
                setForm = new settingForm();
                setForm.Show(this);
            }
            else
            {
                setForm.Close();
                setForm.Dispose();
            }
            
        }

        //ウィンドウの移動
        private int mouseX;
        private int mouseY;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - mouseX;
                Top += e.Y - mouseY;
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            clock = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //バルーンヒントの設定
                //バルーンヒントのタイトル
                notifyIcon1.BalloonTipTitle = "とけい";
                //バルーンヒントに表示するメッセージ
                notifyIcon1.BalloonTipText = DateTime.Now.ToString() + "\nメニューを表示するには右クリック";
                //バルーンヒントに表示するアイコン
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                //バルーンヒントを表示する
                //表示する時間をミリ秒で指定する
                notifyIcon1.ShowBalloonTip(10000);
            }
        }

        private void 背景透過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            背景透過ToolStripMenuItem.Checked = !背景透過ToolStripMenuItem.Checked;
            touka = 背景透過ToolStripMenuItem.Checked;
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            背景透過ToolStripMenuItem.Checked = touka;
            分針ぬるぬるToolStripMenuItem.Checked = minHandCheck;
            秒針ぬるぬるToolStripMenuItem.Checked = secHandCheck;
            日付表示ToolStripMenuItem.Checked = dateCheck;
        }

        private void 秒針ぬるぬるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            秒針ぬるぬるToolStripMenuItem.Checked = !秒針ぬるぬるToolStripMenuItem.Checked;
            secHandCheck = 秒針ぬるぬるToolStripMenuItem.Checked;
        }

        private void 分針ぬるぬるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            分針ぬるぬるToolStripMenuItem.Checked = !分針ぬるぬるToolStripMenuItem.Checked;
            minHandCheck = 分針ぬるぬるToolStripMenuItem.Checked;
        }

        private void 日付表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            日付表示ToolStripMenuItem.Checked = !日付表示ToolStripMenuItem.Checked;
            dateCheck = 日付表示ToolStripMenuItem.Checked;
        }
    }
}
