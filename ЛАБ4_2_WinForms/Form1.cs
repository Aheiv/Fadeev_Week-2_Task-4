using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ4_2_WinForms
{
    public partial class Form1 : Form
    {
        static void perevod(int i, ref string s)
        {
            if (i > 0)
            {
                perevod(i / 2, ref s);
                s += (i % 2).ToString();
            }
            if (i == 0)
            {
                s = "0";
            }
            if (i < 0)
            {
                s = Convert.ToString(i, 2);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val_10;
            val_10 = int.Parse(numericUpDown1.Text);
            string val_2 = "";
            perevod(val_10, ref val_2);
            textBox1.Text = val_2;
        }
    }
}
