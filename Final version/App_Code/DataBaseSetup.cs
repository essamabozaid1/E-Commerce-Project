using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
public class DataBaseSetup
{
    SqlConnection conn;
    SqlCommand cmd;
    //DataTAble TBL 
    private void Initialization(CommandType CmdType,string DBCALLQUERY)
    {
        conn = new SqlConnection();
        cmd = new SqlCommand();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
        cmd.Connection = conn;
        cmd.CommandType = CmdType;
        cmd.CommandText = DBCALLQUERY;
        conn.Open();
    }
    public int RunProcedure(string ProcedureName, SortedList ParaVal)
    {
        Initialization(CommandType.StoredProcedure,ProcedureName);
        for (int x = 0; x < ParaVal.Count; x++)
        {//get key column 1   get index column2
            cmd.Parameters.AddWithValue(ParaVal.GetKey(x).ToString(), ParaVal.GetByIndex(x)); 
        }
        try
        {   
          int y= cmd.ExecuteNonQuery();// return number of column that happen  at insert & update & delete one column happen
          conn.Close();
          return y;
        }
        catch(SqlException ex){
            conn.Close();
            return ex.Number;
        }
    }
    public DataTable RunSelectQuery(string SelectQuery)
    {
        Initialization(CommandType.Text, SelectQuery);
        DataTable TBL =new DataTable();  //TBL=new DataTable();
        TBL.Load(cmd.ExecuteReader()); //return number of column that happen
        conn.Close(); 
        return TBL;
    }
    public object RunAggregationQuery(string SelectQuery)
    {
        Initialization(CommandType.Text, SelectQuery);
        object result = cmd.ExecuteScalar();
        conn.Close();
        return result;
    }
}
