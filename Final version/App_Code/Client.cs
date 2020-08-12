using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Client : MainClass
{
    #region fields
    private string _UserName;
    private string _Password;
    private string _FullName;
    private string _Gender;
    private string _Address;
    private string _Phone;
    private string _Email;
    #endregion

    #region properties
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    public string FullName
    {
        get { return _FullName; }
        set { _FullName = value; }
    }
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    #endregion

    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();//sortedlist two columns first column for @usrnme second column for value from textbox
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@UserName", UserName);
        SL.Add("@Password", Password);
        SL.Add("@FullName", FullName);
        SL.Add("@Gender", Gender);
        SL.Add("@Address", Address);
        SL.Add("@Phone", Phone);
        SL.Add("@Email", Email);
        ProcedureName = "ManageClient";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row happen  
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string Register(string username, string password, string fullname, string gender, string address, string phone, string email)
    {
        this.UserName = username;
        this.Password = password;
        this.FullName = fullname;
        this.Gender = gender;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        if (Add() == true)
        {
            return "user Added successfully";
        }
        else
        {
            return "user name already Exist ,please change username";
        }
    }


    public string Register()  // another way
    {
        if (Add() == true)
        {
            return "user Added successfully";
        }
        else
        {
            return "user name already exist,please change username";
        }
    }

    public bool login(string username, string password)  // return string w a7na bnshr7
    {

        string SelectQuery = string.Format("Select * from Client where UserName='{0}' and Password='{1}'", username, password);
        if (RunSelectQuery(SelectQuery).Rows.Count == 1)
        {
            //HttpContext.Current.Session["login"] = 1;   lw 3aez session

            return true;// n3mlha true w false el 2wl w nktb el gomla f login.aspx.cs    // b3deha lma nbd2 nsh8l el redirect n5leha true false tany

        }
        else
        {
            //HttpContext.Current.Session["login"] = null;
            return false;
        }

    }

    public DataTable Search(string Field, string Value)
    {
        string Query = string.Format("Select * from Client where {0} like '%{1}%'", Field, Value);
        return RunSelectQuery(Query);
    }

    public string Delete(string UserName)
    {
        this.UserName = UserName;
        if (Delete() == true)
            return "The Client is Deleted";
        else
            return "The Client is not Deleted";
    }
    public string Update(string username, string password, string fullname, string gender, string address, string phone, string email)
    {
        this.UserName = username;
        this.Password = password;
        this.FullName = fullname;
        this.Gender = gender;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        if (Update() == true)
        {
            return "The Client updated successfully";
        }
        else
        {
            return "You Can't Update the Client info";
        }
    }
}