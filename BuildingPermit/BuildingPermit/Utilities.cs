/*
 * Programmer:      Deivydas Sunelaitis
 * Date:            3-20-2012
 * Description:     HEATING/AIR-CONDITIONING/MECHANICAL/PLUMBING/ELECTRICAL
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

    
class Utilities
{
    //  HEATING/AIR-CONDITIONING/MECHANICAL
        private Boolean MyGasLine;
        private Boolean MyDuctWork;
        private int MyNumSys;
    //  PLUMBING
        private int MyTotNumBathrooms;
        private int MyNumWaterClosets;
        private int MyNumDishWasher;
        private int MyNumWaterHeater;
        private int MyTotNumFixtures;
        private int MyNumShowers;
        private int MyNumTubs;
        private int MyNumWetBar;
        private int MyNumSinks;
        private int MyNumClothesWasher;
        private int MyNumSpa;
    // ELECTRICAL
        private int MyNumAmps;
        private Boolean MyTempPole;

    //  HEATING/AIR-CONDITIONING/MECHANICAL
        public Boolean GasLine
        {
            set
            {
                if (MyGasLine == true)
                {

                }
                else
                {
                    MessageBox.Show("no gas line.");
                }
            }
        }

        public Boolean DuctWork
        {
            get { return MyDuctWork;  }
            set {MyDuctWork = value; }
        }
        
        public int NumSys
        {
            get { return MyNumSys; }
            set { MyNumSys = value; }
        }

    //  PLUMBING
        public int NumBathrooms
        {
            get { return MyTotNumBathrooms; }
            set { MyTotNumBathrooms = value; }
        }

        public int WaterClosets
        {
            get { return MyNumWaterClosets; }
            set { MyNumWaterClosets = value; } 
        }

        public int DishWasher
        {
            get { return MyNumDishWasher; }
            set { MyNumDishWasher = value; }
        }

        public int WaterHeater
        {
            get { return MyNumWaterHeater; }
            set { MyNumWaterHeater = value; }
        }

        public int NumFixtures
        {
            get { return MyTotNumFixtures; }
            set { MyTotNumFixtures = value; }
        }

        public int Showers
        {
            get { return MyNumShowers; }
            set { MyNumShowers = value; }
        }

        public int Tub
        {
            get { return MyNumTubs; }
            set { MyNumTubs = value; }
        }

        public int WetBar
        {
            get { return MyNumWetBar; }
            set { MyNumWetBar = value; }
        }

        public int Sinks
        {
            get { return MyNumSinks; }
            set { MyNumSinks = value; }
        }

        public int clothesWasher
        {
            get { return MyNumClothesWasher; }
            set { MyNumClothesWasher = value; }
        }

        public int Spa
        {
            get { return MyNumSpa; }
            set { MyNumSpa = value; }
        }

    // ELECTRICAL
        public int NumAmps
        {
            get { return MyNumAmps; }
            set { MyNumAmps = value; }
        }
        public Boolean TempPole
        {
            get { return MyTempPole; }
            set { MyTempPole = value; }
        }
}