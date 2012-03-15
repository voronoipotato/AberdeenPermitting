using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingPermit
{
    class Contact
    {
        private string myCompanyName, myFirstName, myMiddleName, myLastName 
           ,myLicense, myPhone, myCell, myEmail, myBuildingLicense,myStreetNumber, myStreetName
           , myType, myStreetName2, myCity, myState, myZip; 
   
        public string companyName {
            get { return myCompanyName; }
            set { myCompanyName = value; }
        }
        public string firstName
        {
            get { return myFirstName;}
            set { myFirstName = value;}
        }
        public string middleName
        {
            get { return myMiddleName; }
            set{ myMiddleName = value; }
        }
         public string lastName
        {
            get { return myLastName; }
            set { myLastName = value;  }
        }
         public string liscence {
             get { return myLicense; }
             set { myLicense = value; } 
         }
         public string phone
         {
             get { return myPhone; }
             set { myPhone = value; } 
         }
         public string cell
         {
             get { return myCell; }
             set { myCell = value; } 
         }
         public string email
         {
             get { return myEmail; }
             set { myEmail = value; } 
         }
         public string buildingLiscence
         {
             get { return myBuildingLicense;  }
             set { myBuildingLicense = value; } 
         }
         public string streetNumber {
             get { return myStreetNumber; }
             set { myStreetNumber = value; }
         }
         public string streetName {
             get { return myStreetName; }
             set { myStreetName = value; } 
         }
         public string streetName2
         {
             get { return myStreetName2; }
             set { myStreetName2 = value; }
         }
         public string city {
             get { return myCity; }
             set { myCity = value; } 
         }
         public string state
         {
             get { return myState; }
             set { myState = value; } 
         }
    }
}
