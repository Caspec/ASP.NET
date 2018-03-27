using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Employee
{
    private String name;
    private String empid;
    private String department;

	public Employee()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Empid
    {
        get { return empid; }
        set { empid = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }
}