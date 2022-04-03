using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPlacar : Form
    {

        public frmPlacar()
        {
            InitializeComponent();
            
        }

        public void placarColor(Color color01, Color color02)
        {
            pnl01.BackColor = color01;
            pnl02.BackColor = color02;
        }

        public void area(string cText)
        {
            lblArea.Text = cText;
        }

        public void wIppon(string cText)
        {
            lblWIppon.Text = cText;
        }
        public void wWazari(string cText)
        {
            lblWWazari.Text = cText;
        }
        public void wYuko(string cText)
        {
            lblWYuko.Text = cText;
            if (Convert.ToInt16(cText) >= 10)
                lblWYuko.Font = new Font(lblWYuko.Font.FontFamily, 80);
            else
                lblWYuko.Font = new Font(lblWYuko.Font.FontFamily, 100);

        }
        public void wShido(string cText)
        {
            int nAux;
            lblWShido.Text = cText;
            nAux = Convert.ToInt16(cText);
            pnWShido1.Visible = false;
            pnWShido2.Visible = false;
            pnWShido3.Visible = false;
            pnWShido4.Visible = false;
            switch (nAux)
            {
                case 1:
                    {
                        pnWShido1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        pnWShido2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pnWShido3.Visible = true;
                        break;
                    }
                case 4:
                    {
                        pnWShido4.Visible = true;
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
        public void bYuko(string cText)
        {
            lblBYuko.Text = cText;
            if (Convert.ToInt16(cText) >= 10)
                lblBYuko.Font = new Font(lblBYuko.Font.FontFamily, 80);
            else
                lblBYuko.Font = new Font(lblBYuko.Font.FontFamily, 100);
        }
        public void bShido(string cText)
        {
            int nAux;
            lblBShido.Text = cText;
            nAux = Convert.ToInt16(cText);
            pnBShido1.Visible = false;
            pnBShido2.Visible = false;
            pnBShido3.Visible = false;
            pnBShido4.Visible = false;
            switch (nAux)
            {
                case 1:
                    {
                        pnBShido1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        pnBShido2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pnBShido3.Visible = true;
                        break;
                    }
                case 4:
                    {
                        pnBShido4.Visible = true;
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

        public void Osae(string cText)
        {
            lblOsae.Text = cText;
        }

        public void OsaePto(string cText)
        {
            if (cText == "NONE")
                lblOsaePto.Visible = false;
            else
                lblOsaePto.Visible = true;
            lblOsaePto.Text = cText;
        }
       
    }
}
