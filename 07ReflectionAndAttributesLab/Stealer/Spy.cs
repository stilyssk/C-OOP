using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;


    public class Spy
    {
        public string StealFieldInfo(string investigatedClass,params string[] fields)
        {
            var namespaceName = GetType().Namespace;
            var type = Type.GetType(investigatedClass);
            FieldInfo[] fieldInfos = type.
                GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.ExactBinding)
                .Where(f => f.GetCustomAttribute<CompilerGeneratedAttribute>() == null)
                .ToArray();
            Object classInstance = Activator.CreateInstance(type, new object[] { });
            StringBuilder result = new StringBuilder();
            result.AppendLine(Print(investigatedClass));

            foreach (var field in fieldInfos)
            {
                var name = field.Name;
                var value = field.GetValue(classInstance).ToString();
                result.AppendLine(PringFieldInformation(name, value));
            }
            return result.ToString();
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

