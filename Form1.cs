using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myproject1
{
    public partial class Form1 : Form
    {
        int score = 0;
        int highScore = 0;
        int timeLeft = 30;

        Random rand = new Random();

        // 클릭 버튼의 원래 위치 저장
        System.Drawing.Point originalPosition;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            // 원래 위치 저장
            originalPosition = picMole.Location;

            

            picMole.Enabled = false;


            cmbDifficulty.SelectedIndex = 1; // 기본값 보통

            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0;

            // 난이도 설정
            if (cmbDifficulty.SelectedItem.ToString() == "쉬움")
            {
                timeLeft = 30;
                timer1.Interval = 1500; // 1.5초마다 이동
            }
            else if (cmbDifficulty.SelectedItem.ToString() == "보통")
            {
                timeLeft = 30;
                timer1.Interval = 1000; // 1초마다 이동
            }
            else // 어려움
            {
                timeLeft = 30;
                timer1.Interval = 500; // 0.5초마다 이동
            }

            

            labelScore.Text = "점수 : 0";
            labelTime.Text = "남은 시간 : " + timeLeft + "초";

            btnStart.Enabled = false;
            picMole.Enabled = true;
            cmbDifficulty.Enabled = false;

            MoveMoleRandom();

            timer1.Start();
        }




        // 랜덤 위치 이동
        private void MoveMoleRandom()
        {
            int maxX = pnlGameArea.Width - picMole.Width;
            int maxY = pnlGameArea.Height - picMole.Height;

            int x = rand.Next(0, maxX);
            int y = rand.Next(0, maxY);

            picMole.Location = new System.Drawing.Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;

            labelTime.Text = "남은 시간 : " + timeLeft + "초";

            // 1초마다 버튼 이동
            MoveMoleRandom();

            if (timeLeft <= 0)
            {
                timer1.Stop();

                // 최고 점수 갱신
                if (score > highScore)
                {
                    highScore = score;
                    labelHighScore.Text = "최고 점수 : " + highScore;
                }

                MessageBox.Show(
                    "게임 종료!\n\n" +
                    "최종 점수 : " + score +
                    "\n최고 점수 : " + highScore);

                // 원래 위치 복귀
                picMole.Location = originalPosition;

                picMole.Enabled = false;

                btnStart.Enabled = true;
                btnStart.Text = "다시 시작";
                cmbDifficulty.Enabled = true;
            }
    }

        private void picMole_Click(object sender, EventArgs e)
        {
            score++;

            labelScore.Text = "점수 : " + score;

           
        }
    }
}
