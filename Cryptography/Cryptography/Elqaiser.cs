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
    public partial class Elqaiser : Form
    {
        public Elqaiser()
        {
            InitializeComponent();
        }
        char[] cipher;
        String s;
        int k;
        char[] charArr;
        string str = " ";
        private void btnbutton1_Click(object sender, EventArgs e)
        {
            s = txtBox1.Text;
            k = Convert.ToInt32(txtBox2.Text);
            charArr = s.ToCharArray();
            cipher = new char[charArr.Length];
            for (int i = 0; i < s.Length; i++)
            {
                int temp = Convert.ToInt32(charArr[i]);
                temp += k;
                cipher[i] = Convert.ToChar(temp);

            }


            for (int i = 0; i < cipher.Length; i++)
            {

                str += cipher[i];
            }
            label3.Text = "Encrypted Text : " + str;

        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            str = " ";

            for (int i = 0; i < s.Length; i++)
            {
                int temp = Convert.ToInt32(cipher[i]);
                temp -= k;
                cipher[i] = Convert.ToChar(temp);

            }


            for (int i = 0; i < cipher.Length; i++)
            {

                str += cipher[i];
            }
            label4.Text = "Original Text : " + str;
        }
    }
}
