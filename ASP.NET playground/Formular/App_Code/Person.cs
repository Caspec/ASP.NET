using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Person
{
    private String name;
    private int age;

	public Person(String name, int age)
	{
        this.name = name;
        this.age = age;
	}

    public string Describe()
    {
        return "Person: " + Name + ", " + Age;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}