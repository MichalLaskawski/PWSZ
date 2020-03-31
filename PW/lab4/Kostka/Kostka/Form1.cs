using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void key_r(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                Random rnd = new Random();
                int[] T = new int[6];
                for (int i = 0; i <= 5; i++)
                {
                    T[i] = rnd.Next(1, 6);
                }


                label2.Text = "Wylosowałeś: ";
                label3.Text = T.ToString();
                label4.Text = "";
            }
            else
            {
                label4.Text = "nieznany błąd";
            }

        }

        private void doSchowka(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(label3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] T = new int[6];
            for (int i = 0; i <= 5; i++)
            {
                T[i] = rnd.Next(1, 6);
            }


            label2.Text = "Wylosowałeś: ";
            label3.Text = T.ToString();
            label4.Text = "";
        }
    }
}
