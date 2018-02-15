using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
        string[] nameforsort = { "RD", "TOM", "ACE", "Dough"};
        string sortname = string.Empty;
        Console.WriteLine("Sort string without using sort method ");

        for (int i = 0; i < nameforsort.Length; i++)
        {
            int a = 0;
            for (int j = 1; j < nameforsort.Length; j++)
            {
                if (j > i)
                {
                Sort:
                    if (nameforsort[i][a] != nameforsort[j][a])
                    {
                        if (nameforsort[i][a] > nameforsort[j][a])
                        {
                            sortname = nameforsort[i];
                            nameforsort[i] = nameforsort[j];
                            nameforsort[j] = sortname;
                        }
                    }
                    else
                    {
                        a = a + 1;
                        goto Sort;
                    }
                }
            }
            Console.WriteLine(nameforsort[i]);
        }
	}
}