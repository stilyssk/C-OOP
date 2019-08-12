using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            IFamilyTreeMain familyTreeMain = new FamilyTreeMain();
            string mainPersonInput = Console.ReadLine();

            IPersonStore newMainPerson = new PersonStore();
            familyTreeMain.AddMainPerson(mainPersonInput);

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputPersonalArray = command
                    .Split(new[] { " - " },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputPersonalArray.Length==2)
                {
                    familyTreeMain.AddParentChildPair(inputPersonalArray[0], inputPersonalArray[1]);
                }
                else
                {
                    string[] inputUpdateArray = command
                        .Split(new[] { ' ' })
                        .ToArray();
                    string name = inputUpdateArray[0] + " " + inputUpdateArray[1];
                    string date = inputUpdateArray[2];
                    
                    familyTreeMain.UpdateParentChildPair(name,date);
                }
            }
            familyTreeMain.UpdateAll();
            Console.WriteLine(familyTreeMain);
        }
    }
}
