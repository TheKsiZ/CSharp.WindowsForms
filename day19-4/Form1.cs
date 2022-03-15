using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day19_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите район");
                return;
            }
            if(!radioButton6.Checked)
            {
                if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                {
                    MessageBox.Show("Некорректно отмеченные данные об объекте");
                    return;
                }
            }
            if (!radioButton7.Checked)
            {
                if (checkBox4.Checked || checkBox5.Checked)
                {
                    MessageBox.Show("Некорректно отмеченные данные об объекте");
                    return;
                }
            }

            string result = "";
            
            result += "Район: " + comboBox1.Text + "\n";
            
            if (radioButton6.Checked)
            {
                result += radioButton6.Text + ":";
                List<string> list = new List<string>();
                if (checkBox1.Checked)
                {
                    list.Add(checkBox1.Text);
                }
                if (checkBox2.Checked)
                {
                    list.Add(checkBox2.Text);
                }
                if (checkBox3.Checked)
                {
                    list.Add(checkBox3.Text);
                }
                for(int i = 0; i < list.Count; i++)
                {
                    if(i == list.Count - 1)
                    {
                        result += " " + list[i];
                        break;
                    }
                    result += " " + list[i] + ",";
                }
            }
            else
            {
                result += radioButton7.Text + ":";
                List<string> list = new List<string>();
                if (checkBox4.Checked)
                {
                    list.Add(checkBox1.Text);
                }
                if (checkBox5.Checked)
                {
                    list.Add(checkBox2.Text);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 1)
                    {
                        result += " " + list[i];
                        break;
                    }
                    result += " " + list[i] + ",";
                }
            }
            result += "\n";

            string money = "";
            if (radioButton1.Checked)
            {
                money = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                money = radioButton2.Text;
            } 
            else if (radioButton3.Checked)
            {
                money = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                money = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                money = radioButton5.Text;
            }

            bool flag = true;
            for(int i = 0; i < money.Length; i++)
            {
                if (Char.IsLetter(money[i]) && money[i] != '-')
                {
                    money = money.Insert(i, "$ ");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                result += money + " $";
            }
            else
            {
                result += money;
            }
            
            richTextBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
