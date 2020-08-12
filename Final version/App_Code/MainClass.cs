using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MainClass
/// </summary>
public abstract class MainClass:DataBaseSetup
{
    /*
    instead of inhertance from DataBaseSetup we can 
    protected DataBaseSetup = new DataBaseSetup();
     to see at all classes where that all classes inhertance main class
     */
    protected string ProcedureName;
    public virtual bool LoadProperties2List(string TypeOfOperation)
    {
        return true;// shakek f deh
    }
    public bool Add()  
    {
        return LoadProperties2List("a");
    }
    public bool Update()
    {
        return LoadProperties2List("u");
    }
    public bool Delete()
    {
        return LoadProperties2List("d");
    }
}