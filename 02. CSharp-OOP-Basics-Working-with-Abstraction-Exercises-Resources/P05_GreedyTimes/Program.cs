using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long capacityOfTheBag = long.Parse(Console.ReadLine());
            string[] seif = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //var bag = new Dictionary<string, Dictionary<string, long>>();
            Bag bag = new Bag();

            //long gold = 0;
            //long gems = 0;
            //long cash = 0;

            for (int i = 0; i < seif.Length; i += 2)
            {
                string name = seif[i];
                long amount = long.Parse(seif[i + 1]);

                string itemName = string.Empty;

                if (name.Length == 3)
                {
                    itemName = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    itemName = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    itemName = "Gold";
                }

                if (itemName == "")
                {
                    continue;
                }
                else if (capacityOfTheBag < bag.SumAllInBag() + amount)
                {
                    continue;
                }

                switch (itemName)
                {
                    case "Gem":
                       if (capacityOfTheBag >= (bag.SumAllInBag() + amount))
                        {
                            if (bag.SumGold() >= bag.SumAllGems() + amount)
                            {
                                bag.AddGems(name, amount);
                            }
                        }
                        break;
                    ////if (!bag.ContainsKey(itemName))
                    //if (!bag.CheckExistGems())
                    //{
                    //    //if (bag.ContainsKey("Gold"))
                    //    if (bag.CheckExistGold())
                    //    {
                    //        //if (broika > bag["Gold"].Values.Sum())
                    //        if (amount > bag.SumGold())
                    //        {
                    //            bag.CreateGems(name, amount);
                    //            //continue;
                    //        }
                    //    }
                    //}
                    //else if (bag.SumAllGems() + amount > bag.SumGold())
                    //{
                    //    bag.AddGems(name, amount);
                    //    //continue;
                    //}
                    //break;
                    case "Cash":
                        if (capacityOfTheBag >= (bag.SumAllInBag() + amount))
                        {
                            if (bag.SumAllGems()>=bag.SumAllCash()+amount)
                            {
                                bag.AddCash(name, amount);
                            }
                        }
                        break;
                        //if (!bag.CheckExistCash())
                        //{
                        //    if (bag.CheckExistGems())
                        //    {
                        //        if (amount > bag.SumAllGems())
                        //        {
                        //            bag.CreateCash(name, amount);
                        //            //continue;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        bag.AddCash(name, amount);
                        //        //continue;
                        //    }
                        //}

                        ////else if (bag[itemName].Values.Sum() + amount > bag["Gem"].Values.Sum())
                        //else if (bag.SumAllCash() + amount > bag.SumAllGems())
                        //{
                        //    bag.AddCash(name,amount);
                        //    //continue;
                        //}
                        //break;
                    case "Gold":
                        if (capacityOfTheBag>=(bag.SumAllInBag()+amount))
                        {
                            bag.AddGold(amount);
                        }
                        break;

                }

                //if (!bag.ContainsKey(itemName))
                //{
                //    bag[itemName] = new Dictionary<string, long>();
                //}

                //if (!bag[itemName].ContainsKey(name))
                //{
                //    bag[itemName][name] = 0;
                //}

                //bag[itemName][name] += amount;
                //if (itemName == "Gold")
                //{
                //    gold += amount;
                //}
                //else if (itemName == "Gem")
                //{
                //    gems += amount;
                //}
                //else if (itemName == "Cash")
                //{
                //    cash += amount;
                //}
            }
            //var resultGold = bag.GetAllGold();
            //var resultCash = bag.GetAllCash();
            //var resultGems = bag.GetAllGems();
            //resultGems = resultGems.OrderByDescending(x => x.Name).ToList();
            //resultCash = resultCash.OrderByDescending(x => x.Name).ToList();

            Console.WriteLine(bag);
            //Console.WriteLine(resultGold);
            

            //foreach (var currentGems in resultGems)
            //{
            //    Console.WriteLine($"{currentGems.Name} {currentGems.Quantity}");
            //}

            //foreach (var currentCash in resultCash)
            //{
            //    Console.WriteLine($"{currentCash.Name} {currentCash.Quantity}");
            //}

            //foreach (var x in bag)
            //{
            //    Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
            //    foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            //    {
            //        Console.WriteLine($"##{item2.Key} - {item2.Value}");
            //    }
            //}
        }
    }
}