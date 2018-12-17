using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool getString(out string s)
        {
            if (textBox1.Text.Trim() == "")
            {
                s = "";
                MessageBox.Show("Введите не пустую строку!");
                return false;
            }
            s = textBox1.Text.Trim();
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int ctr = 0;
            if(getString(out str))
            {
                foreach (var c in str)
                {
                    if (c >= 48 && c <= 57)
                        ctr++;
                }
                if (ctr == 0)
                    textBox2.Text = "В строке нет цифр!";
                else textBox2.Text = "В строке " + ctr.ToString() + " цифр.";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string str, res = "";
            if(getString(out str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '*' &&
                        str[i + 1] == '_' &&
                        str[i + 2] == '*')
                    {
                        res += "^_^";
                        i += 2;
                    }
                    else res += str[i];
                }
                textBox3.Text = res;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str, tmp="",res = "";
            if (getString(out str))
            {
                foreach (var c in str)
                {
                    if (c >= 48 && c <= 57)
                        tmp += c;
                    else
                    {
                        if (tmp != "")
                        {
                            res += (int.Parse(tmp)*2).ToString();
                            tmp = "";
                        }
                        res += c;
                    }
                }
                if(tmp!="")
                    res+= (int.Parse(tmp) * 2).ToString();
                textBox4.Text = res;
            }
        }
    }
}



