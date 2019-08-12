using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;


    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            var namespaceName = GetType().Namespace;
            var classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType
                .GetFields(BindingFlags.Instance|BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();
            Object classInstance = Activator.CreateInstance(classType, new object[] { });
            stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");
            foreach (FieldInfo field in classFields.Where(f=>requestedFields.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return stringBuilder.ToString().Trim();
        }
    }

