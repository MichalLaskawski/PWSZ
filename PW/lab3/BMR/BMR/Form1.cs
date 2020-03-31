using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && radioButton1.Checked)
            {
                int waga = Convert.ToInt32(textBox1.Text);
                int wzrost = Convert.ToInt32(textBox2.Text);
                int wiek = Convert.ToInt32(textBox3.Text);

                Double bmr = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek) + 5);

                label6.Text = bmr.ToString();
            }
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && radioButton2.Checked)
            {
                int waga = Convert.ToInt32(textBox1.Text);
                int wzrost = Convert.ToInt32(textBox2.Text);
                int wiek = Convert.ToInt32(textBox3.Text);

                Double bmr = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek) - 161);

                label6.Text = bmr.ToString();
            }

           /*else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "brak danych";
            }
            //cos to else powodowało że ify nie chciały działać poprawnie
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
