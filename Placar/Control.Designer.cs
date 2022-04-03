namespace WindowsFormsApplication1
{
    partial class frmControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJikanSet = new System.Windows.Forms.Button();
            this.lblJikan = new System.Windows.Forms.Label();
            this.btnJikanReset = new System.Windows.Forms.Button();
            this.btnJikanStop = new System.Windows.Forms.Button();
            this.btnJikanStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtJikan = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnOsaePto = new System.Windows.Forms.Panel();
            this.pnPto = new System.Windows.Forms.Panel();
            this.btnWOsae = new System.Windows.Forms.Button();
            this.btnBOsae = new System.Windows.Forms.Button();
            this.lblOsaePto = new System.Windows.Forms.Label();
            this.btnOsaeReset = new System.Windows.Forms.Button();
            this.btnOsaeStop = new System.Windows.Forms.Button();
            this.btnOsaeStart = new System.Windows.Forms.Button();
            this.lblOsae = new System.Windows.Forms.Label();
            this.grb01 = new System.Windows.Forms.GroupBox();
            this.btnColor01 = new System.Windows.Forms.Button();
            this.txtWName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnWSM = new System.Windows.Forms.Button();
            this.btnWSP = new System.Windows.Forms.Button();
            this.txtWShido = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnWWM = new System.Windows.Forms.Button();
            this.btnWWP = new System.Windows.Forms.Button();
            this.txtWWazari = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWIM = new System.Windows.Forms.Button();
            this.btnWIP = new System.Windows.Forms.Button();
            this.txtWIppon = new System.Windows.Forms.TextBox();
            this.timerJikan = new System.Windows.Forms.Timer(this.components);
            this.timerOsae = new System.Windows.Forms.Timer(this.components);
            this.grb02 = new System.Windows.Forms.GroupBox();
            this.btnColor02 = new System.Windows.Forms.Button();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnBSM = new System.Windows.Forms.Button();
            this.btnBSP = new System.Windows.Forms.Button();
            this.txtBShido = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBWP = new System.Windows.Forms.Button();
            this.txtBWazari = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnBIM = new System.Windows.Forms.Button();
            this.btnBIP = new System.Windows.Forms.Button();
            this.txtBIppon = new System.Windows.Forms.TextBox();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnOsaePto.SuspendLayout();
            this.pnPto.SuspendLayout();
            this.grb01.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grb02.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJikanSet);
            this.groupBox1.Controls.Add(this.lblJikan);
            this.groupBox1.Controls.Add(this.btnJikanReset);
            this.groupBox1.Controls.Add(this.btnJikanStop);
            this.groupBox1.Controls.Add(this.btnJikanStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxtJikan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(323, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jikan";
            // 
            // btnJikanSet
            // 
            this.btnJikanSet.Location = new System.Drawing.Point(160, 27);
            this.btnJikanSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJikanSet.Name = "btnJikanSet";
            this.btnJikanSet.Size = new System.Drawing.Size(64, 28);
            this.btnJikanSet.TabIndex = 1;
            this.btnJikanSet.Text = "Set";
            this.btnJikanSet.UseVisualStyleBackColor = true;
            this.btnJikanSet.Click += new System.EventHandler(this.btnJikanSet_Click);
            // 
            // lblJikan
            // 
            this.lblJikan.AutoSize = true;
            this.lblJikan.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJikan.Location = new System.Drawing.Point(104, 62);
            this.lblJikan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJikan.Name = "lblJikan";
            this.lblJikan.Size = new System.Drawing.Size(108, 42);
            this.lblJikan.TabIndex = 6;
            this.lblJikan.Text = "00:00";
            this.lblJikan.TextChanged += new System.EventHandler(this.lblJikan_TextChanged);
            // 
            // btnJikanReset
            // 
            this.btnJikanReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJikanReset.Location = new System.Drawing.Point(251, 106);
            this.btnJikanReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJikanReset.Name = "btnJikanReset";
            this.btnJikanReset.Size = new System.Drawing.Size(64, 70);
            this.btnJikanReset.TabIndex = 5;
            this.btnJikanReset.TabStop = false;
            this.btnJikanReset.Text = "Reset";
            this.btnJikanReset.UseVisualStyleBackColor = true;
            this.btnJikanReset.Click += new System.EventHandler(this.btnJikanReset_Click);
            // 
            // btnJikanStop
            // 
            this.btnJikanStop.Location = new System.Drawing.Point(116, 106);
            this.btnJikanStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJikanStop.Name = "btnJikanStop";
            this.btnJikanStop.Size = new System.Drawing.Size(127, 70);
            this.btnJikanStop.TabIndex = 4;
            this.btnJikanStop.TabStop = false;
            this.btnJikanStop.Text = "Matte\r\nSonomama\r\n";
            this.btnJikanStop.UseVisualStyleBackColor = true;
            this.btnJikanStop.Click += new System.EventHandler(this.btnJikanStop_Click);
            // 
            // btnJikanStart
            // 
            this.btnJikanStart.Location = new System.Drawing.Point(8, 106);
            this.btnJikanStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJikanStart.Name = "btnJikanStart";
            this.btnJikanStart.Size = new System.Drawing.Size(100, 70);
            this.btnJikanStart.TabIndex = 3;
            this.btnJikanStart.TabStop = false;
            this.btnJikanStart.Text = "Hajime";
            this.btnJikanStart.UseVisualStyleBackColor = true;
            this.btnJikanStart.Click += new System.EventHandler(this.btnJikanStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(mm:ss)";
            // 
            // mtxtJikan
            // 
            this.mtxtJikan.Location = new System.Drawing.Point(100, 31);
            this.mtxtJikan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtJikan.Mask = "99:99";
            this.mtxtJikan.Name = "mtxtJikan";
            this.mtxtJikan.Size = new System.Drawing.Size(51, 26);
            this.mtxtJikan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnOsaePto);
            this.groupBox2.Controls.Add(this.btnOsaeReset);
            this.groupBox2.Controls.Add(this.btnOsaeStop);
            this.groupBox2.Controls.Add(this.btnOsaeStart);
            this.groupBox2.Controls.Add(this.lblOsae);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(323, 187);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osaekomi";
            // 
            // pnOsaePto
            // 
            this.pnOsaePto.Controls.Add(this.pnPto);
            this.pnOsaePto.Controls.Add(this.lblOsaePto);
            this.pnOsaePto.Location = new System.Drawing.Point(100, 20);
            this.pnOsaePto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnOsaePto.Name = "pnOsaePto";
            this.pnOsaePto.Size = new System.Drawing.Size(215, 74);
            this.pnOsaePto.TabIndex = 6;
            this.pnOsaePto.Visible = false;
            // 
            // pnPto
            // 
            this.pnPto.BackColor = System.Drawing.Color.Red;
            this.pnPto.Controls.Add(this.btnWOsae);
            this.pnPto.Controls.Add(this.btnBOsae);
            this.pnPto.Location = new System.Drawing.Point(96, 1);
            this.pnPto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnPto.Name = "pnPto";
            this.pnPto.Size = new System.Drawing.Size(108, 71);
            this.pnPto.TabIndex = 8;
            // 
            // btnWOsae
            // 
            this.btnWOsae.BackColor = System.Drawing.Color.White;
            this.btnWOsae.Location = new System.Drawing.Point(17, 4);
            this.btnWOsae.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWOsae.Name = "btnWOsae";
            this.btnWOsae.Size = new System.Drawing.Size(83, 27);
            this.btnWOsae.TabIndex = 6;
            this.btnWOsae.TabStop = false;
            this.btnWOsae.Text = "01";
            this.btnWOsae.UseVisualStyleBackColor = false;
            this.btnWOsae.Click += new System.EventHandler(this.btnWOsae_Click);
            // 
            // btnBOsae
            // 
            this.btnBOsae.BackColor = System.Drawing.Color.LightBlue;
            this.btnBOsae.Location = new System.Drawing.Point(17, 39);
            this.btnBOsae.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBOsae.Name = "btnBOsae";
            this.btnBOsae.Size = new System.Drawing.Size(83, 27);
            this.btnBOsae.TabIndex = 7;
            this.btnBOsae.TabStop = false;
            this.btnBOsae.Text = "02";
            this.btnBOsae.UseVisualStyleBackColor = false;
            this.btnBOsae.Click += new System.EventHandler(this.btnWOsae_Click);
            // 
            // lblOsaePto
            // 
            this.lblOsaePto.AutoSize = true;
            this.lblOsaePto.Location = new System.Drawing.Point(8, 30);
            this.lblOsaePto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOsaePto.Name = "lblOsaePto";
            this.lblOsaePto.Size = new System.Drawing.Size(44, 20);
            this.lblOsaePto.TabIndex = 0;
            this.lblOsaePto.Text = "--X--";
            this.lblOsaePto.TextChanged += new System.EventHandler(this.lblOsaePto_TextChanged);
            // 
            // btnOsaeReset
            // 
            this.btnOsaeReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsaeReset.Location = new System.Drawing.Point(251, 108);
            this.btnOsaeReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOsaeReset.Name = "btnOsaeReset";
            this.btnOsaeReset.Size = new System.Drawing.Size(64, 68);
            this.btnOsaeReset.TabIndex = 5;
            this.btnOsaeReset.TabStop = false;
            this.btnOsaeReset.Text = "Reset";
            this.btnOsaeReset.UseVisualStyleBackColor = true;
            this.btnOsaeReset.Click += new System.EventHandler(this.btnOsaeReset_Click);
            // 
            // btnOsaeStop
            // 
            this.btnOsaeStop.Location = new System.Drawing.Point(121, 108);
            this.btnOsaeStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOsaeStop.Name = "btnOsaeStop";
            this.btnOsaeStop.Size = new System.Drawing.Size(79, 68);
            this.btnOsaeStop.TabIndex = 4;
            this.btnOsaeStop.TabStop = false;
            this.btnOsaeStop.Text = "Toketa";
            this.btnOsaeStop.UseVisualStyleBackColor = true;
            this.btnOsaeStop.Click += new System.EventHandler(this.btnOsaeStop_Click);
            // 
            // btnOsaeStart
            // 
            this.btnOsaeStart.Location = new System.Drawing.Point(8, 108);
            this.btnOsaeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOsaeStart.Name = "btnOsaeStart";
            this.btnOsaeStart.Size = new System.Drawing.Size(105, 68);
            this.btnOsaeStart.TabIndex = 3;
            this.btnOsaeStart.TabStop = false;
            this.btnOsaeStart.Text = "Osaekomi\r\nYoshi\r\n";
            this.btnOsaeStart.UseVisualStyleBackColor = true;
            this.btnOsaeStart.Click += new System.EventHandler(this.btnOsaeStart_Click);
            // 
            // lblOsae
            // 
            this.lblOsae.AutoSize = true;
            this.lblOsae.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsae.Location = new System.Drawing.Point(20, 36);
            this.lblOsae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOsae.Name = "lblOsae";
            this.lblOsae.Size = new System.Drawing.Size(58, 42);
            this.lblOsae.TabIndex = 2;
            this.lblOsae.Text = "00";
            this.lblOsae.TextChanged += new System.EventHandler(this.lblOsae_TextChanged);
            // 
            // grb01
            // 
            this.grb01.BackColor = System.Drawing.Color.White;
            this.grb01.Controls.Add(this.btnColor01);
            this.grb01.Controls.Add(this.txtWName);
            this.grb01.Controls.Add(this.label6);
            this.grb01.Controls.Add(this.groupBox7);
            this.grb01.Controls.Add(this.groupBox5);
            this.grb01.Controls.Add(this.groupBox4);
            this.grb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb01.Location = new System.Drawing.Point(360, 15);
            this.grb01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb01.Name = "grb01";
            this.grb01.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb01.Size = new System.Drawing.Size(549, 169);
            this.grb01.TabIndex = 1;
            this.grb01.TabStop = false;
            this.grb01.Text = "01";
            // 
            // btnColor01
            // 
            this.btnColor01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor01.Location = new System.Drawing.Point(460, 25);
            this.btnColor01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor01.Name = "btnColor01";
            this.btnColor01.Size = new System.Drawing.Size(80, 28);
            this.btnColor01.TabIndex = 5;
            this.btnColor01.TabStop = false;
            this.btnColor01.Text = "color";
            this.btnColor01.UseVisualStyleBackColor = true;
            this.btnColor01.Click += new System.EventHandler(this.btnColor01_Click);
            // 
            // txtWName
            // 
            this.txtWName.Location = new System.Drawing.Point(76, 27);
            this.txtWName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWName.Name = "txtWName";
            this.txtWName.Size = new System.Drawing.Size(247, 26);
            this.txtWName.TabIndex = 0;
            this.txtWName.TextChanged += new System.EventHandler(this.txtWName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnWSM);
            this.groupBox7.Controls.Add(this.btnWSP);
            this.groupBox7.Controls.Add(this.txtWShido);
            this.groupBox7.Location = new System.Drawing.Point(416, 71);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(124, 82);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SHIDO";
            // 
            // btnWSM
            // 
            this.btnWSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWSM.Location = new System.Drawing.Point(79, 47);
            this.btnWSM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWSM.Name = "btnWSM";
            this.btnWSM.Size = new System.Drawing.Size(37, 28);
            this.btnWSM.TabIndex = 2;
            this.btnWSM.TabStop = false;
            this.btnWSM.Text = "-";
            this.btnWSM.UseVisualStyleBackColor = true;
            this.btnWSM.Click += new System.EventHandler(this.btnWSP_Click);
            // 
            // btnWSP
            // 
            this.btnWSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWSP.Location = new System.Drawing.Point(7, 47);
            this.btnWSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWSP.Name = "btnWSP";
            this.btnWSP.Size = new System.Drawing.Size(37, 28);
            this.btnWSP.TabIndex = 1;
            this.btnWSP.TabStop = false;
            this.btnWSP.Text = "+";
            this.btnWSP.UseVisualStyleBackColor = true;
            this.btnWSP.Click += new System.EventHandler(this.btnWSP_Click);
            // 
            // txtWShido
            // 
            this.txtWShido.Location = new System.Drawing.Point(21, 18);
            this.txtWShido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWShido.Name = "txtWShido";
            this.txtWShido.ReadOnly = true;
            this.txtWShido.Size = new System.Drawing.Size(79, 26);
            this.txtWShido.TabIndex = 0;
            this.txtWShido.TabStop = false;
            this.txtWShido.Text = "0";
            this.txtWShido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWShido.TextChanged += new System.EventHandler(this.txtWShido_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnWWM);
            this.groupBox5.Controls.Add(this.btnWWP);
            this.groupBox5.Controls.Add(this.txtWWazari);
            this.groupBox5.Location = new System.Drawing.Point(144, 71);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(124, 82);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WAZARI";
            // 
            // btnWWM
            // 
            this.btnWWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWWM.Location = new System.Drawing.Point(79, 47);
            this.btnWWM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWWM.Name = "btnWWM";
            this.btnWWM.Size = new System.Drawing.Size(37, 28);
            this.btnWWM.TabIndex = 2;
            this.btnWWM.TabStop = false;
            this.btnWWM.Text = "-";
            this.btnWWM.UseVisualStyleBackColor = true;
            this.btnWWM.Click += new System.EventHandler(this.btnWWP_Click);
            // 
            // btnWWP
            // 
            this.btnWWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWWP.Location = new System.Drawing.Point(7, 47);
            this.btnWWP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWWP.Name = "btnWWP";
            this.btnWWP.Size = new System.Drawing.Size(37, 28);
            this.btnWWP.TabIndex = 1;
            this.btnWWP.TabStop = false;
            this.btnWWP.Text = "+";
            this.btnWWP.UseVisualStyleBackColor = true;
            this.btnWWP.Click += new System.EventHandler(this.btnWWP_Click);
            // 
            // txtWWazari
            // 
            this.txtWWazari.Location = new System.Drawing.Point(21, 18);
            this.txtWWazari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWWazari.Name = "txtWWazari";
            this.txtWWazari.ReadOnly = true;
            this.txtWWazari.Size = new System.Drawing.Size(79, 26);
            this.txtWWazari.TabIndex = 0;
            this.txtWWazari.TabStop = false;
            this.txtWWazari.Text = "0";
            this.txtWWazari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWWazari.TextChanged += new System.EventHandler(this.txtWWazari_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWIM);
            this.groupBox4.Controls.Add(this.btnWIP);
            this.groupBox4.Controls.Add(this.txtWIppon);
            this.groupBox4.Location = new System.Drawing.Point(8, 71);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(124, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IPPON";
            // 
            // btnWIM
            // 
            this.btnWIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWIM.Location = new System.Drawing.Point(79, 47);
            this.btnWIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWIM.Name = "btnWIM";
            this.btnWIM.Size = new System.Drawing.Size(37, 28);
            this.btnWIM.TabIndex = 2;
            this.btnWIM.TabStop = false;
            this.btnWIM.Text = "-";
            this.btnWIM.UseVisualStyleBackColor = true;
            this.btnWIM.Click += new System.EventHandler(this.btnWIP_Click);
            // 
            // btnWIP
            // 
            this.btnWIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWIP.Location = new System.Drawing.Point(7, 47);
            this.btnWIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWIP.Name = "btnWIP";
            this.btnWIP.Size = new System.Drawing.Size(37, 28);
            this.btnWIP.TabIndex = 1;
            this.btnWIP.TabStop = false;
            this.btnWIP.Text = "+";
            this.btnWIP.UseVisualStyleBackColor = true;
            this.btnWIP.Click += new System.EventHandler(this.btnWIP_Click);
            // 
            // txtWIppon
            // 
            this.txtWIppon.Location = new System.Drawing.Point(21, 18);
            this.txtWIppon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWIppon.Name = "txtWIppon";
            this.txtWIppon.ReadOnly = true;
            this.txtWIppon.Size = new System.Drawing.Size(79, 26);
            this.txtWIppon.TabIndex = 0;
            this.txtWIppon.TabStop = false;
            this.txtWIppon.Text = "0";
            this.txtWIppon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWIppon.TextChanged += new System.EventHandler(this.txtWIppon_TextChanged);
            // 
            // timerJikan
            // 
            this.timerJikan.Interval = 1000;
            this.timerJikan.Tick += new System.EventHandler(this.timerJikan_Tick);
            // 
            // timerOsae
            // 
            this.timerOsae.Interval = 1000;
            this.timerOsae.Tick += new System.EventHandler(this.timerOsae_Tick);
            // 
            // grb02
            // 
            this.grb02.BackColor = System.Drawing.Color.LightBlue;
            this.grb02.Controls.Add(this.btnColor02);
            this.grb02.Controls.Add(this.txtBName);
            this.grb02.Controls.Add(this.label3);
            this.grb02.Controls.Add(this.groupBox9);
            this.grb02.Controls.Add(this.groupBox11);
            this.grb02.Controls.Add(this.groupBox12);
            this.grb02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb02.Location = new System.Drawing.Point(360, 338);
            this.grb02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb02.Name = "grb02";
            this.grb02.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb02.Size = new System.Drawing.Size(549, 169);
            this.grb02.TabIndex = 2;
            this.grb02.TabStop = false;
            this.grb02.Text = "02";
            // 
            // btnColor02
            // 
            this.btnColor02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor02.Location = new System.Drawing.Point(460, 25);
            this.btnColor02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor02.Name = "btnColor02";
            this.btnColor02.Size = new System.Drawing.Size(80, 28);
            this.btnColor02.TabIndex = 6;
            this.btnColor02.TabStop = false;
            this.btnColor02.Text = "color";
            this.btnColor02.UseVisualStyleBackColor = true;
            this.btnColor02.Click += new System.EventHandler(this.btnColor02_Click);
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(76, 27);
            this.txtBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(247, 26);
            this.txtBName.TabIndex = 3;
            this.txtBName.TextChanged += new System.EventHandler(this.txtBName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnBSM);
            this.groupBox9.Controls.Add(this.btnBSP);
            this.groupBox9.Controls.Add(this.txtBShido);
            this.groupBox9.Location = new System.Drawing.Point(416, 71);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(124, 82);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "SHIDO";
            // 
            // btnBSM
            // 
            this.btnBSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSM.Location = new System.Drawing.Point(79, 47);
            this.btnBSM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBSM.Name = "btnBSM";
            this.btnBSM.Size = new System.Drawing.Size(37, 28);
            this.btnBSM.TabIndex = 2;
            this.btnBSM.TabStop = false;
            this.btnBSM.Text = "-";
            this.btnBSM.UseVisualStyleBackColor = true;
            this.btnBSM.Click += new System.EventHandler(this.btnBSP_Click);
            // 
            // btnBSP
            // 
            this.btnBSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSP.Location = new System.Drawing.Point(7, 47);
            this.btnBSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBSP.Name = "btnBSP";
            this.btnBSP.Size = new System.Drawing.Size(37, 28);
            this.btnBSP.TabIndex = 1;
            this.btnBSP.TabStop = false;
            this.btnBSP.Text = "+";
            this.btnBSP.UseVisualStyleBackColor = true;
            this.btnBSP.Click += new System.EventHandler(this.btnBSP_Click);
            // 
            // txtBShido
            // 
            this.txtBShido.Location = new System.Drawing.Point(21, 18);
            this.txtBShido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBShido.Name = "txtBShido";
            this.txtBShido.ReadOnly = true;
            this.txtBShido.Size = new System.Drawing.Size(79, 26);
            this.txtBShido.TabIndex = 0;
            this.txtBShido.TabStop = false;
            this.txtBShido.Text = "0";
            this.txtBShido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBShido.TextChanged += new System.EventHandler(this.txtBShido_TextChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button6);
            this.groupBox11.Controls.Add(this.btnBWP);
            this.groupBox11.Controls.Add(this.txtBWazari);
            this.groupBox11.Location = new System.Drawing.Point(144, 71);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Size = new System.Drawing.Size(124, 82);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "WAZARI";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(79, 47);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 28);
            this.button6.TabIndex = 2;
            this.button6.TabStop = false;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnBWP_Click);
            // 
            // btnBWP
            // 
            this.btnBWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBWP.Location = new System.Drawing.Point(7, 47);
            this.btnBWP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBWP.Name = "btnBWP";
            this.btnBWP.Size = new System.Drawing.Size(37, 28);
            this.btnBWP.TabIndex = 1;
            this.btnBWP.TabStop = false;
            this.btnBWP.Text = "+";
            this.btnBWP.UseVisualStyleBackColor = true;
            this.btnBWP.Click += new System.EventHandler(this.btnBWP_Click);
            // 
            // txtBWazari
            // 
            this.txtBWazari.Location = new System.Drawing.Point(21, 18);
            this.txtBWazari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBWazari.Name = "txtBWazari";
            this.txtBWazari.ReadOnly = true;
            this.txtBWazari.Size = new System.Drawing.Size(79, 26);
            this.txtBWazari.TabIndex = 0;
            this.txtBWazari.TabStop = false;
            this.txtBWazari.Text = "0";
            this.txtBWazari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBWazari.TextChanged += new System.EventHandler(this.txtBWazari_TextChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnBIM);
            this.groupBox12.Controls.Add(this.btnBIP);
            this.groupBox12.Controls.Add(this.txtBIppon);
            this.groupBox12.Location = new System.Drawing.Point(8, 71);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(124, 82);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "IPPON";
            // 
            // btnBIM
            // 
            this.btnBIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBIM.Location = new System.Drawing.Point(79, 47);
            this.btnBIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBIM.Name = "btnBIM";
            this.btnBIM.Size = new System.Drawing.Size(37, 28);
            this.btnBIM.TabIndex = 2;
            this.btnBIM.TabStop = false;
            this.btnBIM.Text = "-";
            this.btnBIM.UseVisualStyleBackColor = true;
            this.btnBIM.Click += new System.EventHandler(this.btnBIP_Click);
            // 
            // btnBIP
            // 
            this.btnBIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBIP.Location = new System.Drawing.Point(7, 47);
            this.btnBIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBIP.Name = "btnBIP";
            this.btnBIP.Size = new System.Drawing.Size(37, 28);
            this.btnBIP.TabIndex = 1;
            this.btnBIP.TabStop = false;
            this.btnBIP.Text = "+";
            this.btnBIP.UseVisualStyleBackColor = true;
            this.btnBIP.Click += new System.EventHandler(this.btnBIP_Click);
            // 
            // txtBIppon
            // 
            this.txtBIppon.Location = new System.Drawing.Point(21, 18);
            this.txtBIppon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBIppon.Name = "txtBIppon";
            this.txtBIppon.ReadOnly = true;
            this.txtBIppon.Size = new System.Drawing.Size(79, 26);
            this.txtBIppon.TabIndex = 0;
            this.txtBIppon.TabStop = false;
            this.txtBIppon.Text = "0";
            this.txtBIppon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBIppon.TextChanged += new System.EventHandler(this.txtBIppon_TextChanged);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(368, 247);
            this.btnResetAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(109, 26);
            this.btnResetAll.TabIndex = 4;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtArea);
            this.groupBox13.Location = new System.Drawing.Point(16, 218);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(132, 73);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Área";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(17, 26);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArea.MaxLength = 2;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(95, 30);
            this.txtArea.TabIndex = 0;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.grb02);
            this.Controls.Add(this.grb01);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmControl_FormClosed);
            this.Load += new System.EventHandler(this.frmStarter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnOsaePto.ResumeLayout(false);
            this.pnOsaePto.PerformLayout();
            this.pnPto.ResumeLayout(false);
            this.grb01.ResumeLayout(false);
            this.grb01.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grb02.ResumeLayout(false);
            this.grb02.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtJikan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJikan;
        private System.Windows.Forms.Button btnJikanReset;
        private System.Windows.Forms.Button btnJikanStop;
        private System.Windows.Forms.Button btnJikanStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOsaeReset;
        private System.Windows.Forms.Button btnOsaeStop;
        private System.Windows.Forms.Button btnOsaeStart;
        private System.Windows.Forms.Label lblOsae;
        private System.Windows.Forms.Label lblOsaePto;
        private System.Windows.Forms.GroupBox grb01;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnWSM;
        private System.Windows.Forms.Button btnWSP;
        private System.Windows.Forms.TextBox txtWShido;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnWWM;
        private System.Windows.Forms.Button btnWWP;
        private System.Windows.Forms.TextBox txtWWazari;
        private System.Windows.Forms.Button btnWIM;
        private System.Windows.Forms.Button btnWIP;
        private System.Windows.Forms.TextBox txtWIppon;
        private System.Windows.Forms.Button btnJikanSet;
        private System.Windows.Forms.TextBox txtWName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerJikan;
        private System.Windows.Forms.Timer timerOsae;
        private System.Windows.Forms.GroupBox grb02;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnBSM;
        private System.Windows.Forms.Button btnBSP;
        private System.Windows.Forms.TextBox txtBShido;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBWP;
        private System.Windows.Forms.TextBox txtBWazari;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnBIM;
        private System.Windows.Forms.Button btnBIP;
        private System.Windows.Forms.TextBox txtBIppon;
        private System.Windows.Forms.Panel pnOsaePto;
        private System.Windows.Forms.Button btnBOsae;
        private System.Windows.Forms.Button btnWOsae;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnColor01;
        private System.Windows.Forms.Button btnColor02;
        private System.Windows.Forms.Panel pnPto;
    }
}