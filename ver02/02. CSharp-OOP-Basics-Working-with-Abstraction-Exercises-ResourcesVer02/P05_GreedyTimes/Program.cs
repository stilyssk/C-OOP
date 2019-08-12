using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            IBag bag = new Bag(bagCapacity);
            string[] safe = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);
                string item = string.Empty;
                item = SelectItem(name);
                long bagOcupate = bag.OcupateBag;

                if (item == "Gold")
                {
                    bag.Gold += count;
                }
                else if (item == "Gem")
                {
                    bag.AddGem(name,count);
                }
                else if (item == "Cash")
                {
                    bag.AddCash(name,count);
                }
            }
            Console.WriteLine(bag.PrintResult());
        }

        static string SelectItem(string name)
        {
            string item = string.Empty;
            if (name.Length == 3)
            {
                item = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                item = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                item = "Gold";
            }
            return item;
        }
    }
}