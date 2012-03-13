using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingPermit
{
    class Contact
    {
        //private string companyName, firstName, middleName, lastName 
        //   ,license, phone, cell, email, buildingLicense, streetName
        //   ,type, streetName2, city, state;
        public string companyName
        {
            get;
            set;
        }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string license { get; set; }
        public string phone { get; set; } //scrub alpha characters
        public string cell { get; set; } 
        public string email { get; set; }
        public string buildingLicense { get; set; }
        public int streetNumber { get; set; }
        public string streetName { get; set; }
        public string type { get; set; }
        public string streetName2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        /*
        CompanyName: String         * 
        Fname: String
        Mname: String
        Lname: String
        License: String
        PhoneNum: String
        CellNum: string
        Email: string
        BuildingLicense: string
        StreetNum:string
        Street:string
        Type:string
        Street2:string
        City: string
        State: string
        Zip: int
         */
        public Contact( )
        { 
        }
    }
}
