using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HW
{
    public partial class FrmForget2 : HW.FrmClsMain
    {
        public FrmForget2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCreate sy = new ClsCreate();
            SYtxt.Text =sy.UserForget(UserNametext.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCreate fp = new ClsCreate();
            label10.Text= fp.UserForgetpassword(passwordtxt.Text);
        }
    }
}
