using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ4_1_WinForms
{
    public partial class Form1 : Form
    {
        static double func(int n, double sum, int N)
        {
            if (n == 1)
            {
                sum = (n + Math.Sqrt(sum));
                return N / Math.Sqrt(sum);
            }
            if (n == N) sum = n;
            else
            {
                sum = (n + Math.Sqrt(sum));
            }
            n--;

            return func(n, sum, N);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            double f;
            if (numericUpDown1.Value <= 0) MessageBox.Show("Некоректный ввод данных!");
            else
            {
                N = int.Parse(numericUpDown1.Text);
                f = func(N, 0, N);
                textBox1.Text = f.ToString();
            }
        }
    }
}
