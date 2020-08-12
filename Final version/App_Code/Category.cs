using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class Category:MainClass
{
    #region fields
    private int _CategoryID;
    private string _CategoryName;
    private string _CategoryDescription;
    #endregion
    #region Properties
    public int CategoryID
    {
        get { return _CategoryID; }
        set { _CategoryID = value; }
    }
    public string CategoryName
    {
        get { return _CategoryName; }
        set { _CategoryName = value; }
    }
    public string CategoryDescription
    {
        get { return _CategoryDescription; }
        set { _CategoryDescription = value; }
    }
    #endregion

    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@CategoryID",CategoryID);
        SL.Add("@CategoryName",CategoryName);
        SL.Add("@CategoryDescription",CategoryDescription);
        ProcedureName = "ManageCategory";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row happen  
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string AddCategory(int categoryID,string categoryName,string categoryDescription)
    {
        this._CategoryID = categoryID;
        this._CategoryName = categoryName;
        this.CategoryDescription = categoryDescription;
        if (Add() == true)
        {
            return "The Category Added successfully";
        }
        else
        {
            return "Category not Added ,please change Category Name or Category ID";
        }
    }
    public string UpdateCategory(int categoryID, string categoryName, string categoryDescription)
    {
        this._CategoryID = categoryID;
        this._CategoryName = categoryName;
        this.CategoryDescription = categoryDescription;
        if (Update() == true)
            return "The Category updated successfully";
        else
             return "You Can't Update the Category info";
    }
    public string DeleteCategory(int CategoryID)
    {
        this.CategoryID = CategoryID;
        if (Delete() == true)
            return "The Category is Deleted";
        else
            return "The Category is not Deleted";
    }
    public DataTable Search(string Field, string Value)
    {
        string Query = string.Format("Select * from Category where {0} like '%{1}%'", Field, Value);
        try
        {
            return RunSelectQuery(Query);
        }
        catch
        {
            return new DataTable();
        }
    }
    public int GenerateID_Category()
    {
        string Query="Select Max(CategoryID) from Category";
        object Res= RunAggregationQuery(Query);
        int ID = Convert.ToInt32(Res);
        return ID+1;
    }
    


}