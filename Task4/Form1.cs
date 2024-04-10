using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_necessary.Enabled = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }


        private void button_run_Click(object sender, EventArgs e)
        {
            string str_a = textBox1.Text;
            float buy_k;
            bool isBuyKValid = float.TryParse(str_a, out buy_k);
            if (!isBuyKValid)
            {
                buy_k = 0;
                textBox1.Text = "0";
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = SystemColors.WindowText;
            }

            string str_b = textBox2.Text;
            float sele;
            bool isSeleValid = float.TryParse(str_b, out sele);
            if (!isSeleValid)
            {
                sele = 0;
                textBox2.Text = "0";
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                textBox2.ForeColor = SystemColors.WindowText;
            }

            string str_c = textBox3.Text;
            float sum;
            bool isSumValid = float.TryParse(str_c, out sum);
            if (!isSumValid)
            {
                sum = 100;
                textBox3.Text = "100";
                textBox3.ForeColor = Color.Blue;
            }
            else
            {
                textBox3.ForeColor = SystemColors.WindowText;
            }

            if (radioButton_buy.Checked)
            {

                buy_k *= sum;
                label_necessary.Text = buy_k.ToString();
            }
            else if (radioButton_sell.Checked)
            {

                sele *= sum;
                label_necessary.Text = sele.ToString();
            }
        }


    }
}
