using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingPermit
{
    class Building
    {

       

        public String BuildingType
        {
            get { return BuildingType; }
            set { BuildingType = value; }
        }
       
        public int EstimatedCost
        {
            get { return EstimatedCost; }
            set { EstimatedCost = value; }
        }
        public int totalSquareFeet { get; set; }
    }
}
