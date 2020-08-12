using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order:MainClass
{
    private int _OrderID;
    public int OrderID
    {
        get { return _OrderID; }
        set { _OrderID = value; }
    }
    private DateTime _OrderDate;
    public DateTime OrderDate
    {
        get { return _OrderDate; }
        set { _OrderDate = value; }
    }
    private string _UserName;
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private int _EmployeeID;
    public int EmployeeID
    {
        get { return _EmployeeID; }
        set { _EmployeeID = value; }
    }
    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();//sortedlist two columns first column for @usrnme second column for value from textbox
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@OrderID", OrderID);
        SL.Add("@OrderDate", OrderDate);
        SL.Add("@UserName", UserName);
        SL.Add("@EmployeeID", EmployeeID);
        ProcedureName = "ManageOrder";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row effect
            return true;
        else
            return false;
    }
    public int GenerateID()
    {
        try
        {
            string Query = "Select Max(OrderID)+1 from [Order]";
            return Convert.ToInt16(RunSelectQuery(Query).Rows[0][0].ToString());
        }
        catch
        {
            return 1;
        }
       
    }
    public bool AddOrder(string UserName,int EmployeeID)
    {
        this.OrderID = this.GenerateID();
        this.OrderDate = DateTime.Now;
        this.UserName = UserName;
        this.EmployeeID = EmployeeID;
        if (Add() == true)
            return true;
        else
            return false;
    }

}