using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    public class Bag
    {
        private long goldQuanity;
        private List<Gem> gemsList;
        private List<Cash> cashList;

        public long GoldQuantity
        {
            get
            {
                return this.goldQuanity;
            }
            set
            {
                this.goldQuanity = value;
            }
        }

        public Bag()
        {
            this.goldQuanity = 0;
            this.gemsList = new List<Gem>();
            this.cashList = new List<Cash>();
        }

        public bool CheckNameGems(string nameGem)
        {
            return gemsList.Exists(x => x.Name == nameGem);

        }

        public bool CheckNameCash(string nameCash)
        {
            return cashList.Exists(x => x.Name == nameCash);
        }

        public bool CheckExistGold()
        {
            if (goldQuanity == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckExistCash()
        {
            if (cashList.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckExistGems()
        {
            if (gemsList.Count == 0)
            {
                return false;
            }
            return true;
        }

        public long SumGold()
        {
            return goldQuanity;
        }

        public long SumAllGems()
        {
            return gemsList.Sum(x => x.Quantity);
        }

        public long SumAllCash()
        {
            return cashList.Sum(x => x.Quantity);
        }

        public long SumAllInBag()
        {
            return SumGold() + SumAllGems() + SumAllCash();
        }

        public void AddGems(string gemName, long quantity)
        {
            if (gemsList.Exists(x => x.Name == gemName))
            {
                int indexOfGems = gemsList.FindIndex(x => x.Name == gemName);
                gemsList[indexOfGems].Quantity += quantity;

            }
            else
            {
                Gem newGem = new Gem();
                newGem.Name = gemName;
                newGem.Quantity = quantity;
                gemsList.Add(newGem);
            }
        }

        public void CreateGems(string gemName, long quantity)
        {
            Gem newGem = new Gem();
            newGem.Name = gemName;
            newGem.Quantity = quantity;
            gemsList.Add(newGem);
        }

        public void AddCash(string cashName, long quantity)
        {
            if (cashList.Exists(x => x.Name == cashName))
            {
                int indexOfCash = cashList.FindIndex(x => x.Name == cashName);
                cashList[indexOfCash].Quantity += quantity;
            }
            else
            {
                Cash newCash = new Cash();
                newCash.Name = cashName;
                newCash.Quantity = quantity;
                cashList.Add(newCash);
            }
        }

        public void CreateCash(string cashName, long quantity)
        {
            Cash newCash = new Cash();
            newCash.Name = cashName;
            newCash.Quantity = quantity;
            cashList.Add(newCash);
        }

        public void AddGold(long quantity)
        {
            this.GoldQuantity += quantity;
        }

        public long GetAllGold()
        {
            return this.GoldQuantity;
        }

        public List<Gem> GetAllGems()
        {
            return gemsList;
        }

        public List<Cash> GetAllCash()
        {
            return this.cashList;
        }

        public override string ToString()
        {
            string result = null;

            Dictionary<string, long> newSortItems = new Dictionary<string, long>();
            newSortItems.Add("Gold", SumGold());
            newSortItems.Add("Gem", SumAllGems());
            newSortItems.Add("Cash", SumAllCash());
            var tempResult = newSortItems.OrderByDescending(x => x.Value).ToList();
            foreach (var item in tempResult)
            {
                if (item.Key == "Gold")
                {
                    if (this.GoldQuantity!=0)
                    {
                        result += $"<{item.Key}> ${item.Value}\n";
                        result += $"##{item.Key} - {item.Value}\n"; 
                    }

                }
                else if (item.Key == "Gem")
                {
                    if (SumAllGems()!=0)
                    {
                        result += $"<{item.Key}> ${item.Value}\n";
                        var resultGems = gemsList.OrderByDescending(x => x.Name).ToList();
                        foreach (var gem in resultGems)
                        {
                            result += $"##{gem.Name} - {gem.Quantity}\n";

                        } 
                    }
                }
                else if (item.Key == "Cash")
                {
                    if (SumAllCash()!=0)
                    {
                        result += $"<{item.Key}> ${item.Value}\n";
                        var resultCash = cashList.OrderByDescending(x => x.Name).ToList();
                        foreach (var cash in resultCash)
                        {
                            result += $"##{cash.Name} - {cash.Quantity}\n";

                        } 
                    }
                }
            }

            return result;
        }
    }
}
