using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratePasssword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "";
        Random rand = new Random();

        void GenratePassword()
        {

            if(chkCapitalLetters.Checked)
            {
               str+=(char)rand.Next(65, 90);
            }

            if (chkSmallLetters.Checked)
            {
                str += (char)rand.Next(97, 122);

            }

            if (chkSymbols.Checked)
            {
                str += (char)rand.Next(32, 47);

            }

            if (chkNumbrs.Checked)
            {
                str += (char)rand.Next(48, 57);

            }

            if (chkMax.Checked)
            {
                str += (char)rand.Next(32, 122);

            }
        }

        void Genrator()
        {
            int length = trackBar1.Value;
            for(int i=0;i<length;i++)
            {
                GenratePassword();
            }
            textBox1.Text =str;
            str="";
        }

    

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Genrator();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            chkCapitalLetters.Checked = false;
            chkSmallLetters.Checked = false;
            chkNumbrs.Checked = false;
            chkSymbols.Checked = false;
            chkMax.Checked = false;
            trackBar1.Value = 0;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DimGray;

        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Gray;

        }

        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.Green;
        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.FromArgb(128, 255, 128);

        }
    }
}
