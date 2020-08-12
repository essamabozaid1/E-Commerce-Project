using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Food
/// </summary>
public class Food:MainClass
{
    #region Feilds
    private Category _CatID;
    public Category CatID
    {
        get { return _CatID; }
        set { _CatID = value; }
    }

    private int _CategoryID;
    public int CategoryID
    {
        get { return _CategoryID; }
        set { _CategoryID = value; }
    }

    private int _FoodID;
    public int FoodID
    {
        get { return _FoodID; }
        set { _FoodID = value; }
    }

    private string _FoodName;
    public string FoodName
    {
        get { return _FoodName; }
        set { _FoodName = value; }
    }

    private double _FoodPrice;
    public double FoodPrice
    {
        get { return _FoodPrice; }
        set { _FoodPrice = value; }
    }
    private DateTime _WrittingTime;

    public DateTime WrittingTime
    {
        get { return _WrittingTime; }
        set { _WrittingTime = value; }
    }

    private int _AvailableQTY;
    public int AvailableQTY
    {
        get { return _AvailableQTY; }
        set { _AvailableQTY = value; }
    }

    private string _Description;
    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }
    #endregion
    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@CategoryID", CategoryID);
        SL.Add("@FoodID", FoodID);
        SL.Add("@FoodName", FoodName);
        SL.Add("@FoodPrice", FoodPrice);
        SL.Add("@WrittingTime", WrittingTime);
        SL.Add("@AvailableQTY", AvailableQTY);
        SL.Add("@Description", Description);
        ProcedureName = "ManageFood";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row happen  
            return true;
        else
            return false;
    }
    public string AddFood(int categoryID, int FoodID, string FoodName,double FoodPrice,int AvailableQTY,string Description)
    {
        this.CategoryID = categoryID;
        this.FoodID = FoodID;
        this.FoodName = FoodName;
        this.FoodPrice = FoodPrice;
        this.WrittingTime = DateTime.Now;
        this.AvailableQTY = AvailableQTY;
        this.Description = Description;
        if (Add() == true)
            return "The Food Item Added successfully";
        else
            return "Food Item not Added ,please change Food Name or Category ID";
    }
    public string UpdateFood(int categoryID, int FoodID, string FoodName, double FoodPrice, int AvailableQTY, string Description)
    {
        this.CategoryID = categoryID;
        this.FoodID = FoodID;
        this.FoodName = FoodName;
        this.FoodPrice = FoodPrice;
        this.WrittingTime = DateTime.Now;

        this.AvailableQTY = AvailableQTY;
        this.Description = Description;
        if (Update() == true)
            return "The Food Updated successfully";
        else
            return "You Can't Update the Food Item";
    }
    public string DeleteFood(int CategoryID,int FoodID)
    {
        this.CategoryID = CategoryID;
        this.FoodID = FoodID;
        if (Delete() == true)
            return "The Food item is Deleted";
        else
            return "The Food item is not Deleted";
    }
    public DataTable Search(string Field, string Value)
    {
        string Query = string.Format("Select * from Food where {0} like '%{1}%'", Field, Value);
        try
        {
            return RunSelectQuery(Query);
        }
        catch
        {
            return new DataTable();
        }
    }


    public bool Find(string CatID, string FoodID)
    {
       string Query= string.Format("Select * From Food Where CategoryID='{0}' AND FoodID='{1}'", CatID, FoodID);
       DataTable Tbl= RunSelectQuery(Query);
       if (Tbl.Rows.Count == 0)
           return false;
       else
       {
           this.CategoryID = Convert.ToInt16(Tbl.Rows[0][0].ToString());
           this.FoodID = Convert.ToInt16(Tbl.Rows[0][1].ToString());
           this.FoodName = Tbl.Rows[0][2].ToString();
           this.FoodPrice = Convert.ToDouble(Tbl.Rows[0][3].ToString());
           this.AvailableQTY = Convert.ToInt16(Tbl.Rows[0][5].ToString());
           this.Description = Tbl.Rows[0][6].ToString();
           return true;
       }
          
    }
}