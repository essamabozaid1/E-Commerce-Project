using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee:MainClass
{
    private int _EmployeeID;
    private string _EmployeeName;
    private string _Password;
    private string _FullName;
    private string _Gender;
    private string _Address;
    private string _Phone;
    private string _Email;

    public int EmployeeID
    {
        get { return _EmployeeID; }
        set { _EmployeeID = value; }
    }
    public string EmployeeName
    {
        get { return _EmployeeName; }
        set { _EmployeeName = value; }
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

    public override bool LoadProperties2List(string TypeOfOperation)// mb3ota mn el Add aw el Update aw el delete
    {
        SortedList SL = new SortedList();//sortedlist two columns first column for @usrnme second column for value from textbox
        SL.Add("@Check", TypeOfOperation);
        SL.Add("@EmployeeID", EmployeeID);
        SL.Add("@EmployeeName", EmployeeName);
        SL.Add("@Password", Password);
        SL.Add("@FullName", FullName);
        SL.Add("@Gender", Gender);
        SL.Add("@Address", Address);
        SL.Add("@Phone", Phone);
        SL.Add("@Email", Email);
        ProcedureName = "ManageEmployee";// 3shan ab3tha f run procedure
        if (RunProcedure(ProcedureName, SL) == 1)// f eladd w update w delete one row effect
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Register(string employeeName, string password, string fullname, string gender, string address, string phone, string email)
    {
        this.EmployeeID = Utility.GenerateID("Employee", "EmployeeID");
        this.EmployeeName = employeeName;
        this.Password = password;
        this.FullName = fullname;
        this.Gender = gender;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        if (Add() == true)
        {
            return "The Employee Added successfully";
        }
        else
        {
            return "EmployeeName already Exist ,please change EmployeeName";
        }
    }
    public DataTable Search(string Field, string Value)
    {
        string Query = string.Format("Select * from Employee where {0} like '%{1}%'", Field, Value);
        return RunSelectQuery(Query);
    }
    public string Delete(string EmployeeName)
    {
        this.EmployeeName = EmployeeName;
        if (Delete() == true)
            return "The Employee is Deleted";
        else
            return "The Employee is not Deleted";
    }



    public string Update(int employeeID, string employeeName, string password, string fullname, string gender, string address, string phone, string email)
    {
        this.EmployeeID = employeeID;
        this.EmployeeName = employeeName;
        this.Password = password;
        this.FullName = fullname;
        this.Gender = gender;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        if (Update() == true)
        {
            return "The Employee updated successfully";
        }
        else
        {
            return "You Can't Update the Employee info";
        }
    }
    public bool login(string EmployeeName, string Password)  // return string w a7na bnshr7
    {
        string SelectQuery = string.Format("Select * from Employee where EmployeeName='{0}' and Password='{1}'", EmployeeName, Password);
        if (RunSelectQuery(SelectQuery).Rows.Count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}