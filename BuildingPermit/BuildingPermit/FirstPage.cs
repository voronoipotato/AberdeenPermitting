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
    public partial class FirstPage : Form
    {
        public string conStr;

        public FirstPage()
        {
            InitializeComponent();
        }

        private void permittingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBuildingPermitTabs = new BuildingPermitTabs();
            frmBuildingPermitTabs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void buildingPermitReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBuildingPermitReport = new BuildingPermitReport();
            frmBuildingPermitReport.Show();
        }
    }
}
