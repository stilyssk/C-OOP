using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Gem
    {
        private string name;
        private long quantity;

        public Gem()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public long Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }


    }
}
