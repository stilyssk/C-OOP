using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList:List<string>
    {

        public string returns()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);
            return this[index];
        }

        public void remove()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);
            this.RemoveAt(index);
        }

        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);
            return this[index];
        }
    }
}
