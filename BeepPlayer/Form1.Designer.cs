using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BeepPlayer {
    partial class frmBeePlayer {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        /// 

        
        private void InitializeComponent() {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.cboSongs = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(3, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 272);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "do 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(69, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 272);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "re 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(135, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 272);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "mi 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(201, 0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 272);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "fa 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(267, 0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 272);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "sol 5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(333, 0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 272);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "la 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(399, 0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 272);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "si 7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.Location = new System.Drawing.Point(465, 0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 272);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "do 8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.lblScore);
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Controls.Add(this.cboSongs);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(0, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(552, 406);
            this.palMain.TabIndex = 0;
            this.palMain.SizeChanged += new System.EventHandler(this.frmBeePlayer_SizeChanged);
            this.palMain.Paint += new System.Windows.Forms.PaintEventHandler(this.palMain_Paint);
            // 
            // cboSongs
            // 
            this.cboSongs.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSongs.FormattingEnabled = true;
            this.cboSongs.Location = new System.Drawing.Point(12, 290);
            this.cboSongs.Name = "cboSongs";
            this.cboSongs.Size = new System.Drawing.Size(522, 28);
            this.cboSongs.TabIndex = 1;
            this.cboSongs.SelectedIndexChanged += new System.EventHandler(this.cboSongs_SelectedIndexChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoEllipsis = true;
            this.lblScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.Location = new System.Drawing.Point(12, 337);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(522, 46);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "label1";
            // 
            // frmBeePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 406);
            this.Controls.Add(this.palMain);
            this.Name = "frmBeePlayer";
            this.Text = "簡易電子琴";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Panel palMain;
        private ComboBox cboSongs;
        private Label lblScore;
    }
}

