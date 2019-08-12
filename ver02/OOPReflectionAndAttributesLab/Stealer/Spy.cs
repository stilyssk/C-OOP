using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] namesOfFields)
        {
            var namespaceName = GetType().Namespace;
            var classFullName = namespaceName +"."+className ;
            var typeInformation = Type.GetType(classFullName);
            var fildInformation = typeInformation.GetFields(BindingFlags.Instance| BindingFlags.NonPublic|BindingFlags.Public);
            Object classintance = Activator.CreateInstance(typeInformation, new object[] { });
            Console.WriteLine($"Class under investigation: { namespaceName}");
            foreach (var item in fildInformation)
            {
                Console.WriteLine(item.Name);
            }

            throw new NotImplementedException();
        }


    }
}
