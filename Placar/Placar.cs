using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPlacar : Form
    {

        public frmPlacar()
        {
            InitializeComponent();
            lblTexto.Text = "";

        }

        public void placarColor(Color color01, Color color02)
        {
            pnWhite.BackColor = color01;
            pnBlue.BackColor = color02;
        }

        //public void area(string cText)
        //{
        //    lblArea.Text = cText;
        //}

        public void wIppon(string cText)
        {
            lblWIppon.Text = cText;
        }
        public void wWazari(string cText)
        {
            lblWWazari.Text = cText;
        }
        public void wShido(string cText)
        {
            int nAux;
            //lblWShido.Text = cText;
            nAux = Convert.ToInt16(cText);
            pnWShido1.Visible = false;
            pnWShido2.Visible = false;
            pnWShido3.Visible = false;
            switch (nAux)
            {
                case 1:
                    {
                        pnWShido1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        pnWShido1.Visible = true;
                        pnWShido2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pnWShido1.Visible = true;
                        pnWShido2.Visible = true;
                        pnWShido3.Visible = true;
                        break;
                    }
            }
        }

        public void bIppon(string cText)
        {
            lblBIppon.Text = cText;
        }
        public void bWazari(string cText)
        {
            lblBWazari.Text = cText;
        }
        public void bShido(string cText)
        {
            int nAux;
            //lblBShido.Text = cText;
            nAux = Convert.ToInt16(cText);
            pnBShido1.Visible = false;
            pnBShido2.Visible = false;
            pnBShido3.Visible = false;
            switch (nAux)
            {
                case 1:
                    {
                        pnBShido1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        pnBShido1.Visible = true;
                        pnBShido2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pnBShido1.Visible = true;
                        pnBShido2.Visible = true;
                        pnBShido3.Visible = true;
                        break;
                    }
            }
        }

        public void wName(string cText)
        {
            lblWName.Text = cText;
        }

        public void bName(string cText)
        {
            lblBName.Text = cText;
        }

        public void Jikan(string cText)
        {
            lblJikan.Text = cText;
        }

        public void JikanColor(Color color)
        {
            lblJikan.BackColor = color;
        }


        public void Osae(string cText)
        {
            lblOsae.Text = cText;
        }

        public void Texto(string cText)
        {
            lblTexto.Visible = true;
            lblTexto.Text = cText;
        }

        public void GS()
        {
            lblGS.Visible = !lblGS.Visible;
        }

        //public void OsaePto(string cText)
        //{
        //    if (cText == "NONE")
        //        lblOsaePto.Visible = false;
        //    else
        //        lblOsaePto.Visible = true;
        //    lblOsaePto.Text = cText;
        //}

        //private void pnl01_Resize(object sender, EventArgs e)
        //{
        //    pnWhite.Location = new Point(                
        //        this.pnl01.Width / 2 - pnWhite.Size.Width / 2,
        //        106);
        //}

        //private void pnl02_Resize(object sender, EventArgs e)
        //{
        //    pnBlue.Location = new Point(
        //        this.pnl02.Width / 2 - pnBlue.Size.Width / 2,
        //        106);
        //}
    }
}
