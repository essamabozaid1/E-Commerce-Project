using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Utility
{
    public static void CreateCookie(string CookieName,string [] Keys,string [] Values,bool Saved)
    {
        HttpCookie Cookie = new HttpCookie(CookieName);
        for (int i = 0; i < Keys.Length; i++)
        {
            Cookie[Keys[i]] = Values[i];
        }
        if (Saved == true)
        {
            Cookie.Expires = DateTime.Now.AddYears(5);
        }
        HttpContext.Current.Response.Cookies.Add(Cookie);
    }
    public static string ReadFromCookie(string CookieName, string Key)
    {
        try
        {
            HttpCookie Cookie = HttpContext.Current.Request.Cookies[CookieName];
            return Cookie[Key].ToString();
        }
        catch
        {
            return null;
        }
    }
    public static void RemoveCookie(string CookieName)
    {
        HttpCookie Cookie = HttpContext.Current.Request.Cookies[CookieName];
        Cookie.Expires = DateTime.Now.AddYears(-5);
        HttpContext.Current.Response.Cookies.Add(Cookie);
    }
    
    public static int GenerateID(string TableName,string ColumnName)
    {
        string ResultString;
        string Last3Char;
        DataBaseSetup DB=new DataBaseSetup();
        int year = DateTime.Now.Year;
        int Month = DateTime.Now.Month;
        string Query = "Select Max(EmployeeID) from Employee";
        object obj=DB.RunAggregationQuery(Query);

        if (obj.GetType() == typeof(DBNull))
        {
            Last3Char = "000";
        }
        else
        {
            int CountID = (int)obj;
            ResultString = CountID.ToString();
            Last3Char = ResultString.Substring(ResultString.Length - 3);
        }
        string ID = year.ToString() + Month.ToString() + Last3Char;
        int IntID = Convert.ToInt32(ID);
        return IntID + 1;     
    }
}