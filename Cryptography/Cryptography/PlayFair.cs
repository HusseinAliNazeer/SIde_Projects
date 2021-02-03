using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPro;
namespace Cryptography
{
    public partial class PlayFair : Form
    {
        public PlayFair()
        {
            InitializeComponent();
        }

        public bool isHaveJ(string s)
        {
            for (int j = 0; j <s.Length ; j++)
            {
                if (s[j] == 'j')
                    return true;
                
            }
            return false;
        }

        public static List<int> encr(char c, char[,] arr)
        {
            List<int> s = new List<int>();
            for (int j = 0; j < 5; j++)
                for (int k = 0; k < 5; k++)
                {
                    if (c == arr[j, k])
                    {
                        s.Add(j);
                        s.Add(k);
                        break;
                    }
                }
            return s;
        }
        string ci;
        char[,] arr = new char[,]  {{'c','o','m','p','u'},
                                    {'t','e','r','a','b'},
                                    {'d','f','g','h','i'},
                                    {'k','l','n','q','s'},
                                    {'v','w','x','y','z'}};
        public string s;
        private void btnbutton1_Click(object sender, EventArgs e)
        {
            
            s =  txtBox1.Text.ToLower();
            char[] chArr;
            
            if (s.Length % 2 != 0)
            {
                chArr = new char[s.Length + 1];
                int count = 0;
                foreach (char c in s)
                {
                    chArr[count] = c;
                    count++;
                }
                chArr[s.Length] = 'x';
            }
            else
            {
                chArr = s.ToCharArray();
            }
            int k = 0;
            foreach (char c in chArr)
            {
                if (chArr[k]=='j')
                {
                    chArr[k]='i';
                }
                k++;
            }
            ci ="";
            for (int i = 0; i < chArr.Length; i += 2)
            {
                List<int> fir = new List<int>();
                List<int> sec = new List<int>();
                fir = encr(chArr[i], arr);
                sec = encr(chArr[i + 1], arr);

                if (fir[0] == sec[0])
                {
                    ci += arr[fir[0], fir[1] + 1];
                    ci += arr[fir[0], sec[1] + 1];
                }
                else if (fir[1] == sec[1])
                {
                    ci += arr[fir[0] + 1, fir[1]];
                    ci += arr[sec[0] + 1, sec[1]];

                }
                else
                {
                    ci += arr[fir[0], sec[1]];
                    ci += arr[sec[0], fir[1]];
                }
            }
            MessageBox.Show(ci);
            
        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            string dci = "";
            for (int i = 0; i < ci.Length; i += 2)
            {
                List<int> fir = new List<int>();
                List<int> sec = new List<int>();
                fir = encr(ci[i], arr);
                sec = encr(ci[i + 1], arr);

                if (fir[0] == sec[0])
                {
                    dci += arr[sec[0], fir[1] - 1];
                    dci += arr[sec[0], sec[1] - 1];
                }
                else if (fir[1] == sec[1])
                {
                    dci += arr[fir[0] - 1, sec[1]];
                    dci += arr[sec[0] - 1, sec[1]];

                }
                else
                {
                    dci += arr[fir[0], sec[1]];
                    dci += arr[sec[0], fir[1]];
                }
            }
            if (isHaveJ(s))
            {
                char[] temp = dci.ToCharArray();
                int count = 0;
                foreach (char c in temp)
                {
                    if (temp[count] == 'i')
                    {
                        temp[count] = 'j';
                        dci += temp[count];
                        count++;
                    }
                } 
            }
            MessageBox.Show(dci);
        }
    }
}
