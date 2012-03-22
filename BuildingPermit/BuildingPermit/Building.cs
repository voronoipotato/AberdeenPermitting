/*
 * Programmer:      John Reasor
 * Date:            3-14-2012
 * Description:     Class for Building Information
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public class Building
{
    /// <summary>
    /// private variables for building class
    /// </summary>
    private string myBuildingType;
    private string myEstimatedCost;
    private string myTotalSF;
    private string myHeatedSF;
    private string myPorchSF;
    private string myNumStories;
    private string myDeckSF;
    private string myGarageSF;
    private string myBasementSF;

    /// <summary>
    /// Basmeent Sf Property
    /// </summary>
    public string basementSF
    {
        get { return myBasementSF; }

        set
        {

            if (value == null)
            {

            }
            else
            {
                if (isInt(value))
                {
                    myBasementSF = value.Trim();

                }
                else
                {
                    MessageBox.Show("Basement Square Feet must be a number");
                }
            }
        }
    }

    /// <summary>
    /// Garage Sf Property
    /// </summary>
    public string garageSF
    {
        get { return myGarageSF; }
        set
        {
            if (value == null)
            {

            }
            else
            {
                if (isInt(value))
                {
                    myGarageSF = value;
                }
                else
                {
                    MessageBox.Show("Garage Square Feet must be a number");
                }
            }
        }
    }

    /// <summary>
    /// Dech Sf Property
    /// </summary>
    public string deckSF
    {
        get { return myDeckSF; }

        set
        {
            if (value == null)
            {

            }
            else
            {
                if (isInt(value))
                {
                    myDeckSF = value;
                }
                else
                {
                    MessageBox.Show("Deck Square Feet must be a number");
                }
            }
        }
    }
    /// <summary>
    /// Number of stories
    /// </summary>
    public string numStories
    {
        get { return myNumStories; }

        set
        {
            if (value == null)
            {

            }
            else
            {
                if (isInt(value))
                {
                    myNumStories = value;
                }
                else
                {
                    MessageBox.Show("Number of stories must be a number");
                }
            }
        }
    }

    /// <summary>
    /// Porch Sf Property
    /// </summary>
    public string porchSF
    {
        get { return myPorchSF; }

        set
        {
            if (value == null)
            {

            }
            else
            {
                if (isInt(value))
                {
                    myPorchSF = value;
                }
                else
                {
                    MessageBox.Show("Porch Square Feet must be a number");
                }
            }

        }
    }

    /// <summary>
    /// Heated SF Property
    /// </summary>
    public string heatedSF
    {
        get { return myHeatedSF; }

        set
        {
            if (value == null )
            {
                
            }
            else
            {
                if (isInt(value))
                {
                    myHeatedSF = value;
                }
                else
                {
                    MessageBox.Show("Heated Square Feet must be a number");
                }
            }
        }
    }

    /// <summary>
    /// Total SF Property
    /// </summary>
    public string totalSF
    {
        get { return myTotalSF; }
        set
        {

           if (value == null )
            {
                MessageBox.Show("Total Square Feet is need for a the permit fee calculation and must be a number");
                
            }
            else
            {
               
                if (isInt(value))
                {
                    myTotalSF = value;

                }
                else
                {
                    MessageBox.Show("Total Square Feet and must be a number");
                } 
            } 
            
        }
    }

    /// <summary>
    /// Set Estimating Cost Property
    /// </summary>
    public string estimatedCost
    {
        get { return myEstimatedCost; }

        set
        {
            if (value == null)
            {

            }
            else
            {
                if (isDouble(value))
                {
                    myEstimatedCost = value;
                }
                else
                {
                    MessageBox.Show("Estimated cost must be a dollar amount, numbers only");
                }
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
    /// <summary>
    /// valadation for input double's
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static bool isDouble(string value)
    {
        double Num;

        return double.TryParse(value, out Num);
    }

}

