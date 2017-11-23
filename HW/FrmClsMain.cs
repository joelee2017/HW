using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HW
{
    public partial class FrmClsMain : Form
    {
        public FrmClsMain()
        {
            InitializeComponent();
            this.Load += FrmClsMain_Load1;
            this.Paint += FrmClsMain_Paint;
            this.Resize += FrmClsMain_Resize;
            this.Color1 = Color.ForestGreen;
            this.Color2 = Color.DarkCyan;
            
        }

        private void FrmClsMain_Resize(object sender, EventArgs e)
        {
            //this.Invalidated();
        }

        private Color m_Color1;
        public Color Color1
        {
            get
            {
                return m_Color1;
            }
            set
            {
                this.m_Color1 = value;
                this.Invalidate();

            }
        }

        private Color m_Color2;
        public Color Color2
        {
            get
            {
                return m_Color2;
            }
            set
            {
                this.m_Color2 = value;
                //this.Invalidated();
            }
        }

        private void FrmClsMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);
            LinearGradientBrush brush1 = new LinearGradientBrush(pt1, pt2, this.Color1, this.Color2);
            g.FillRectangle(brush1, this.ClientRectangle);
            
        }


        private void FrmClsMain_Load1(object sender, EventArgs e)
        {
            //FrmLogOn flogon = new FrmLogOn();
            //if (flogon.ShowDialog() != DialogResult.OK)
            //{
            //    this.Close();
            //}
        }
    }
}
