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
        private int MyNumbOfSys;
    //  PLUMBING
        private int MyTotNumbOfBathrooms;
        private int MyNumbWaterClosets;
        private int MyNumbDishWasher;
        private int MyNumbWaterHeater;
        private int MyTotNumbOfFixtures;
        private int MyNumbShowers;
        private int MyNumbTubs;
        private int MyNumbWetBar;
        private int MyNumbSinks;
        private int MyNumbClothesWasher;
        private int MyNumbSpa;
    // ELECTRICAL
        private int MyNumbOfAmps;
        private Boolean MyTempPoll;

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

        public Boolean DuckWork
        {
            set
            {
                if (MyDuctWork == true)
                {

                }
                else
                {
                    MessageBox.Show("no duckwork.");
                }
            }
        }
        
        public int NumbOfSys
        {
            get { return MyNumbOfSys; }
            set { MyNumbOfSys = value; }
        }

    //  PLUMBING
        public int NumbOfBathrooms
        {
            get { return MyTotNumbOfBathrooms; }
            set { MyTotNumbOfBathrooms = value; }
        }

        public int WaterClosets
        {
            get { return MyNumbWaterClosets; }
            set { MyNumbWaterClosets = value; } 
        }

        public int DishWasher
        {
            get { return MyNumbDishWasher; }
            set { MyNumbDishWasher = value; }
        }

        public int WaterHeater
        {
            get { return MyNumbWaterHeater; }
            set { MyNumbWaterHeater = value; }
        }

        public int NumbOfFixtures
        {
            get { return MyTotNumbOfFixtures; }
            set { MyTotNumbOfFixtures = value; }
        }

        public int Showers
        {
            get { return MyNumbShowers; }
            set { MyNumbShowers = value; }
        }

        public int Tub
        {
            get { return MyNumbTubs; }
            set { MyNumbTubs = value; }
        }

        public int WetBar
        {
            get { return MyNumbWetBar; }
            set { MyNumbWetBar = value; }
        }

        public int Sinks
        {
            get { return MyNumbSinks; }
            set { MyNumbSinks = value; }
        }

        public int clothesWasher
        {
            get { return MyNumbClothesWasher; }
            set { MyNumbClothesWasher = value; }
        }

        public int Spa
        {
            get { return MyNumbSpa; }
            set { MyNumbSpa = value; }
        }

    // ELECTRICAL
        public int NumbOfAmps
        {
            get { return MyNumbOfAmps; }
            set { MyNumbOfAmps = value; }
        }
        public Boolean TempPoll
        {
            set
            {
                if (MyTempPoll == true)
                {

                }
                else
                {
                    MessageBox.Show("no temporary poll");
                }
            }
        }
}