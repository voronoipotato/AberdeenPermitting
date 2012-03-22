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
    private Boolean myGasLine;
    private Boolean myDuctWork;
    private int myNumSys;
    //  PLUMBING
    private string myTotNumBathrooms;
    private string myNumWaterClosets;
    private string myNumDishWasher;
    private string myNumWaterHeater;
    private int myTotNumFixtures;
    private string myNumShowers;
    private string myNumTubs;
    private string myNumWetBar;
    private string myNumSinks;
    private string myNumClothesWasher;
    private string myNumSpa;
    // ELECTRICAL
    private int myNumAmps;
    private Boolean myTempPole;

    //  HEATING/AIR-CONDITIONING/MECHANICAL
    /// <summary>
    /// gas line variable
    /// </summary>
    public Boolean gasLine
    {
        set { myGasLine = value; }
        get { return myGasLine; }
    }
    /// <summary>
    /// duck work variable
    /// </summary>
    public Boolean ductWork
    {
        get { return myDuctWork; }
        set { myDuctWork = value; }
    }
    /// <summary>
    /// number of air conditioning systems get
    /// </summary
    public int getNumSys
    {
        get { return myNumSys; }
    }
    /// <summary>
    /// number of air conditioning systems set
    /// </summary>
    public string setNumSys
    {
        set
        {

            if (isInt(value))
            {
                myNumSys = Convert.ToInt16(value);
            }

            else
            {
                MessageBox.Show("Number of systems must be a number");
            }
        }
    }


    //  PLUMBING
    /// <summary>
    /// number of bathrooms
    /// </summary>
    public string numBathrooms
    {
        get { return myTotNumBathrooms; }
        set { myTotNumBathrooms = value; }
    }
    /// <summary>
    /// number of water closets
    /// </summary>
    public string waterClosets
    {
        get { return myNumWaterClosets; }
        set { myNumWaterClosets = value; }
    }
    /// <summary>
    /// number of dish washers
    /// </summary>
    public string dishWasher
    {
        get { return myNumDishWasher; }
        set { myNumDishWasher = value; }
    }
    /// <summary>
    /// number of water heaters
    /// </summary>
    public string waterHeater
    {
        get { return myNumWaterHeater; }
        set { myNumWaterHeater = value; }
    }
    /// <summary>
    /// number of total fixtures used in caculation get
    /// </summary>
    public int getNumFixtures
    {
        get { return myTotNumFixtures; }

    }
    /// <summary>
    /// number of total fixtures used in caculation set
    /// </summary>
    public string setNumFixtures
    {
        set
        {

            if (isInt(value))
            {
                myTotNumFixtures = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Number of fixtures must be a number");
            }
        }
    }
    /// <summary>
    /// number of showers
    /// </summary>
    public string showers
    {
        get { return myNumShowers; }
        set { myNumShowers = value; }
    }
    /// <summary>
    /// number of tubs
    /// </summary>
    public string tub
    {
        get { return myNumTubs; }
        set { myNumTubs = value; }
    }
    /// <summary>
    /// numbe rof wet bar small sink with frig.
    /// </summary>
    public string wetBar
    {
        get { return myNumWetBar; }
        set { myNumWetBar = value; }
    }

    /// <summary>
    /// number of sinks
    /// </summary>
    public string sinks
    {
        get { return myNumSinks; }
        set { myNumSinks = value; }
    }

    /// <summary>
    /// number of clothswashers
    /// </summary>
    public string clothesWasher
    {
        get { return myNumClothesWasher; }
        set { myNumClothesWasher = value; }
    }

    /// <summary>
    /// number of spa's
    /// </summary>
    public string spa
    {
        get { return myNumSpa; }
        set { myNumSpa = value; }
    }

    // ELECTRICAL
    /// <summary>
    /// Number of AMPS used in caculation get
    /// </summary>
    public int getNumAmps
    {
        get { return myNumAmps; }
    }
    /// <summary>
    /// Number of AMPS used in caculation set
    /// </summary>
    public string setNumAmps
    {
        set
        {

            if (isInt(value))
            {
                myNumAmps = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Number of AMPS must be a number");
            }
        }
    }
    /// <summary>
    /// Temppole variable
    /// </summary>
    public Boolean tempPole
    {
        get { return myTempPole; }
        set { myTempPole = value; }
    }
    /// <summary>
    /// valadation for input int's
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static bool isInt(string value)
    {
        int Num;

        return int.TryParse(value, out Num);
    }
}