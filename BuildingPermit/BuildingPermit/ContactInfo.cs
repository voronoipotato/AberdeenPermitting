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
            //string xml; 
           Contact contact = new Contact();

            contact.companyName = txtCompany.Text;
            contact.firstName = txtFName.Text;
            contact.middleName = txtMName.Text;
            contact.lastName = txtLName.Text;
            contact.liscense = txtLicense.Text;
            contact.phone = txtPhone.Text;
            contact.phone = txtCell.Text;
            contact.email = txtEmail.Text;
            contact.buildingLicense = txtBuildingLicense.Text;
            contact.streetNumber = txtStreetNumber.Text; 
            contact.streetName = txtStreetName.Text;
            contact.type = txtType.Text;
            contact.streetName2 = txtStreetName2.Text;
            contact.city = txtCity.Text;
            contact.state = txtState.Text;
            contact.zip = txtZip.Text;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"Contact.xml");
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(contact.GetType());
            x.Serialize(file, contact);
            file.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
