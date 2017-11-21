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
    public partial class FrmClsMain : Form
    {
        public FrmClsMain()
        {
            InitializeComponent();
            this.Load += FrmClsMain_Load1;
        }

        private void FrmClsMain_Load1(object sender, EventArgs e)
        {
            FrmLogOn flogon = new FrmLogOn();
            if (flogon.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
