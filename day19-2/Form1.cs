using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day19_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите радиус");
                return;
            }
            try
            {
                int d = Convert.ToInt32(textBox1.Text) * 2;
                double s = Math.PI * Math.Pow(d, 2);
                double v = (1.0 / 6.0) * Math.PI * Math.Pow(d, 3);
                v = Math.Round(v, 3);
                label3.Text = "Объем шара: " + v.ToString();
                double a = Math.Pow(d / Math.Sqrt(3), 3);
                a = Math.Round(a, 3);
                label4.Text = "Объем куба: " + a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректные данные.\n" + ex.Message);
            }
        }
    }
}
