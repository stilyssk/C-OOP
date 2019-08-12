using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;


public class Spy
{
    public string StealFieldInfo(string investigatedClass)
    {
        var namespaceName = GetType().Namespace;
        var classType = Type.GetType(investigatedClass);
        //FieldInfo[] classFields = classType
        //    .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        //.GetFields(BindingFlags.GetField| BindingFlags.Instance|BindingFlags.GetProperty|  BindingFlags.NonPublic | BindingFlags.Public);
        PropertyInfo[] properties = classType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Properties");
        foreach (var item in properties)
        {
            Console.WriteLine($"{item.Name}  {item.SetMethod.IsPublic}");

        }
        StringBuilder stringBuilder = new StringBuilder();
        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

        FieldInfo[] classFields = classType
            .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.GetCustomAttribute<CompilerGeneratedAttribute>() == null)
            .ToArray();
        Console.WriteLine("Fields");
        foreach (FieldInfo item in classFields)
        {
            Console.WriteLine($"{item.Name}  {item.IsPublic}");
            //stringBuilder.Append($"field type is = {field.Attributes}  ");
            //stringBuilder.Append($"field tipe is = {field.GetType().ReflectedType}  ");

            //stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        MethodInfo[] methodInfos = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Method");
        foreach (var item in methodInfos)
        {
            Console.WriteLine($"{item.Name}  {item.IsPublic}");
        }
        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder stringBuilder = new StringBuilder();


        foreach (FieldInfo currentField in classFields)
        {
            stringBuilder.AppendLine($"{currentField.Name} must be private!");
        }

        var nonPublicGetMethod = classNonPublicMethods.Where(m => m.Name.StartsWith("get")).ToArray();

        //var publicGetMethod = classPublicMethods.Where(m => m.Name.StartsWith("get")).ToArray();
        foreach (MethodInfo currentMethod in nonPublicGetMethod)
        {
            stringBuilder.AppendLine($"{currentMethod.Name} have to be public!");
        }

        var publicSetMethod = classPublicMethods.Where(m => m.Name.StartsWith("set")).ToArray();

        //var nonPublicSetMethod = classNonPublicMethods.Where(m => m.Name.StartsWith("set")).ToArray();
        foreach (MethodInfo currentMethod in publicSetMethod)
        {
            stringBuilder.AppendLine($"{currentMethod.Name} have to be private!");
        }

        return stringBuilder.ToString().Trim();
    }
}

