using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomaTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, st;
            a = (int)numericUpDown1.Value;
            b = (int)numericUpDown2.Value -1;
            st = (int)(Math.Pow(a, b));
            Console.WriteLine(st);

            if (b > 0)
            {
                if (st % (b+1) == 1)
                {
                    label4.Text = "Число " + a + " псевдопростое по основанию " + (b+1);

                }
                else label4.Text = "Число " + a + " составное";

            } else label4.Text = "Основание должно быть больше 1";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
