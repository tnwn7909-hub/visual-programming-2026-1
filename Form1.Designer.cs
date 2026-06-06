namespace Myproject1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.picMole = new System.Windows.Forms.PictureBox();
            this.pnlGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMole)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameArea
            // 
            this.pnlGameArea.BackColor = System.Drawing.Color.Green;
            this.pnlGameArea.Controls.Add(this.picMole);
            this.pnlGameArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGameArea.Location = new System.Drawing.Point(12, 12);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(576, 213);
            this.pnlGameArea.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "게임 시작!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 295);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(47, 12);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "점수 : 0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 325);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(93, 12);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "남은 시간 : 30초";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(12, 354);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(71, 12);
            this.labelHighScore.TabIndex = 4;
            this.labelHighScore.Text = "최고점수 : 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "쉬움",
            "보통",
            "어려움"});
            this.cmbDifficulty.Location = new System.Drawing.Point(364, 253);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 20);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // picMole
            // 
            this.picMole.Image = global::Myproject1.Properties.Resources.Adobe_Express___file;
            this.picMole.Location = new System.Drawing.Point(44, 36);
            this.picMole.Name = "picMole";
            this.picMole.Size = new System.Drawing.Size(49, 44);
            this.picMole.TabIndex = 1;
            this.picMole.TabStop = false;
            this.picMole.Click += new System.EventHandler(this.picMole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGameArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameArea;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.PictureBox picMole;
    }
}

