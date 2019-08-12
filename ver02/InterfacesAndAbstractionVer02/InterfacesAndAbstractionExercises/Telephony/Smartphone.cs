using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        private string[] numbers;
        private string[] sites;

        public Smartphone(string[] numbers, string[] sites)
        {
            Numbers = numbers;
            Sites = sites;
        }

        public string[] Numbers
        {
            get => numbers;
            set => numbers = value;
        }
        public string[] Sites
        {
            get => sites;
            set => sites = value;
        }

        public string Browsing(string site)
        {

            if (site.All(x => !char.IsDigit(x)))
            {
                return $"Browsing: {site}!";

            }
            return "Invalid URL!";
        }

        public string Calling(string number)
        {
            if (number.All(x => char.IsDigit(x)))
            {
                return $"Calling... {number}";
            }
            return "Invalid number!";
        }


    }
}
