using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


public class Contact
{
    private string myCompanyName, myCompanyName2, myFirstName, myMiddleName, myLastName
       , myLicense, myPhone, myPhone2, myEmail, myBuildingLicense, myStreetNumber, myStreetName
       , myType, myStreetName2, myCity, myState, myZip;

    private Boolean myPropOwner;
    private DateTime myLicenseExpDate;
    private string query;

    public DateTime licenseExpDate
    {
        get { return myLicenseExpDate; }
        set { myLicenseExpDate = value; }
    }

    public Boolean property
    {
        get { return myPropOwner; }
        set { myPropOwner = value; }
    }

    public string companyName
    {
        get { return myCompanyName; }
        set { myCompanyName = value; }
    }

    public string companyName2
    {
        get { return myCompanyName2; }
        set { myCompanyName2 = value; }
    }
    public string firstName
    {
        get { return myFirstName; }
        set { myFirstName = value; }
    }
    public string middleName
    {
        get { return myMiddleName; }
        set { myMiddleName = value; }
    }
    public string lastName
    {
        get { return myLastName; }
        set { myLastName = value; }
    }
    public string liscense
    {
        get { return myLicense; }
        set { myLicense = value; }
    }
    public string phone
    {
        get { return myPhone; }
        set { myPhone = value; }
    }
    public string phone2
    {
        get { return myPhone2; }
        set { myPhone2 = value; }
    }
    public string email
    {
        get { return myEmail; }
        set { myEmail = value; }
    }
    public string buildingLicense
    {
        get { return myBuildingLicense; }
        set { myBuildingLicense = value; }
    }
    public string streetNumber
    {
        get { return myStreetNumber; }
        set { myStreetNumber = value; }
    }
    public string streetName
    {
        get { return myStreetName; }
        set { myStreetName = value; }
    }
    public string streetName2
    {
        get { return myStreetName2; }
        set { myStreetName2 = value; }
    }
    public string city
    {
        get { return myCity; }
        set { myCity = value; }
    }
    public string state
    {
        get { return myState; }
        set { myState = value; }
    }
    public string type
    {
        get { return myType; }
        set { myType = value; }
    }
    public string zip
    {
        get { return myZip; }
        set { myZip = value; }
    }
    public Contact()
    {
    }

    public void save(string conStr)
    {
        string query;
        /* myCompanyName, 
         * myCompanyName2,
          myFirstName,
         * myLastName
         //, myLicense,
         * myPhone,
         * myCell, 
         * myEmail, 
         * myBuildingLicense,
         * myStreetNumber,
         * myStreetName
         //, myType,
         * myStreetName2, 
         * myCity, 
         * myState, 
         * myZip;
          */
        using (SqlConnection connection = new SqlConnection(conStr))
        {
            SqlDataReader sqlReader;

            if (this.myType == "contact")
            {
                query = String.Format("Insert Into Contact " +
              " (CompName, CompName2, Fname, Lname, " +
              " FirstPhone, SecondPhone, Email, Address, City, State, Zip, propowner )" +
              " Values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11} ); ",
              this.myCompanyName, this.myCompanyName2, this.myFirstName, this.myLastName,
              this.myPhone, this.myPhone2, this.myEmail,
              this.myStreetName, this.myCity, this.myState, this.myZip, this.myPropOwner);

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                sqlReader = command.ExecuteReader();
            }
            if (this.myType == "General Contractor" || this.myType == "HVAC" ||
                this.myType == "Plumbing" || this.myType == "Electrical")
            {
                query = String.Format("Insert Into Contractors " +
                   " (CompName, CompName2, Fname, Lname, " +
                   " PhoneNumber, SecondPhone, Email, Address, City, State, Zip, type. licenseExoDate )" +
                   " Values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12} ); ",
                   this.myCompanyName, this.myCompanyName2, this.myFirstName, this.myLastName,
                   this.myPhone, this.myPhone2, this.myEmail,
                   this.myStreetName, this.myCity, this.myState, this.myZip, this.type, this.licenseExpDate);

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                sqlReader = command.ExecuteReader();
            }

           
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
        }

       
           

    }
}

