using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HW
{
    public partial class FrmCreate2 : HW.FrmClsMain
    {
        public FrmCreate2()
        {
            InitializeComponent();
        }
                

        private void BtnCreate_Click_1(object sender, EventArgs e)
        {
            ClsCreate cls = new ClsCreate();

            cls.UserNametext = this.UserNametext.Text;
            cls.PassWordtext = this.PassWordtext.Text;
            cls.Emailtext = this.Emailtext.Text;
            cls.ScuExtext = this.ScuExtext.Text;
            cls.ScuExAAtext = this.ScuExAAtext.Text;
            cls.createMemeber();//需使用呼叫方法
        }

        private void BtnLogOn_Click_1(object sender, EventArgs e)
        {
            FrmLogOn2 fl = new FrmLogOn2();
            fl.ShowDialog();
        }
    }
}
