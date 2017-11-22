using HW.Properties;
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

        private void FrmLogOn_Load(object sender, EventArgs e)
        {
            UserNametext.Text = Settings.Default.username;
            PassWordtext.Text = Settings.Default.password;
            //預設帳號密碼
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
            logon.UserNametext = this.UserNametext.Text;
            logon.PassWordtext = this.PassWordtext.Text;
            logon.checkUsertext(UserNametext.Text,PassWordtext.Text);

            if(checkBox1.Checked==true)//記憶密碼
            {
                Settings.Default.username = UserNametext.Text;
                Settings.Default.password = PassWordtext.Text;
                Settings.Default.Save();
            }


        }


    }
}
