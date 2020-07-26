using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindFuncButton(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Сheck(textBox1.Text) &&
                textBox2.Text != "" && Сheck(textBox2.Text) &&
                textBox3.Text != "" && Сheck(textBox3.Text))
            {
                textBox4.Clear();
                for (double i = Convert.ToDouble(textBox1.Text); i <= Convert.ToDouble(textBox2.Text); i += Convert.ToDouble(textBox3.Text))
                    try
                {
                    textBox4.AppendText("y("+i+")="+f(i) + Environment.NewLine);
                }
                catch
                {
                    textBox4.AppendText("y(" + i + ")=error" + Environment.NewLine);
                }
            }
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] != '-' && arr[i] != ',')
                {
                    return false;
                }
            }
            return true;
        }
        private static double f(double x)
        {
            try
            {
                if (x * x - 2 == 0 || x * x * x - 1 < 0) throw new Exception();
                else return (x + 4) / (x * x - 2) + Math.Sqrt(x * x * x - 1);
            }
            catch
            {
                throw;
            }

        }
    }
}
