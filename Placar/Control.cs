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
    public partial class frmControl : Form
    {
        frmPlacar formPlacarArb = new frmPlacar();
        frmPlacar formPlacarPub = new frmPlacar();
 
        int hJikan = 0, mJikan = 5, sJikan = 0;
        int ahJikan = 0, amJikan = 5, asJikan = 0;
        int hOsae = 0, mOsae = 0, sOsae = 0;
        
        public frmControl()
        {
            InitializeComponent();
        }

        private void frmStarter_Load(object sender, EventArgs e)
        {
            formPlacarPub.Show();
            reset(3);
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.area(txtArea.Text);
            formPlacarPub.area(txtArea.Text);
        }

        private void reset(int nTipo)
        {
            // 1=reset jikan
            if ((nTipo == 1) || (nTipo == 3))
            {
                timerJikan.Stop();
                hJikan = ahJikan;
                mJikan = amJikan;
                sJikan = asJikan;
                ShowJikan();
            }
            // 2=reset osaekomi
            if ((nTipo == 2) || (nTipo == 3))
            {
                btnOsaeStart.Enabled = true;
                pnPto.BackColor = Color.White;
                pnOsaePto.Visible = false;
                btnWOsae.Enabled = false;
                btnBOsae.Enabled = false;
                pnPto.BackColor = Color.White;
                timerOsae.Stop();
                lblOsaePto.Text = "NONE";
                hOsae = 0;
                mOsae = 0;
                sOsae = 0;
                ShowOsae();
            }
            // 3=reset placar
            if (nTipo == 3)
            {
                mtxtJikan.Text = mJikan.ToString("00") + ":" + sJikan.ToString("00");
                mtxtJikan.Focus();
                txtWName.Text = "WHITE JUDOGI";
                txtWIppon.Text = "0";
                txtWWazari.Text = "0";
                txtWYuko.Text = "0";
                txtWShido.Text = "0";

                txtBName.Text = "BLUE JUDOGI";
                txtBIppon.Text = "0";
                txtBWazari.Text = "0";
                txtBYuko.Text = "0";
                txtBShido.Text = "0";
            }

        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            reset(3);
        }
        
        #region jikan_control

        private void btnJikanSet_Click(object sender, EventArgs e)
        {
            string cAux = mtxtJikan.Text.ToString();

            hJikan = 0;
            mJikan = Convert.ToInt16(cAux.Substring(0, 2));
            sJikan = Convert.ToInt16(cAux.Substring(3, 2));
            ahJikan = hJikan;
            amJikan = mJikan;
            asJikan = sJikan; 
            ShowJikan();
        }
              
        private void timerJikan_Tick(object sender, EventArgs e)
        {
            sJikan--;
            if (sJikan < 0)
            {
                sJikan = 59;
                mJikan--; 
            }
            if (mJikan < 0)
            {
                mJikan = 59;
                hJikan--;
            }
            if (((sJikan == 0) && (mJikan == 0) && (hJikan == 0)) || (mJikan == 59))
            {
                if (mJikan == 59)
                {
                    sJikan = 0;
                    mJikan = 0;
                    sJikan = 0;
                }
                timerJikan.Stop();
            }
            ShowJikan();
        }

        private void btnJikanStart_Click(object sender, EventArgs e)
        {
            timerJikan.Start();
        }

        private void btnJikanStop_Click(object sender, EventArgs e)
        {
            timerJikan.Stop();
            btnOsaeStop_Click(sender, e);
        }
        private void btnJikanReset_Click(object sender, EventArgs e)
        {
            reset(1);
        }
        private void ShowJikan()
        {
            lblJikan.Text = mJikan.ToString("00") + ":" + sJikan.ToString("00");
        }

        private void lblJikan_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.Jikan(lblJikan.Text);
            formPlacarPub.Jikan(lblJikan.Text);

        }
        #endregion

        #region osae_control
        private void timerOsae_Tick(object sender, EventArgs e)
        {
            pnOsaePto.Visible = true;
            lblOsaePto.Text = "-----";
            sOsae++;

            if (sOsae >= 25)
                sOsae = 25;

            if (sOsae == 60)
            {
                sOsae = 0;//repor os segundos a 0
                mOsae++; //adicionar +1 aos minutos
            }
            if (mOsae == 60)
            {
                mOsae = 0;
                hOsae++;
            }
            if ((sOsae >= 15) && (sOsae < 20))
            {
                lblOsaePto.Text = "YUKO";
            }
            if ((sOsae >= 20) && (sOsae < 25))
            {
                lblOsaePto.Text = "WAZARI";
            }
            if (sOsae >= 25)
            {
                lblOsaePto.Text = "IPPON";
                timerOsae.Stop();
            }
            ShowOsae();
        }
        private void btnOsaeStart_Click(object sender, EventArgs e)
        {
            pnOsaePto.Visible = true;
            btnWOsae.Enabled = false;
            btnBOsae.Enabled = false;
            timerOsae.Start();
            btnJikanStart_Click(sender, e);            
        }

        private void btnOsaeStop_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblOsae.Text) > 0)
            {
                timerOsae.Stop();
                btnWOsae.Enabled = true;
                btnBOsae.Enabled = true;
                pnPto.BackColor = Color.Red;
                btnOsaeStart.Enabled = false;
            }
        }
        
        private void btnOsaeReset_Click(object sender, EventArgs e)
        {
            reset(2);
        }

        private void ShowOsae()
        {
            lblOsae.Text = sOsae.ToString("00");
        }

        private void lblOsae_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.Osae(lblOsae.Text);
            formPlacarPub.Osae(lblOsae.Text);
        }


        private void lblOsaePto_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.OsaePto(lblOsaePto.Text);
            formPlacarPub.OsaePto(lblOsaePto.Text);
        }

        private void btnWOsae_Click(object sender, EventArgs e)
        {
            pnOsaePto.Visible = false;
            if (lblOsaePto.Text == "YUKO")
            {
                if (sender.Equals(btnWOsae))
                    btnWYP_Click(btnWYP, e);
                else
                    btnBYP_Click(btnBYP, e);
            }
            else
            {
                if (lblOsaePto.Text == "WAZARI")
                {
                    if (sender.Equals(btnWOsae))
                        btnWWP_Click(btnWWP, e);
                    else
                        btnBWP_Click(btnBWP, e);
                }
                else
                {
                    if (lblOsaePto.Text == "IPPON")
                    {
                        if (sender.Equals(btnWOsae))
                            btnWIP_Click(btnWIP, e);
                        else
                            btnBIP_Click(btnBIP, e);
                    }
                }
            }
            reset(2);
            btnOsaeStart.Enabled = true;
        }
        #endregion

        #region  white_control
        private void txtWName_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.wName(txtWName.Text);
            formPlacarPub.wName(txtWName.Text);
        }

        private void btnWIP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnWIP))
                nAux = Convert.ToInt16(txtWIppon.Text) + 1;
            else
                nAux = Convert.ToInt16(txtWIppon.Text) - 1;
            if (nAux < 0) nAux = 0;
            if (nAux > 1) nAux = 1;
            txtWIppon.Text = nAux.ToString();
        }

        private void txtWIppon_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.wIppon(txtWIppon.Text);
            formPlacarPub.wIppon(txtWIppon.Text);
        }

        private void btnWWP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnWWP))
                nAux = Convert.ToInt16(txtWWazari.Text) + 1;
            else
                nAux = Convert.ToInt16(txtWWazari.Text) - 1;
            if (nAux > 2) nAux = 2;
            if (nAux < 0) nAux = 0;
            txtWWazari.Text = nAux.ToString();
        }

        private void txtWWazari_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.wWazari(txtWWazari.Text);
            formPlacarPub.wWazari(txtWWazari.Text);
        }

        private void btnWYP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnWYP))
                nAux = Convert.ToInt16(txtWYuko.Text) + 1;
            else
                nAux = Convert.ToInt16(txtWYuko.Text) - 1;
            if (nAux < 0) nAux = 0;
            txtWYuko.Text = nAux.ToString();
        }

        private void txtWYuko_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.wYuko(txtWYuko.Text);
            formPlacarPub.wYuko(txtWYuko.Text);
        }

        private void btnWSP_Click(object sender, EventArgs e)
        {
            int nAux, nAux2;
            if (sender.Equals(btnWSP))
            {
                nAux = Convert.ToInt16(txtWShido.Text) + 1;
                switch(nAux)
                {
                    case 2:
                    {
                        nAux2 = Convert.ToInt16(txtBYuko.Text) + 1;
                        txtBYuko.Text = nAux2.ToString();
                        break;
                    }
                    case 3:
                    {
                        nAux2 = Convert.ToInt16(txtBYuko.Text) - 1;
                        txtBYuko.Text = nAux2.ToString();

                        nAux2 = Convert.ToInt16(txtBWazari.Text) + 1;
                        txtBWazari.Text = nAux2.ToString();
                        break;

                    }
                    case 4:
                    {
                        nAux2 = Convert.ToInt16(txtBWazari.Text) - 1;
                        txtBWazari.Text = nAux2.ToString();

                        nAux2 = Convert.ToInt16(txtBIppon.Text) + 1;
                        txtBIppon.Text = nAux2.ToString();
                        break;
                    }
                }

            }
            else
            {
                nAux = Convert.ToInt16(txtWShido.Text) - 1;
                switch(nAux)
                {
                    case 3:
                    {
                        nAux2 = Convert.ToInt16(txtBIppon.Text) - 1;
                        txtBIppon.Text = nAux2.ToString();

                        nAux2 = Convert.ToInt16(txtBWazari.Text) + 1;
                        txtBWazari.Text = nAux2.ToString();
                        break;
                    }
                    case 2:
                    {
                        nAux2 = Convert.ToInt16(txtBWazari.Text) - 1;
                        txtBWazari.Text = nAux2.ToString();

                        nAux2 = Convert.ToInt16(txtBYuko.Text) + 1;
                        txtBYuko.Text = nAux2.ToString();
                        break;
                    }
                    case 1:
                    {
                        nAux2 = Convert.ToInt16(txtBYuko.Text) - 1;
                        txtBYuko.Text = nAux2.ToString();
                        break;
                    }
                }
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 4) nAux = 4;
            txtWShido.Text = nAux.ToString();
        }

        private void txtWShido_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.wShido(txtWShido.Text);
            formPlacarPub.wShido(txtWShido.Text);
        }
        private void btnColor01_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                grb01.BackColor = colorDlg.Color;
                btnWOsae.BackColor = colorDlg.Color;
                formPlacarArb.placarColor(grb01.BackColor, grb02.BackColor);
                formPlacarPub.placarColor(grb01.BackColor, grb02.BackColor);
            }

        }
        #endregion

        #region blue_control
        private void txtBName_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.bName(txtBName.Text);
            formPlacarPub.bName(txtBName.Text);
        }

        private void btnBIP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnBIP))
                nAux = Convert.ToInt16(txtBIppon.Text) + 1;
            else
                nAux = Convert.ToInt16(txtBIppon.Text) - 1;
            if (nAux < 0) nAux = 0;
            if (nAux > 1) nAux = 1;
            txtBIppon.Text = nAux.ToString();
        }
        private void txtBIppon_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.bIppon(txtBIppon.Text);
            formPlacarPub.bIppon(txtBIppon.Text);
        }

        private void btnBWP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnBWP))
                nAux = Convert.ToInt16(txtBWazari.Text) + 1;
            else
                nAux = Convert.ToInt16(txtBWazari.Text) - 1;
            if (nAux < 0) nAux = 0;
            if (nAux > 2) nAux = 2;
            txtBWazari.Text = nAux.ToString();
        }

        private void txtBWazari_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.bWazari(txtBWazari.Text);
            formPlacarPub.bWazari(txtBWazari.Text);
        }

        private void btnBYP_Click(object sender, EventArgs e)
        {
            int nAux;
            if (sender.Equals(btnBYP))
                nAux = Convert.ToInt16(txtBYuko.Text) + 1;
            else
                nAux = Convert.ToInt16(txtBYuko.Text) - 1;
            if (nAux < 0) nAux = 0;
            txtBYuko.Text = nAux.ToString();
        }

        private void txtBYuko_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.bYuko(txtBYuko.Text);
            formPlacarPub.bYuko(txtBYuko.Text);
        }

        private void btnBSP_Click(object sender, EventArgs e)
        {
            int nAux, nAux2;
            if (sender.Equals(btnBSP))
            {
                nAux = Convert.ToInt16(txtBShido.Text) + 1;
                switch (nAux)
                {
                    case 2:
                        {
                            nAux2 = Convert.ToInt16(txtWYuko.Text) + 1;
                            txtWYuko.Text = nAux2.ToString();
                            break;
                        }
                    case 3:
                        {
                            nAux2 = Convert.ToInt16(txtWYuko.Text) - 1;
                            txtWYuko.Text = nAux2.ToString();

                            nAux2 = Convert.ToInt16(txtWWazari.Text) + 1;
                            txtWWazari.Text = nAux2.ToString();
                            break;

                        }
                    case 4:
                        {
                            nAux2 = Convert.ToInt16(txtWWazari.Text) - 1;
                            txtWWazari.Text = nAux2.ToString();

                            nAux2 = Convert.ToInt16(txtWIppon.Text) + 1;
                            txtWIppon.Text = nAux2.ToString();
                            break;
                        }
                }
            }
            else
            {
                nAux = Convert.ToInt16(txtBShido.Text) - 1;
                switch (nAux)
                {
                    case 3:
                        {
                            nAux2 = Convert.ToInt16(txtWIppon.Text) - 1;
                            txtWIppon.Text = nAux2.ToString();

                            nAux2 = Convert.ToInt16(txtWWazari.Text) + 1;
                            txtWWazari.Text = nAux2.ToString();
                            break;
                        }
                    case 2:
                        {
                            nAux2 = Convert.ToInt16(txtWWazari.Text) - 1;
                            txtWWazari.Text = nAux2.ToString();

                            nAux2 = Convert.ToInt16(txtWYuko.Text) + 1;
                            txtWYuko.Text = nAux2.ToString();
                            break;
                        }
                    case 1:
                        {
                            nAux2 = Convert.ToInt16(txtWYuko.Text) - 1;
                            txtWYuko.Text = nAux2.ToString();
                            break;
                        }
                }
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 4) nAux = 4;
            txtBShido.Text = nAux.ToString();
        }

        private void txtBShido_TextChanged(object sender, EventArgs e)
        {
            formPlacarArb.bShido(txtBShido.Text);
            formPlacarPub.bShido(txtBShido.Text);
        }

        private void btnColor02_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                grb02.BackColor = colorDlg.Color;
                btnBOsae.BackColor = colorDlg.Color;
                formPlacarArb.placarColor(grb01.BackColor, grb02.BackColor);
                formPlacarPub.placarColor(grb01.BackColor, grb02.BackColor);

            }

        }
        #endregion

        private void frmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPlacarArb.Close();
            formPlacarPub.Close();
        }
         
    }
}
