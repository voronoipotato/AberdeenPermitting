using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuildingPermit
{
    public partial class frmPropertyLookup : Form
    {
        public frmPropertyLookup()
        {
            InitializeComponent();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            string strLRK, strPropDesc, strPropOwner;

            strLRK = txtLRK.Text;
            strPropDesc = txtPropertyDescription.Text;
            strPropOwner = txtPropertyOwner.Text;

        }
    }
}
