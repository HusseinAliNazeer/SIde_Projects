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
    public partial class XOR : Form
    {
        public XOR()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        //function to convert string to Byte array to get the character of binary string 
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);
                //2 is the base of binary conversion
                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
        public string binaryXOR(string inputString, char k = 'H')
        {
            string [] strArr= new string[inputString.Length];
            string [] ci = new string[inputString.Length];
            int count = 0;
            string kx = Convert.ToString(k, 2).PadLeft(8,'0');
            foreach (char c in inputString)
            {
                strArr[count] = Convert.ToString(c, 2).PadLeft(8, '0');
                count++;
            }
            for (int i = 0; i < strArr.Length; i++)
            {
                count = 0;
                foreach (char ch in strArr[i])
                {
                    if (ch == kx[count] || kx[count] == ch)
                        ci[i] += '0';
                    else
                        ci[i] += '1';
                    count++;
                }
            }
            string re = "";
            foreach (string s in ci)
            {
                re += Encoding.ASCII.GetString(GetBytesFromBinaryString(s));
            }
            return re;
        }
        String text ;
        String cihper;
        private void btnbutton1_Click(object sender, EventArgs e)
        {
            text = txtBox1.Text;
            cihper = binaryXOR(text);
            label3.Text += cihper;
            
        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            String decihper = binaryXOR(cihper);
            label4.Text += decihper;
        }
    }
}
