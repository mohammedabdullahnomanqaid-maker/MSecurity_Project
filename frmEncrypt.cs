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
    public partial class frmEncrypt : Form
    {
        public frmEncrypt()
        {
            InitializeComponent();
        }

        string Encrypted()
        {
            string Line = tbText.Text;
            string newWord = "";
            byte Key =Convert.ToByte(nudKey.Value);

            for(int i=0;i<Line.Length;i++)
            {
                newWord +=Convert.ToChar(Convert.ToByte(Line[i])+Key);
            }
            return newWord;
        }

        string Decrypted()
        {
            string Line = tbText.Text;
            string newWord = "";
            byte Key = Convert.ToByte(nudKey.Value);

            for (int i = 0; i < Line.Length; i++)
            {
                newWord += Convert.ToChar(Convert.ToByte(Line[i]) - Key);
            }
            return newWord;
        }

        private void frmEncrypt_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbShow.Text = Encrypted();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbShow.Text = Decrypted();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            tbShow.Clear();
            nudKey.Value = 0;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DimGray;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Gray;

        }

        private void btnEncrypt_MouseEnter(object sender, EventArgs e)
        {
            btnEncrypt.BackgroundImage = Properties.Resources.CloseLock;
        }

        private void btnEncrypt_MouseLeave(object sender, EventArgs e)
        {
            btnEncrypt.BackgroundImage = null;

        }

        private void btnDecrypt_MouseEnter(object sender, EventArgs e)
        {
            btnDecrypt.BackgroundImage = Properties.Resources.OpenLock;

        }

        private void btnDecrypt_MouseLeave(object sender, EventArgs e)
        {
            btnDecrypt.BackgroundImage = null;

        }
    }
}
