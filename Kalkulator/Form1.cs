using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);
            if (a == 0)
            {
                float x = -c / b;

                MessageBox.Show("Линейное уравнение, x=" + x);
            }
            else
            {
                float D = b * b - 4 * a * c;
                if (D < 0)
                {
                    MessageBox.Show("Квадратное уравнение, действительных корней нет");
                }
                else if (D == 0)
                {
                    float x = -b / (2 * a);
                    MessageBox.Show("Квадратное уравнение, 2 корня совпадают. x1=x2=" + x);
                }
                else
                {
                    double x1 = System.Math.Sqrt(D);
                    double x2 = (-b + x1) / (2 * a);
                    x1 = (-b - x1) / (2 * a);
                    MessageBox.Show("Квадратное уравнение, x1=" + x1 + ", x2=" + x2);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
