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
            long a, n, st;
            a = (long)numericUpDown1.Value;
            n = (long)numericUpDown2.Value;
            if (n > 1) { 
            st = (long)((Math.Pow(a, n-1))%n);
            //Console.WriteLine(st);

            // if (b > 0)
            // {
            if (st == 1)
            {
                label4.Text = "Число " + n + " псевдопростое по основанию " + (a);

            }
            else
            {
                label4.Text = "Число " + n + " составное";
                label5.Text = factor1(n);

            }

           } else label4.Text = "Число должно быть больше 1";
        }

       

        public string factor1(long m)
        {
            string str = m+" = 1";
            long num = m;
            for (int i = 0; num % 2 == 0; num /= 2)
            {
                str = str + "*" + 2; 
              
            }
            for (int i = 3; i <= num;)
            {
                if (num % i == 0)
                {
                    str = str + "*" + i;
                
                    num /= i;
                }
                else
                {
                    i += 2;
                }

            }
            //Console.WriteLine(str);
            return str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long a1, n, st1;
            Boolean f = true;
            a1 = (long)numericUpDown1.Value;
            n = (long)numericUpDown2.Value;
            if (a1 >= 2)
                {
                for (long i = a1; i >= 2; i = i - 1)
                {
                    st1 = (long)((Math.Pow(a1, n - 1)) % n);
                    if (st1 != 1)
                    {
                        f = false;
                        Console.WriteLine(st1);
                        Console.WriteLine(i);
                        break;
                    }
                }
                if (f) { label4.Text = "Число " + n + " псевдопростое по основанию " + (a1); }
                else { label4.Text = "Число " + n + " составное";
                    label5.Text = factor1(n);
                }
            }
            else { label4.Text = "Основание должно быть больше 1"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
