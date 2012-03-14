/*
 * Programmer:      John Reasor
 * Date:            3-14-2012
 * Description:     Class for the Building Information
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


class Building
{
    /// <summary>
    /// private variables for building class
    /// </summary>
    private string myBuildingType;
    private double myEstimatedCost;
    private int myTotalSF;
    private int myHeatedSF;
    private int myPorchSF;
    private int myNumStories;
    private int myDeckSF;
    private int myGarageSF;
    private int myBasementSF;

      
    /// <summary>
    /// Set basement SF Property
    /// </summary>
    public string setBasementSF
    {
        set
        {
            int Num;
            bool isNum = int.TryParse(value, out Num);

            if (isNum)
            {
                myBasementSF = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Basement Square Feet must be a number");
            }
         }
    }

    /// <summary>
    /// Get basement SF Property
    /// </summary>
    public int getBasementSF
    {
        get { return myBasementSF; }
    }

    /// <summary>
    /// garage Sf Property
    /// </summary>
    public int garageSF
    {
        get { return myGarageSF; }
        set { myGarageSF = value; }
    }

    /// <summary>
    /// deck SF Property
    /// </summary>
    public int deckSF
    {
        get { return myDeckSF; }
        set { myDeckSF = value; }
    }

    /// <summary>
    /// number of stories Property
    /// </summary>
    public int numStories
    {
        get { return myNumStories; }
        set { myNumStories = value; }
    }

    /// <summary>
    /// porch SF Property
    /// </summary>
    public int porchSF
    {
        get { return myPorchSF; }
        set { myPorchSF = value; }
    }

    /// <summary>
    /// heated SF Property
    /// </summary>
    public int heatedSF
    {
        get { return myHeatedSF; }
        set { myHeatedSF = value; }
    }

    /// <summary>
    /// Total SF Property
    /// </summary>
    public int totalSF
    {
        get { return myTotalSF; }
        set { myTotalSF = value; }
    }

    /// <summary>
    /// Estimate Cost Property
    /// Round to two digits and format for dollar amount
    /// </summary>
    public double estimatedCost
    {
        get { return myEstimatedCost; }
        set { myEstimatedCost = value; }
    }

    /// <summary>
    /// Building Type Property
    /// </summary>
    public string buildingType
    {
        get { return myBuildingType; }
        set { myBuildingType = value; }
    }

    /// <summary>
    /// constructor
    /// </summary>
    public Building()
    {

    }


}

