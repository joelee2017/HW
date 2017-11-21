using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class FrmLogOn : Form
    {
        public FrmLogOn()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmCreate fc = new FrmCreate();
            fc.ShowDialog();
        }

        private void BtenExit_Click(object sender, EventArgs e)
        {
            this.UserNametext.Text = "";
            this.PassWordtext.Text = "";
        }

        private void BtnLogOn_Click(object sender, EventArgs e)
        {
            ClsCreate logon = new ClsCreate();
            logon.checkUsertext();
            

        }
    }
}
