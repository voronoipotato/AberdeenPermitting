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
    public partial class BuildingPermitTabs : Form
    {
        


        public BuildingPermitTabs()
        {
            InitializeComponent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            

            building.basementSF = txtBasement.Text;
            building.deckSF = txtDeck.Text;
            building.estimatedCost = txtEstimatedCost.Text;
            building.garageSF = txtGarageSF.Text;
            building.heatedSF = txtHeatedSF.Text;
            building.numStories = txtNumStories.Text;
            building.porchSF = txtPorchSF.Text;
            building.buildingType = cmboConstructionType.Text;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"Building.xml");
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(building.GetType());
            x.Serialize(file, building);
            file.Close();

            tabControl1.SelectedIndex = 2;
           
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnPropertyContact_Click(object sender, EventArgs e)
        {
            Form frmContactInfo = new ContactInfo();
            frmContactInfo.Show();
        }

        private void btnApplicantContact_Click(object sender, EventArgs e)
        {
            Form frmContactInfo = new ContactInfo();
            frmContactInfo.Show();
        }

        private void btnOwnerContact_Click(object sender, EventArgs e)
        {
            Form frmContactInfo = new ContactInfo();
            frmContactInfo.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            Form frmFees = new Fees();
            frmFees.Show();

        }


    }
}
