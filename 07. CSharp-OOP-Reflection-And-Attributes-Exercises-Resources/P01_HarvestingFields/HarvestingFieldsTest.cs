 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            //TODO put your reflection code here

            while (true)
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "HARVEST")
                {
                    break;
                }
                else
                {
                    var test = typeof(HarvestingFields);
                    var className = test.FullName;
                    var classType = Type.GetType(className);
                    FieldInfo[] classFields = classType
                        .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                    switch (inputCommand)
                    {
                        case "private":
                            var privateFieds = classFields.Where(x => x.IsPrivate).ToArray();
                            Print(inputCommand, privateFieds);
                            break;
                        case "protected":
                            var protectedField = classFields.Where(x => x.IsFamily).ToArray();
                            Print(inputCommand, protectedField);

                            break;
                        case "public":
                            var publicField = classFields.Where(x => x.IsPublic).ToArray();
                            Print(inputCommand, publicField);

                            break;
                        case "all":
                            Print(inputCommand, classFields);

                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static void Print(string typeParametur, FieldInfo[] fieldInfo)
        {
            foreach (var currentField in fieldInfo)
            {
                string attibutes = currentField.Attributes.ToString().ToLower();
                if (currentField.Attributes.ToString().ToLower()=="family")
                {
                    attibutes = "protected";
                }
                Console.WriteLine($"{attibutes} {currentField.FieldType.Name} {currentField.Name}");
            }
        }
    }
}
