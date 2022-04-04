using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmControl : Form
    {
        //frmPlacar formPlacarArb = new frmPlacar();
        frmPlacar formPlacarPub = new frmPlacar();

        int hJikan = 0, mJikan = 4, sJikan = 0;
        int ahJikan = 0, amJikan = 4, asJikan = 0;
        int hOsae = 0, mOsae = 0, sOsae = 0;
        bool GS = false, wAwasete = false, bAwasete = false;

        SoundPlayer sinalSound = new SoundPlayer(@"..\..\Assets\gong.wav");

        public frmControl()
        {
            InitializeComponent();
        }
        private void frmStarter_Load(object sender, EventArgs e)
        {
            formPlacarPub.Show();
            grb01.BackColor = Color.White;
            grb02.BackColor = Color.MediumBlue;
            reset(3);
        }
        private void btnGS_Click(object sender, EventArgs e)
        {
            GS = !GS;
            //formPlacarArb.GS();
            formPlacarPub.GS();
        }
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.Texto(txtArea.Text);
            formPlacarPub.Texto(txtArea.Text);
        }
        private void Sinal()
        {
            timerJikan.Stop();
            timerOsae.Stop();
            sinalSound.Play();
        }
        private void frmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formPlacarArb.Close();
            formPlacarPub.Close();
        }

        #region reset
        private void reset(int nTipo)
        {
            // para preservar o tempo atual, caso precise voltar o cronometro
            mtxtJikan.Text = mJikan.ToString("00") + ":" + sJikan.ToString("00");
            mtxtJikan.Focus();

            // 3=reset placar
            if (nTipo == 3)
            {
                txtWName.Text = "WHITE JUDOGI";
                txtWIppon.Text = "0";
                txtWWazari.Text = "0";
                txtWShido.Text = "0";

                txtBName.Text = "BLUE JUDOGI";
                txtBIppon.Text = "0";
                txtBWazari.Text = "0";
                txtBShido.Text = "0";

                if (GS)
                {
                    GS = !GS;
                    //formPlacarArb.GS();
                    formPlacarPub.GS();
                }
                wAwasete = false;
                bAwasete = false;
            }

            // 1=reset jikan
            if ((nTipo == 1) || (nTipo == 3))
            {
                timerJikan.Stop();
                //formPlacarArb.JikanColor(Color.White);
                formPlacarPub.JikanColor(Color.White);
                if (GS)
                {
                    hJikan = 0;
                    mJikan = 0;
                    sJikan = 0;
                }
                else
                {
                    hJikan = ahJikan;
                    mJikan = amJikan;
                    sJikan = asJikan;
                }
                ShowJikan();
            }
            // 2=reset osaekomi
            if ((nTipo == 2) || (nTipo == 3))
            {
                btnBOsaekomi.Enabled = true;
                btnBToketa.Enabled = true;

                btnWOsaekomi.Enabled = true;
                btnWToketa.Enabled = true;

                //btnOsaeStart.Enabled = true;
                //pnPto.BackColor = Color.White;
                pnOsaePto.Visible = false;
                //btnWOsae.Enabled = false;
                //btnBOsae.Enabled = false;
                //pnPto.BackColor = Color.White;
                timerOsae.Stop();
                lblOsaePto.Text = "----------";
                hOsae = 0;
                mOsae = 0;
                sOsae = 0;
                ShowOsae();
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            reset(3);
        }
        #endregion reset

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
            if (GS)
            {
                sJikan++;
                if (sJikan > 59)
                {
                    sJikan = 00;
                    mJikan++;
                }
                if (mJikan > 59)
                {
                    mJikan = 0;
                    hJikan++;
                }
            }
            else
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
                    Sinal();
                }
            }
            ShowJikan();
        }

        private void btnJikanStart_Click(object sender, EventArgs e)
        {
            timerJikan.Start();
            if (pnOsaePto.Visible)
                timerOsae.Start();
            //formPlacarArb.JikanColor(Color.White);
            formPlacarPub.JikanColor(Color.White);
        }

        private void btnJikanStop_Click(object sender, EventArgs e)
        {
            timerJikan.Stop();
            btnOsaeStop_Click(sender, e);
            //formPlacarArb.JikanColor(Color.Red);
            formPlacarPub.JikanColor(Color.Red);
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
            //formPlacarArb.Jikan(lblJikan.Text);
            formPlacarPub.Jikan(lblJikan.Text);

        }
        #endregion

        #region osae_control
        private void timerOsae_Tick(object sender, EventArgs e)
        {
            bool ippon = false;
            pnOsaePto.Visible = true;
            sOsae++;

            if (sOsae >= 20)
                sOsae = 20;

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
            if (sOsae >= 10 && sOsae <= 19 && lblOsaePto.Text == "----------")
            {
                if (txtWWazari.Text == "1")
                    ippon = true;
                lblOsaePto.Text = "WAZARI";
                if (btnWToketa.Enabled)
                    WhiteWazari(true);
                else
                    BlueWazari(true);
            }
            if (sOsae > 19 && lblOsaePto.Text == "WAZARI")
            {
                ippon = true;
                lblOsaePto.Text = "IPPON";
                if (btnWToketa.Enabled)
                {
                    WhiteWazari(false);
                    WhiteIppon(true);
                }
                else
                {
                    BlueWazari(false);
                    BlueIppon(true);
                }
            }
            if (ippon)
            {
                timerOsae.Stop();
                Sinal();
            }
            ShowOsae();
        }
        private void btnOsaeStart_Click(object sender, EventArgs e)
        {
            pnOsaePto.Visible = true;
            if (sender == btnBOsaekomi)
            {
                btnWOsaekomi.Enabled = false;
                btnWToketa.Enabled = false;
            }
            else
            {
                btnBOsaekomi.Enabled = false;
                btnBToketa.Enabled = false;
            }
            //btnWOsae.Enabled = false;
            //btnBOsae.Enabled = false;
            timerOsae.Start();
            btnJikanStart_Click(sender, e);
        }

        private void btnOsaeStop_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblOsae.Text) > 0)
            {
                timerOsae.Stop();
                //btnWOsae.Enabled = true;
                //btnBOsae.Enabled = true;
                //pnPto.BackColor = Color.Red;
                //btnOsaeStart.Enabled = false;
                btnWOsaekomi.Enabled = false;
                btnBOsaekomi.Enabled = false;
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
            //formPlacarArb.Osae(lblOsae.Text);
            formPlacarPub.Osae(lblOsae.Text);
        }

        //private void btnWOsae_Click(object sender, EventArgs e)
        //{
        //    pnOsaePto.Visible = false;
        //    //if (lblOsaePto.Text == "WAZARI")
        //    //{
        //    //    if (sender.Equals(btnWOsae))
        //    //        btnWWP_Click(btnWWP, e);
        //    //    else
        //    //        btnBWP_Click(btnBWP, e);
        //    //}
        //    //else
        //    //{
        //    //    if (lblOsaePto.Text == "IPPON")
        //    //    {
        //    //        if (sender.Equals(btnWOsae))
        //    //            btnWIP_Click(btnWIP, e);
        //    //        else
        //    //            btnBIP_Click(btnBIP, e);
        //    //    }
        //    //}
        //    reset(2);
        //    //btnOsaeStart.Enabled = true;
        //    btnWOsaekomi.Enabled = true;
        //    btnBOsaekomi.Enabled = true;
        //}
        #endregion

        #region  white_control
        private void txtWName_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.wName(txtWName.Text);
            formPlacarPub.wName(txtWName.Text);
        }

        private void btnWIP_Click(object sender, EventArgs e)
        {
            bool plus = false;
            if (sender.Equals(btnWIP))
                plus = true;
            WhiteIppon(plus);
        }
        private void WhiteIppon(bool plus)
        {
            int nAux;
            if (plus)
                nAux = Convert.ToInt16(txtWIppon.Text) + 1;
            else
            {
                if (wAwasete)
                {
                    wAwasete = false;
                    WhiteWazari(true);
                }
                nAux = Convert.ToInt16(txtWIppon.Text) - 1;
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 1) nAux = 1;
            txtWIppon.Text = nAux.ToString();
            if (nAux >= 1) timerJikan.Stop();
        }
        private void txtWIppon_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.wIppon(txtWIppon.Text);
            formPlacarPub.wIppon(txtWIppon.Text);
        }

        private void btnWWP_Click(object sender, EventArgs e)
        {
            bool plus = false;
            if (sender.Equals(btnWWP))
                plus = true;
            WhiteWazari(plus);
        }
        private void WhiteWazari(bool plus)
        {
            int nAux;
            if (plus)
                nAux = Convert.ToInt16(txtWWazari.Text) + 1;
            else
            {
                nAux = Convert.ToInt16(txtWWazari.Text) - 1;
                if (wAwasete)
                {
                    wAwasete = false;
                    WhiteIppon(false);
                    nAux = 1;
                }
            }
            if (nAux > 2) nAux = 2;
            if (nAux < 0) nAux = 0;
            if (nAux == 2 || wAwasete)
            {
                nAux = 0;
                wAwasete = true;
                WhiteIppon(true);
            }
            txtWWazari.Text = nAux.ToString();
        }
        private void txtWWazari_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.wWazari(txtWWazari.Text);
            formPlacarPub.wWazari(txtWWazari.Text);
        }

        private void btnWSP_Click(object sender, EventArgs e)
        {
            int nAux = Convert.ToInt16(txtWShido.Text);
            if (sender.Equals(btnWSP))
            {
                nAux = Convert.ToInt16(txtWShido.Text) + 1;

            }
            else
            {
                if (nAux == 3)
                    BlueIppon(false);
                nAux = Convert.ToInt16(txtWShido.Text) - 1;
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 3) nAux = 3;
            txtWShido.Text = nAux.ToString();
            if (nAux == 3)
                BlueIppon(true);

        }

        private void txtWShido_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.wShido(txtWShido.Text);
            formPlacarPub.wShido(txtWShido.Text);
        }
        private void btnColor01_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                grb01.BackColor = colorDlg.Color;
                //btnWOsae.BackColor = colorDlg.Color;
                //formPlacarArb.placarColor(grb01.BackColor, grb02.BackColor);
                formPlacarPub.placarColor(grb01.BackColor, grb02.BackColor);
            }

        }
        #endregion

        #region blue_control
        private void txtBName_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.bName(txtBName.Text);
            formPlacarPub.bName(txtBName.Text);
        }

        private void btnBIP_Click(object sender, EventArgs e)
        {
            bool plus = false;
            if (sender.Equals(btnBIP))
                plus = true;
            BlueIppon(plus);
        }

        private void BlueIppon(bool plus)
        {
            int nAux;
            if (plus)
                nAux = Convert.ToInt16(txtBIppon.Text) + 1;
            else
            {
                if (bAwasete)
                {
                    bAwasete = false;
                    BlueWazari(true);
                }
                nAux = Convert.ToInt16(txtBIppon.Text) - 1;
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 1) nAux = 1;
            txtBIppon.Text = nAux.ToString();
            if (nAux >= 1) timerJikan.Stop();
        }

        private void txtBIppon_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.bIppon(txtBIppon.Text);
            formPlacarPub.bIppon(txtBIppon.Text);
        }
        private void btnBWP_Click(object sender, EventArgs e)
        {
            bool plus = false;
            if (sender.Equals(btnBWP))
                plus = true;
            BlueWazari(plus);
        }

        private void BlueWazari(bool plus)
        {
            int nAux;
            if (plus)
                nAux = Convert.ToInt16(txtBWazari.Text) + 1;
            else
            {
                nAux = Convert.ToInt16(txtBWazari.Text) - 1;
                if (bAwasete)
                {
                    bAwasete = false;
                    BlueIppon(false);
                    nAux = 1;
                }
            }
            if (nAux > 2) nAux = 2;
            if (nAux < 0) nAux = 0;
            if (nAux == 2 || bAwasete)
            {
                nAux = 0;
                bAwasete = true;
                BlueIppon(true);
            }
            txtBWazari.Text = nAux.ToString();
        }

        private void txtBWazari_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.bWazari(txtBWazari.Text);
            formPlacarPub.bWazari(txtBWazari.Text);
        }
        private void btnBSP_Click(object sender, EventArgs e)
        {
            int nAux = Convert.ToInt16(txtWShido.Text);
            if (sender.Equals(btnBSP))
            {
                nAux = Convert.ToInt16(txtBShido.Text) + 1;
            }
            else
            {
                if (nAux == 3)
                    WhiteIppon(false);
                nAux = Convert.ToInt16(txtBShido.Text) - 1;
            }
            if (nAux < 0) nAux = 0;
            if (nAux > 3) nAux = 3;
            txtBShido.Text = nAux.ToString();
            if (nAux == 3)
                WhiteIppon(true);
        }
        private void txtBShido_TextChanged(object sender, EventArgs e)
        {
            //formPlacarArb.bShido(txtBShido.Text);
            formPlacarPub.bShido(txtBShido.Text);
        }

        private void btnColor02_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                grb02.BackColor = colorDlg.Color;
                //btnBOsae.BackColor = colorDlg.Color;
                //formPlacarArb.placarColor(grb01.BackColor, grb02.BackColor);
                formPlacarPub.placarColor(grb01.BackColor, grb02.BackColor);

            }

        }
        #endregion
    }
}
