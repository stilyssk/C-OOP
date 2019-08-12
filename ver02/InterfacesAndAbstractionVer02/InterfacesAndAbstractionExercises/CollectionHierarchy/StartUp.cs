using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputCollection = Console.ReadLine()
                .Split(new[] { ' ' });
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            StringBuilder firstLine = new StringBuilder();
            StringBuilder secondLine = new StringBuilder();
            StringBuilder thirdLine = new StringBuilder();
            StringBuilder fourthLine = new StringBuilder();
            StringBuilder fifthLine = new StringBuilder();
            foreach (var currentIntem in inputCollection)
            {
                firstLine.Append(addCollection.Add(currentIntem) + " ");
                secondLine.Append(addRemoveCollection.Add(currentIntem) + " ");
                thirdLine.Append(myList.Add(currentIntem) + " ");

            }
            var repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                fourthLine.Append(addRemoveCollection.Remove() + " ");
                fifthLine.Append(myList.Remove() + " ");
            }
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);
            Console.WriteLine(fifthLine);
        }
    }
}
