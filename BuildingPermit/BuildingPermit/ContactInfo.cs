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
            Contact.streetName2 = txtStreetName2.Text;
            Contact.city = txtCity.Text;
            Contact.state = txtState.Text;
            Contact.zip = txtZip.Text;
            Contact.type = txtType.Text; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
