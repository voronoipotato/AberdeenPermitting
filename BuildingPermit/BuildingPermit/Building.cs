/*
 * Programmer:      John Reasor
 * Date:            3-14-2012
 * Description:     Class for the Building Information
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Building
{


    /// <summary>
    /// private variables for building class
    /// </summary>
    private string strBuildingType;
    private double dblEstimatedCost;
    private int intTotalSF;
    private int intHeatedSF;
    private int intPorchSF;
    private int intNumStories;
    private int intDeckSF;
    private int intGarageSF;
    private int intBasementSF;

    /// <summary>
    /// basement SF method
    /// </summary>
    public int BasementSF
    {
        get { return intBasementSF; }
        set { intBasementSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int GarageSF
    {
        get { return intGarageSF; }
        set { intGarageSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int DeckSF
    {
        get { return intDeckSF; }
        set { intDeckSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int NumStories
    {
        get { return intNumStories; }
        set { intNumStories = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int PorchSF
    {
        get { return intPorchSF; }
        set { intPorchSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int HeatedSF
    {
        get { return intHeatedSF; }
        set { intHeatedSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalSF
    {
        get { return intTotalSF; }
        set { intTotalSF = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public double EstimatedCost
    {
        get { return dblEstimatedCost; }
        set { dblEstimatedCost = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuildingType
    {
        get { return strBuildingType; }
        set { strBuildingType = value; }
    }


}

