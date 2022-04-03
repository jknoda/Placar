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
    public partial class frmAcd : Form
    {
        public frmAcd()
        {
            InitializeComponent();
        }

        private void acdCadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.acdCadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoreboardDS);

        }

        private void frmAcd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreboardDS.AcdCad' table. You can move, or remove it, as needed.
            this.acdCadTableAdapter.Fill(this.scoreboardDS.AcdCad);

        }
    }
}
