using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day19_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Результат: ";
            label3.Text = "Результат: ";

            radioButton1.Checked = true;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите предложение");
                return;
            }

            if (checkBox1.Checked)
            {
                string letter;
                string[] arr = textBox1.Text.Split(' ');
                if (radioButton1.Checked)
                {
                    letter = radioButton1.Text;
                }
                else
                {
                    letter = radioButton2.Text;
                }
                string result = "";
                for(int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr[i].Length; j++)
                    {
                        if(arr[i][j].ToString() == letter)
                        {
                            result += " " + arr[i];
                            break;
                        }
                    }
                }
                label2.Text = "Результат:" + result;
            }
            if(checkBox2.Checked)
            {
                string letter;
                string[] arr = textBox1.Text.Split(' ');
                if (radioButton1.Checked)
                {
                    letter = radioButton1.Text;
                }
                else
                {
                    letter = radioButton2.Text;
                }
                string result = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    bool flag = true;
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j].ToString() == letter)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        result += " " + arr[i];
                    }
                }
                label3.Text = "Результат:" + result;
            }
        }
    }
}
