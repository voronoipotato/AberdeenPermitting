﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuildingPermit
{
    public partial class BuildingPermitTabs : Form
    {
        public string conStr;

        public static SqlDataReader queryDatabase(string queryString, string connectionString)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            return cmd.ExecuteReader();
        }

        Building building = new Building();
        Utilities utilities = new Utilities();
        Boolean holdTab = false;

        public BuildingPermitTabs()
        {
            InitializeComponent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;

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


            // TODO: This line of code loads data into the 'aberdeenPermittingDataSet.Number_Amps_Fees_Query' table. You can move, or remove it, as needed.
            // this.number_Amps_Fees_QueryTableAdapter.Fill(this.aberdeenPermittingDataSet.Number_Amps_Fees_Query);
            conStr = @"Data Source=.\sqlexpress;Initial Catalog=AberdeenPermitting;User Id=Capstone;Password=Capstone2012;";

            FillComboBox(conStr);

        }

        private void txtSquareFeet_Leave(object sender, EventArgs e)
        {
            building.totalSF = txtSquareFeet.Text;

            if (building.totalSF == null)
            {
                txtSquareFeet.Focus();
                txtSquareFeet.BackColor = Color.Red;
                holdTab = true;
            }
        }

        private void txtEstimatedCost_Leave(object sender, EventArgs e)
        {
            building.estimatedCost = txtEstimatedCost.Text;

            if (building.estimatedCost == null)
            {
                txtEstimatedCost.Focus();
                txtEstimatedCost.BackColor = Color.Red;
                holdTab = true;
            }
        }

        private void txtNumStories_Leave(object sender, EventArgs e)
        {

            building.numStories = txtNumStories.Text;
            if (building.numStories == null)
            {
                txtNumStories.Focus();
                txtNumStories.BackColor = Color.Red;
                holdTab = true;

            }

        }

        private void txtHeatedSF_Leave(object sender, EventArgs e)
        {
            building.heatedSF = txtHeatedSF.Text;

            if (building.heatedSF == null)
            {
                txtHeatedSF.Focus();
                txtHeatedSF.BackColor = Color.Red;
                holdTab = true;
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
            holdTab = false;
        }

        private void txtEstimatedCost_KeyDown(object sender, KeyEventArgs e)
        {
            txtEstimatedCost.BackColor = Color.White;
            holdTab = false;
        }

        private void txtNumStories_KeyDown(object sender, KeyEventArgs e)
        {
            txtNumStories.BackColor = Color.White;
            holdTab = false;
        }

        private void txtHeatedSF_KeyDown(object sender, KeyEventArgs e)
        {
            txtHeatedSF.BackColor = Color.White;
            holdTab = false;
        }

        private void cmboConstructionType_Leave(object sender, EventArgs e)
        {
            building.buildingType = cmboConstructionType.Text;
        }

        private void txtNumSystems_Leave(object sender, EventArgs e)
        {
            utilities.setNumSys = txtNumSystems.Text;
        }

        private void txtNumBathrooms_Leave(object sender, EventArgs e)
        {
            utilities.numBathrooms = txtNumBathrooms.Text;
        }

        private void txtNumWaterClosets_Leave(object sender, EventArgs e)
        {
            utilities.numWaterClosets = txtNumWaterClosets.Text;
        }

        private void txtNumDishwashers_Leave(object sender, EventArgs e)
        {
            utilities.numDishWasher = txtNumDishwashers.Text;
        }

        private void txtNumWaterHeaters_Leave(object sender, EventArgs e)
        {
            utilities.numWaterHeater = txtNumWaterHeaters.Text;
        }

        private void txtNumFixtures_Leave(object sender, EventArgs e)
        {
            utilities.numFixtures = txtNumFixtures.Text;
        }

        private void txtNumShowers_Leave(object sender, EventArgs e)
        {
            utilities.numShowers = txtNumShowers.Text;
        }

        private void txtNumTubs_Leave(object sender, EventArgs e)
        {
            utilities.numTub = txtNumTubs.Text;
        }

        private void txtNumWetBars_Leave(object sender, EventArgs e)
        {
            utilities.numWetBar = txtNumWetBars.Text;
        }

        private void txtNumSinks_Leave(object sender, EventArgs e)
        {
            utilities.numSinks = txtNumSinks.Text;
        }

        private void txtNumClothesWashers_Leave(object sender, EventArgs e)
        {
            utilities.numClothesWasher = txtNumClothesWashers.Text;
        }

        private void txtNumSpas_Leave(object sender, EventArgs e)
        {
            utilities.numSpa = txtNumSpas.Text;
        }

        private void cmboNumAmps_Leave(object sender, EventArgs e)
        {
            utilities.numAmps = cmboNumAmps.Text;
        }

        private void txtProperty_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillComboBox(string conStr)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                String procedure = "getNumAmps";

                try
                {

                    con.Open();
                    SqlCommand spCmd;

                    spCmd = new SqlCommand(procedure, con);
                    spCmd.CommandType = CommandType.StoredProcedure;


                    SqlDataReader RDR = spCmd.ExecuteReader();

                    foreach (var item in RDR)
                    {
                        cmboNumAmps.Items.Add(item);
                    }

                    cmboNumAmps.Text = "--Choose Number of Amps--";

                    RDR.Close();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnContractorContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnElectricalContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnPlumbingContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnMechanicalContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btngasContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnIrrigationContact_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnSearchApplicant_Click(object sender, EventArgs e)
        {
            Form frmNameLookup = new NameLookup();
            frmNameLookup.Show();
        }

        private void btnAddApplicant_Click(object sender, EventArgs e)
        {
            Form frmContactInfo = new ContactInfo();
            frmContactInfo.Show();
        }

        private void btnSearchProperty_Click(object sender, EventArgs e)
        {
            Form frmPropertyLookup = new frmPropertyLookup();
            frmPropertyLookup.Show();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            Form frmPropertyAdd = new PropertyAdd();
            frmPropertyAdd.Show();
        }

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            Form frmNameLookup = new NameLookup();
            frmNameLookup.Show();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            Form frmContactInfo = new ContactInfo();
            frmContactInfo.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnContractorSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnElecSubSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnPlumSubSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnMecSubSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnGasSubSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnIrriSubSearch_Click(object sender, EventArgs e)
        {
            Form frmContractorLookup = new ContractorLookup();
            frmContractorLookup.Show();
        }

        private void btnContractorAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnElecSubAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnPlumSubAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnMecSubAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnGasSubAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnIrriSubAdd_Click(object sender, EventArgs e)
        {
            Form frmContractorAdd = new ContractorAdd();
            frmContractorAdd.Show();
        }

        private void btnSearchPermitNum_Click(object sender, EventArgs e)
        {
            Building building = new Building();

            building.load(conStr, "PermitID =" + txtPermitNumber.Text);

            txtSquareFeet.Text = building.totalSF;
            txtHeatedSF.Text = building.heatedSF;
            txtEstimatedCost.Text = building.estimatedCost;
            cmboConstructionType.Text = building.buildingType;
            txtPorchSF.Text = building.porchSF;
            txtNumStories.Text = building.numStories;
            txtDeck.Text = building.deckSF;
            txtGarageSF.Text = building.garageSF;
            txtBasement.Text = building.basementSF;



        }




    }
}
