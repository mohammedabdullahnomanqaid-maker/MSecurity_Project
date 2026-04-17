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
    public partial class FrmMSecurity : Form
    {
        public FrmMSecurity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmEncrypt();
            frm.ShowDialog();
        }

        private void btnPasswordGenrator_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void btnPasswordGenrator_MouseEnter(object sender, EventArgs e)
        {
            btnPasswordGenrator.BackColor = Color.DimGray;
        }

        private void btnPasswordGenrator_MouseLeave(object sender, EventArgs e)
        {
            btnPasswordGenrator.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;

        }
    }
}
