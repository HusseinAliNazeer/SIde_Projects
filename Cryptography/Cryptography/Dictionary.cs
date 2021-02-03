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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        Dictionary<string, string> key = new Dictionary<string, string>(); 
        string [] pl;
        string [] plEncrypted;
        string [] keys = new string [10]; 
        //KeyValuePair<TKey,TValue> x "x has "

        private void btnbutton1_Click(object sender, EventArgs e)
        {

            key.Add("hussein", "DrVirus");
            key.Add("hazem", "Elkhateer");
            key.Add("eslam", "Elshabh");
            key.Add("france", "Hello");
            key.Add("city", "man");
            pl = txtBox1.Text.Split(',');
            plEncrypted = new string[pl.Length];

            int i = 0;
            foreach (string el in pl)
            {

                keys[i] = el;
                string temp = " ";
                bool t = key.TryGetValue(el, out temp);
                plEncrypted[i] = temp;
                i++;
            }

            foreach (string el in plEncrypted)
            {
                
                label3.Text += el + " ";
            }

        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            int i = 0;
            string [] decrypted = new string [plEncrypted.Length];
            foreach (string el in plEncrypted)
            {
                decrypted[i] = keys[i];
                i++;
            }
            foreach (string el in decrypted)
            {
                label4.Text += el + " ";
            }
        }
    }
}
