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
    /// Get basement SF Property
    /// </summary>
    public int getBasementSF
    {
        get { return myBasementSF; }
    }

    /// <summary>
    /// Set basement SF Property
    /// </summary>
    public string setBasementSF
    {
        set
        {

            if (isInt(value))
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
    /// get garage Sf Property
    /// </summary>
    public int getGarageSF
    {
        get { return myGarageSF; }

    }

    /// <summary>
    /// set garage Sf Property
    /// </summary>
    public string setGarageSF
    {

        set
        {
            if (isInt(value))
            {
                myGarageSF = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Garage Square Feet must be a number");
            }
        }
    }

    /// <summary>
    /// get deck SF Property
    /// </summary>
    public int getDeckSF
    {
        get { return myDeckSF; }

    }

    /// <summary>
    /// set dech Sf Property
    /// </summary>
    public string setDeckSF
    {

        set
        {
            if (isInt(value))
            {
                myDeckSF = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Deck Square Feet must be a number");
            }
        }
    }

    /// <summary>
    /// get number of stories Property
    /// </summary>
    public int getNumStories
    {
        get { return myNumStories; }

    }

    /// <summary>
    /// set number of stories
    /// </summary>
    public string setNumStories
    {

        set
        {
            if (isInt(value))
            {
                myNumStories = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Number of stories must be a number");
            }
        }
    }

    /// <summary>
    /// get porch SF Property
    /// </summary>
    public int getPorchSF
    {
        get { return myPorchSF; }

    }

    /// <summary>
    /// set porch Sf Property
    /// </summary>
    public string setPorchSF
    {

        set
        {
            if (isInt(value))
            {
                myPorchSF = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Porch Square Feet must be a number");
            }
        }
    }

    /// <summary>
    /// get heated SF Property
    /// </summary>
    public int getHeatedSF
    {
        get { return myHeatedSF; }

    }

    /// <summary>
    /// set heated SF Property
    /// </summary>
    public string setHeatedSF
    {

        set
        {
            if (isInt(value))
            {
                myHeatedSF = Convert.ToInt16(value);
            }
            else
            {
                MessageBox.Show("Heated Square Feet must be a number");
            }
        }
    }

    /// <summary>
    /// Total SF Property
    /// </summary>
    public int totalSF
    {
        get { return myTotalSF; }
        set { myTotalSF = myHeatedSF + myPorchSF + myGarageSF + myBasementSF; }// add total SF from input
    }

    /// <summary>
    /// get Estimate Cost Property
    /// Round to two digits and format for dollar amount
    /// </summary>
    public double getEstimatedCost
    {

        get{return  myEstimatedCost}
    }

    /// <summary>
    /// Set Estimating Cost Property
    /// </summary>
    public string setEstimatedCost
    {

        set
        {
            if (isDouble(value))
            {
                myEstimatedCost = Convert.ToDouble(value);
            }
            else
            {
                MessageBox.Show("Estimated cost must be a dollar amount, numbers only");
            }
        }
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


    private static bool isInt(string value)
    {
        int Num;

        return int.TryParse(value, out Num);
    }

    private static bool isDouble(string value)
    {
        double Num;

        return double.TryParse(value, out Num);
    }

}

