using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                
                string arr = Convert.ToString(a);
                string brr = Convert.ToString(b);

                int count = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] != arr[arr.Length - 1 - i])
                    {
                        count++;
                        break;
                    }
                }

                for (int i = 0; i < brr.Length; i++)
                {
                    if (brr[i] != brr[brr.Length - 1 - i])
                    {
                        count++;
                        break;
                    }
                }

                switch(count){
                    case 0:
                        textBox3.Text = "Оба палиндромы";
                        break;
                    case 1:
                        textBox3.Text = "Один палиндром";
                        break;
                    case 2:
                        textBox3.Text = "Оба не палиндромы";
                        break;
                    default:
                        textBox3.Text = "Как?";
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
