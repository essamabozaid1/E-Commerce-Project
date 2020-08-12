using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetails
/// </summary>
public class OrderDetails:MainClass
{
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
    private int _OrderID;
    public int OrderID
    {
        get { return _OrderID; }
        set { _OrderID = value; }
    }
    private int _Quentity;
    public int Quentity
    {
        get { return _Quentity; }
        set { _Quentity = value; }
    }
    private double _SellPrice;
    public double SellPrice
    {
        get { return _SellPrice; }
        set { _SellPrice = value; }
    }
    private double _Discount;
    public double Discount
    {
        get { return _Discount; }
        set { _Discount = value; }
    }
    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();//sortedlist two columns first column for @usrnme second column for value from textbox
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@CategoryID", CategoryID);
        SL.Add("@FoodID", FoodID);
        SL.Add("@OrderID", OrderID);
        SL.Add("@Quentity", Quentity);
        SL.Add("@SellPrice", SellPrice);
        SL.Add("@Discount", Discount);     
        ProcedureName = "ManageOrderDetials";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row effect
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}