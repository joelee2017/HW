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
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void BtnLogOn_Click(object sender, EventArgs e)
        {
            FrmLogOn fl = new FrmLogOn();
                fl.ShowDialog();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ClsCreate cls = new ClsCreate();

            cls.UserNametext = this.UserNametext.Text;
            cls.PassWordtext = this.PassWordtext.Text;
            cls.Emailtext = this.Emailtext.Text;
            cls.ScuExtext = this.ScuExtext.Text;
            cls.ScuExAAtext = this.ScuExAAtext.Text;
            cls.createMemeber();//需使用呼叫方法
        }
    }
}
