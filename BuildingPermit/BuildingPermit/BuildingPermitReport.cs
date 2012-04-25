using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BuildingPermit
{
    public partial class BuildingPermitReport : Form
    {

        String permitID, applicantName, propAddress, compName, taxID, firstPhone, secondPhone, lrkNumber, lotNumber, occupType, currUse, zonDistrict, frontSetback, rearSetback, sideSetback, propUse, sqFeet, estCost, typeOfConstruction, heatedSF, porchSF, stories, deckSF, garageSF, basement, numSystems, gasLine, numbBathrooms, totNumbFixt, toilets, showerTubs, clothesWasher;


        public BuildingPermitReport()
        {
            InitializeComponent();
        }

        private void BuildingPermitReport_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);

            permitID = "test";
            applicantName = "TESTER";

            ReportParameter p1 = new ReportParameter("permitID", permitID);
            ReportParameter p2 = new ReportParameter("applicantName", applicantName);
            ReportParameter p3 = new ReportParameter("propAddress", propAddress);
            ReportParameter p4 = new ReportParameter("compName", compName);
            ReportParameter p5 = new ReportParameter("taxID", taxID);
            ReportParameter p6 = new ReportParameter("firstPhone", firstPhone);
            ReportParameter p7 = new ReportParameter("secondPhone", secondPhone);
            ReportParameter p8 = new ReportParameter("lrkNumber", lrkNumber);
            ReportParameter p9 = new ReportParameter("lotNumber", lotNumber);
            ReportParameter p10 = new ReportParameter("occupType", occupType);
            ReportParameter p11 = new ReportParameter("currUse", currUse);
            ReportParameter p12 = new ReportParameter("zonDistrict", zonDistrict);
            ReportParameter p13 = new ReportParameter("frontSetback", frontSetback);
            ReportParameter p14 = new ReportParameter("rearSetback", rearSetback);
            ReportParameter p15 = new ReportParameter("sideSetback", sideSetback);
            ReportParameter p16 = new ReportParameter("propUse", propUse);
            ReportParameter p17 = new ReportParameter("sqFeet", sqFeet);
            ReportParameter p18 = new ReportParameter("estCost", estCost);
            ReportParameter p19 = new ReportParameter("typeOfConstruction", typeOfConstruction);
            ReportParameter p20 = new ReportParameter("heatedSF", heatedSF);
            ReportParameter p21 = new ReportParameter("porchSF", porchSF);
            ReportParameter p22 = new ReportParameter("stories", stories);
            ReportParameter p23 = new ReportParameter("deckSF", deckSF);
            ReportParameter p24 = new ReportParameter("garageSF", garageSF);
            ReportParameter p25 = new ReportParameter("basement", basement);
            ReportParameter p26 = new ReportParameter("numSystems", numSystems);
            ReportParameter p27 = new ReportParameter("gasLine", gasLine);
            ReportParameter p28 = new ReportParameter("numBathrooms", numbBathrooms);
            ReportParameter p29 = new ReportParameter("totNumbFixt", totNumbFixt);
            ReportParameter p30 = new ReportParameter("toilets", toilets);
            ReportParameter p31 = new ReportParameter("showerTubs", showerTubs);
            ReportParameter p32 = new ReportParameter("clothesWasher", clothesWasher);

            this.reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.LocalReport.SetParameters(p2);
            this.reportViewer1.LocalReport.SetParameters(p3);
            this.reportViewer1.LocalReport.SetParameters(p4);
            this.reportViewer1.LocalReport.SetParameters(p5);
            this.reportViewer1.LocalReport.SetParameters(p6);
            this.reportViewer1.LocalReport.SetParameters(p7); 
            this.reportViewer1.LocalReport.SetParameters(p8);
            this.reportViewer1.LocalReport.SetParameters(p9);
            this.reportViewer1.LocalReport.SetParameters(p10);
            this.reportViewer1.LocalReport.SetParameters(p11);
            this.reportViewer1.LocalReport.SetParameters(p12);
            this.reportViewer1.LocalReport.SetParameters(p13);
            this.reportViewer1.LocalReport.SetParameters(p14);
            this.reportViewer1.LocalReport.SetParameters(p15);
            this.reportViewer1.LocalReport.SetParameters(p16);
            this.reportViewer1.LocalReport.SetParameters(p17);
            this.reportViewer1.LocalReport.SetParameters(p18);
            this.reportViewer1.LocalReport.SetParameters(p19);
            this.reportViewer1.LocalReport.SetParameters(p20);
            this.reportViewer1.LocalReport.SetParameters(p21);
            this.reportViewer1.LocalReport.SetParameters(p22);
            this.reportViewer1.LocalReport.SetParameters(p23);
            this.reportViewer1.LocalReport.SetParameters(p24);
            this.reportViewer1.LocalReport.SetParameters(p25);
            this.reportViewer1.LocalReport.SetParameters(p26);
            this.reportViewer1.LocalReport.SetParameters(p27);
            this.reportViewer1.LocalReport.SetParameters(p28);
            this.reportViewer1.LocalReport.SetParameters(p29);
            this.reportViewer1.LocalReport.SetParameters(p30);
            this.reportViewer1.LocalReport.SetParameters(p31);
            this.reportViewer1.LocalReport.SetParameters(p32);
            
           
            this.reportViewer1.RefreshReport();
        }
    }
}
