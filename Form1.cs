using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SUSI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxdrink.Items.Add("아메리카노");
            cbxdrink.Items.Add("카페라테");
            cbxdrink.Items.Add("카푸치노");

            cbxdrink.SelectedItem = "아메리카노";
        }


         private void btnCalc_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string drink = cbxdrink.SelectedItem.ToString();

            double amount = double.Parse(txtamount.Text);

            double price = 0;


            if (drink == "아메리카노")
                price = 3000;
            else if (drink == "카페라테")
                price = 4000;
            else if (drink == "카푸치노")
                price = 4500;

            double total = price * amount;


            double discount = 0;
            if (amount >= 3)
            {
                discount = total / 10;
            }

            double finalPrice = total - discount;

            txtResult.Text =
                "주문자: " + name + "\r\n" +
                "주문내용: " + drink + " " + amount + "잔\r\n" +
                "주문금액: " + total + "원\r\n" +
                "할인금액: " + discount + "원\r\n" +
                "결제금액: " + finalPrice + "원";
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            
            txtname.Text = "";
            cbxdrink.Text = "아메리카노";
            txtamount.Text = "";
            txtResult.Text = "";


        }
    }
}

