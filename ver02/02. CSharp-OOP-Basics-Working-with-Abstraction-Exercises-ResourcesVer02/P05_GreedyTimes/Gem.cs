using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Gem : IGem
    {
        private string name;
        private long count;

        //public Gem(string name, long count)
        //{
        //    Name = name;
        //    Count = count;
        //}

        public string Name { get => name; set => name = value; }
        public long Count { get => count; set => count = value; }
    }
}
