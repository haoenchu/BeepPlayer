using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace BeepPlayer {
    public partial class frmBeePlayer : Form {

        // 記錄初始面板的寬度與高度
        int initWidth = 0;
        int initHeight = 0;

        // 使用 Dictionary 儲存每個控制項的名稱與其初始的矩形區域 (位置與大小)
        // 註：教材中寫 Rect，在 WinForms 中請改用 Rectangle
        Dictionary<string, Rectangle> initControl = new Dictionary<string, Rectangle>();

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
        public frmBeePlayer() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            cboSongs.Items.Add("請選擇曲目...");
            cboSongs.Items.Add("小星星");
            cboSongs.Items.Add("瑪莉有隻小綿羊");
            cboSongs.Items.Add("兩隻老虎");
            cboSongs.SelectedIndex = 0; // 預設選中第一個

            this.initWidth = this.palMain.Width;
            this.initHeight = this.palMain.Height;
            foreach (Control ctl in this.palMain.Controls) {
                this.initControl.Add(ctl.Name, new Rectangle(ctl.Left, ctl.Top, ctl.Width, ctl.Height));
            }
        }

        private void frmBeePlayer_SizeChanged(object sender, EventArgs e) {
            if (this.initWidth == 0 || this.initHeight == 0) return; // 防止除以零

            double width = this.palMain.Width;
            double height = this.palMain.Height;


            double iRatioWith = width / this.initWidth;
            double iRatioHeight = height / this.initHeight;

            foreach (Control ctl in this.palMain.Controls) {
                if (initControl.ContainsKey(ctl.Name)) {
                    ctl.Left = (int)(initControl[ctl.Name].Left * iRatioWith);
                    ctl.Top = (int)(initControl[ctl.Name].Top * iRatioHeight);
                    ctl.Width = (int)(initControl[ctl.Name].Width * iRatioWith);
                    ctl.Height = (int)(initControl[ctl.Name].Height * iRatioHeight);
                }

                // 2. 針對曲譜標籤 (lblScore) 進行特殊寬度調整
                if (ctl.Name == "lblScore") {
                    // 寬度設為面板寬度減去邊距 (例如 20，左右各留 10)
                    ctl.Width = (int)width - 20;
                    // 高度可以給多一點，確保換行後裝得下
                    ctl.Height = (int)(initControl[ctl.Name].Height * iRatioHeight);
                }
                else {
                    ctl.Width = (int)(initControl[ctl.Name].Width * iRatioWith);
                    ctl.Height = (int)(initControl[ctl.Name].Height * iRatioHeight);
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            btn.Enabled = false;
            Beep(freq[btn.TabIndex -1], 300);
            btn.Enabled = true;
        }


       

        private void palMain_Paint(object sender, PaintEventArgs e) {

        }

        private void cboSongs_SelectedIndexChanged(object sender, EventArgs e) {
            // 根據選單索引顯示完整曲譜
            switch (cboSongs.SelectedIndex) {
                case 1: // 小星星 (完整版)
                    lblScore.Text = "曲譜：1 1 5 5 6 6 5 - 4 4 3 3 2 2 1 - " +
                                    "5 5 4 4 3 3 2 - 5 5 4 4 3 3 2 - " +
                                    "1 1 5 5 6 6 5 - 4 4 3 3 2 2 1";
                    break;

                case 2: // 瑪莉有隻小綿羊 (完整版)
                    lblScore.Text = "曲譜：3 2 1 2 3 3 3 - 2 2 2 - 3 5 5 - " +
                                    "3 2 1 2 3 3 3 3 2 2 3 2 1 - -";
                    break;

                case 3: // 兩隻老虎 (完整版)
                    lblScore.Text = "曲譜：1 2 3 1 | 1 2 3 1 | 3 4 5 - | 3 4 5 - | " +
                                    "5 6 5 4 3 1 | 5 6 5 4 3 1 | 2 5 1 - | 2 5 1 -";
                    break;

                default:
                    lblScore.Text = "請選擇曲目以顯示曲譜";
                    break;
            }
        }
    }
}
