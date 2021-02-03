using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class MonoAlpha : Form
    {
        public MonoAlpha()
        {
            InitializeComponent();
        }

        char[] keys = {'q','a','z','w','s','x','e','d','c','r','f','v','t','g','b','y','h','n','u','j','m','i','k','o','l','p'};
        char[] cipher = new char [26];
        char[] charArr;
        string s = "";
        int i = 0;
        private void btnbutton1_Click(object sender, EventArgs e)
        {
            s = txtBox1.Text;
            charArr = s.ToCharArray();
            foreach(char c in charArr)
            {
                int index = Math.Abs(Convert.ToInt32(c-97));
                cipher[i] = keys[index];
                i++;


            }
            foreach (char c in cipher)
            {
                label3.Text += c;
            }
        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            
            foreach (char c in cipher)
            {
                if (i == charArr.Length)
                    break;
                int index = Math.Abs(Convert.ToInt32(c - 97));
                charArr[i] = keys[index];
                
                i++;
            }
            i = 0;
            foreach (char c in charArr)
            {
                label4.Text += c;
            }
        }
    }
}
