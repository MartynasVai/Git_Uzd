using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_uzd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uzd1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static class GlobalData
        {
            public static short[] M = new short[10];//Globalus masyvas
        };



        private void Uzd1But_Click(object sender, EventArgs e)
        {
            long Skaic;
            short sum=0;//suma
            string Tekstas;

            Tekstas = uzd1Box.Text;

            if (long.TryParse(Tekstas, out long result))
            {
                Skaic = long.Parse(Tekstas);
                
                if (Skaic > 1000000000)
                {
                    label1.Text = "";
                    for(int i=0; i < 10; i++)
                    {
                        GlobalData.M[i] = (short)(Skaic % 10);
                        Skaic /= 10;
                        sum += GlobalData.M[i];
                    }

                    Uzd1Ats.Text = sum.ToString();

                }
                else label1.Text = "Įveskite visus 10 skaičių";

            }
            else { 
            label1.Text = "Įvyko klaida";
                uzd1Box.Text = "";
        }









        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String aa = Uzd1Ats.Text;

            if (int.TryParse(aa, out int result)) { 
            int a = int.Parse(aa);


            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j <= (a-i)/2; j++)
                    richTextBox1.AppendText(" ");
                for (int j = 0; j <= i; j++)
                    richTextBox1.AppendText("*");

                    richTextBox1.AppendText("\n");
                }

        }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";



        }
    }
}
