using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_LabelControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label2.Text =
                "라파엘로 산치오, 이탈리아, 르네상스 3대 거장, 1483~1520\n\n" +
                "라파엘로(Raphael, Raffaello Sanzio da Urbino)는 동시대의 거장인 " +
                "미켈란젤로, 레오나르도 다빈치와 함께 르네상스 3대 거장으로 알려져 있습니다.\n\n" +
                "가장 유명한 작품은 '아테네 학당(The School of Athens)'으로 " +
                "바티칸 궁전(Apostolic Palace)에 있는 프레스코 벽화입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
