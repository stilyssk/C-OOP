using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass,params string[] fields)
        {
            
            var type = Type.GetType("Stealer.Hacker");
            //FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public|BindingFlags.ExactBinding)
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public|BindingFlags.ExactBinding);
            foreach (var field in fieldInfos)
            {
                Console.WriteLine(field.Name);
            }

            Object classInstance = Activator.CreateInstance(type, new object[] { });


            //string printString = this.Print("nameOfTheClass");
            //string fieldInformationString = this.PringFieldInformation("fieldName", "fieldValue");
            //StringBuilder result = new StringBuilder();
            //result.Append(printString);
            //result.Append(fieldInformationString);
            //return result.ToString();
            return null;
        }

        private string Print(string nameOfTheClass)
        {
            return $"Class under investigation: {nameOfTheClass}";
        }

        private string PringFieldInformation(string filedName, string fieldValue)
        {
            return $"{ filedName} = { fieldValue}";
        }
    }
}
