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

            cls.setUserNametext();
        }
    }
}
