using CodingTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public|BindingFlags.Static);
        foreach (MethodInfo currentMethod in methods)
        {
            if (currentMethod.CustomAttributes.Any(n=>n.AttributeType== typeof(AuthorAttribute)))
            {
                var attributes = currentMethod.GetCustomAttributes(false);
                foreach (AuthorAttribute attr in attributes)
                {
                    Console.WriteLine("{0} is whitten by {1}",currentMethod.Name,attr.Name);
                }
            }
        }
    }
}
