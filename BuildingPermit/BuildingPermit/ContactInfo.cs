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
    
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Contact Contact = new Contact();
            Contact.companyName = txtCompany.Text;
            Contact.firstName = txtFName.Text;
            Contact.middleName = txtMName.Text;
            Contact.lastName = txtLName.Text;
            Contact.liscence = txtLicense.Text;
            Contact.phone = txtPhone.Text;
            Contact.cell = txtCell.Text;
            Contact.email = txtEmail.Text;
            Contact.buildingLiscence = txtBuildingLicense.Text;
            Contact.streetNumber = txtStreetNumber.Text; 
            Contact.streetName = txtStreetName.Text;
            Contact.type = txtType.Text;
            Contact.streetName2 = txtStreetName2.Text;
            Contact.city = txtCity.Text;
            Contact.state = txtState.Text;
            Contact.zip = txtZip.Text;

            txtCompany.Clear();
            txtFName.Clear(); 
            txtMName.Clear();
            txtLName.Clear();
            txtLicense.Clear();
            txtPhone.Clear();
            txtCell.Clear();
            txtEmail.Clear();
            txtBuildingLicense.Clear();
            txtStreetNumber.Clear();
            txtType.Clear();
            txtStreetName.Clear();
            txtStreetName2.Clear();
            txtCity.Clear();
            txtZip.Clear();

            
            txtFName.Text = Contact.firstName + "a";
            txtMName.Text = Contact.middleName + "a";
            txtLName.Text = Contact.lastName + "a";
            txtLicense.Text = Contact.liscence + "a";
            txtPhone.Text = Contact.phone + "a";
            txtCell.Text = Contact.cell + "a";
            txtEmail.Text = Contact.email + "a";
            txtBuildingLicense.Text = Contact.buildingLiscence + "a";
            txtStreetNumber.Text = Contact.streetNumber + "a";
            txtStreetName.Text = Contact.streetName + "a";
            txtType.Text = Contact.type + "a";
            txtStreetName2.Text = Contact.streetName2 + "a";
            txtCity.Text = Contact.city + "a";
            txtState.Text = Contact.state + "a";
            txtZip.Text = Contact.zip + "a";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
