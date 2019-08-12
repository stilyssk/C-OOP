using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    public class Bag : IBag
    {
        private readonly long bagCapacity;
        private List<IGem> gem;
        private long gold;
        private List<ICash> cash;
        private long ocupateBag;

        public Bag(long bagCapacity)
        {
            this.bagCapacity = bagCapacity;
            this.gem = new List<IGem>();
            this.cash = new List<ICash>();
        }

        private long BagCapacity { get => bagCapacity; }
        public List<IGem> Gem
        {
            get => this.gem;
            set
            {
                this.gem = value;
            }
        }
        public List<ICash> Cash
        {
            get => this.cash;
            set
            {
                this.cash = value;
            }
        }
        public long Gold
        {
            get => this.gold;
            set
            {
                if (this.BagCapacity >= this.OcupateBag + value)
                {
                    this.gold = value;
                }
            }
        }

        public long OcupateBag { get => ocupateBag; set => ocupateBag = value; }

        public string PrintResult()
        {
            Dictionary<string, long> resultDict = new Dictionary<string, long>();
            StringBuilder result = new StringBuilder();
            if (PrintGold() != "")
            {
                resultDict.Add(PrintGold(), this.Gold);

            }
            if (PrintGem() != "")
            {
                resultDict.Add(PrintGem(), this.GemsSum());

            }
            if (PrintCash() != "")
            {
                resultDict.Add(PrintCash(), this.CashSum());

            }
            var ordertedByTotal = resultDict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            foreach (var stringResult in ordertedByTotal)
            {
                result.AppendLine(stringResult);
            }
            return result.ToString().TrimEnd();
        }

        private string PrintGold()
        {
            StringBuilder result = new StringBuilder();

            if (this.Gold != 0)
            {
                result.AppendLine($"<Gold> ${this.Gold}");
                result.AppendLine($"##Gold - {this.Gold}");

            }
            return result.ToString().TrimEnd();
        }

        private string PrintGem()
        {
            StringBuilder result = new StringBuilder();
            if (this.Gem.Count > 0)
            {
                result.AppendLine($"<Gem> ${this.GemsSum()}");
                var orderetGems = this.Gem.OrderByDescending(x => x.Name).ThenBy(x => x.Count).ToList();
                foreach (var currentGem in orderetGems)
                {
                    result.AppendLine($"##{currentGem.Name} - {currentGem.Count}");
                }
            }
            return result.ToString().TrimEnd();
        }

        private string PrintCash()
        {
            StringBuilder result = new StringBuilder();

            if (this.Cash.Count > 0)
            {
                result.AppendLine($"<Cash> ${this.CashSum()}");
                var orderedCash = this.Cash.OrderByDescending(x => x.Name).ThenBy(x => x.Count).ToList();
                foreach (var currentCash in orderedCash)
                {
                    result.AppendLine($"##{currentCash.Name} - {currentCash.Count}");
                }
            }
            return result.ToString().TrimEnd();
        }

        private long GemsSum()
        {
            long result = 0;
            foreach (var currentGems in this.Gem)
            {
                result += currentGems.Count;
            }
            return result;
        }

        private long CashSum()
        {
            long result = 0;
            foreach (var currentGems in this.Cash)
            {
                result += currentGems.Count;
            }
            return result;
        }

        public void AddGem(string name, long count)
        {

            var allGems = count + this.GemsSum();
            if (this.BagCapacity >= this.OcupateBag + count)
            {
                if (allGems <= this.Gold)
                {
                    if (!this.Gem.Exists(x => x.Name == name))
                    {
                        IGem newGem = new Gem();
                        newGem.Name = name;
                        newGem.Count = count;
                        this.Gem.Add(newGem);
                        this.OcupateBag += count;
                    }
                    else
                    {
                        int index = this.Gem.FindIndex(x => x.Name == name);
                        this.Gem[index].Count += count;
                        this.OcupateBag += count;
                    }

                }

            }
        }

        public void AddCash(string name, long count)
        {
            var allCash = this.CashSum() + count;
            if (this.BagCapacity >= this.OcupateBag + count)
            {
                if (allCash <= this.GemsSum())
                {
                    if (!this.Cash.Exists(x => x.Name == name))
                    {
                        ICash newCash = new Cash();
                        newCash.Name = name;
                        newCash.Count = count;
                        this.Cash.Add(newCash);
                        this.OcupateBag += count;
                    }
                    else
                    {
                        int index = this.Cash.FindIndex(x => x.Name == name);
                        this.Cash[index].Count += count;
                        this.OcupateBag += count;
                    }
                }
            }

        }
    }
}
