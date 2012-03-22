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


        Building building = new Building();
        Utilities utilities = new Utilities();


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

        private void BuildingPermitTabs_Load(object sender, EventArgs e)
        {
        }

        private void txtSquareFeet_Leave(object sender, EventArgs e)
        {
            building.totalSF = txtSquareFeet.Text;

            if (building.totalSF == null)
            {
                txtSquareFeet.Focus();
                txtSquareFeet.BackColor = Color.Red;
            }
        }

        private void txtEstimatedCost_Leave(object sender, EventArgs e)
        {
            building.estimatedCost = txtEstimatedCost.Text;

            if (building.estimatedCost == null)
            {
                txtEstimatedCost.Focus();
                txtEstimatedCost.BackColor = Color.Red;
            }
        }

        private void txtNumStories_Leave(object sender, EventArgs e)
        {

            building.numStories = txtNumStories.Text;
            if (building.numStories == null)
            {
                txtNumStories.Focus();
                txtNumStories.BackColor = Color.Red;

            }

        }

        private void txtHeatedSF_Leave(object sender, EventArgs e)
        {
            building.heatedSF = txtHeatedSF.Text;

            if (building.heatedSF == null)
            {
                txtHeatedSF.Focus();
                txtHeatedSF.BackColor = Color.Red;
            }

        }

        private void txtPorchSF_Leave(object sender, EventArgs e)
        {
            building.porchSF = txtPorchSF.Text;
        }

        private void txtDeck_Leave(object sender, EventArgs e)
        {
            building.deckSF = txtDeck.Text;
        }

        private void txtGarageSF_Leave(object sender, EventArgs e)
        {
            building.garageSF = txtGarageSF.Text;

        }

        private void txtBasement_Leave(object sender, EventArgs e)
        {
            building.basementSF = txtBasement.Text;

        }

        private void txtSquareFeet_KeyDown(object sender, KeyEventArgs e)
        {
            txtSquareFeet.BackColor = Color.White;
        }

        private void txtEstimatedCost_KeyDown(object sender, KeyEventArgs e)
        {
            txtEstimatedCost.BackColor = Color.White;
        }

        private void txtNumStories_KeyDown(object sender, KeyEventArgs e)
        {
            txtNumStories.BackColor = Color.White;
        }

        private void txtHeatedSF_KeyDown(object sender, KeyEventArgs e)
        {
            txtHeatedSF.BackColor = Color.White;
        }

      

    }
}
