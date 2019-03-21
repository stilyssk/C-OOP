
namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Smartphone
    {
        private List<Calling> callings;
        private List<Browsing> browsings;

        public Smartphone(string inputCalling, string inputBrowsing)
        {
            this.callings = new List<Calling>();
            this.browsings = new List<Browsing>();
            this.LoadCallingList(inputCalling);
            this.LoadBrowsingList(inputBrowsing);
        }

        public Calling Calling
        {
            set
            {
                this.callings.Add(value); 
            }
        }

        public Browsing Browsing
        {
            set
            {
                this.browsings.Add(value);
            }
        }

        public void LoadCallingList(string inputCalling)
        {
            var listOfCalls = inputCalling
                .Split(new[] { ' ' })
                .ToList();
            foreach (var phoneNumber in listOfCalls)
            {
                //try
                //{
                    var validNumber = new Calling(phoneNumber);
                    //Console.WriteLine(this.PrintCall(validNumber));
                    callings.Add(validNumber);
                //}
                //catch (Exception ex)
                //{
                //    callings.Add(ex.Message);
                //    Console.WriteLine(ex.Message);
                //}
            }
        }

        public void LoadBrowsingList(string inputBrowsing)
        {
            var listOfUrl = inputBrowsing
                .Split(new[] { ' ' })
                .ToList();
            foreach (var phoneNumber in listOfUrl)
            {
                //try
                //{
                    var validUrl = new Browsing(phoneNumber);
                    browsings.Add(validUrl);
                    //Console.WriteLine(this.PrintBrowse(validUrl));
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }
        }

        public string PrintBrowse(Browsing newBrowse)
        {

            return newBrowse.PrintBrowsing();
        }

        public string PrintCalling()
        {
            string result = null;
            foreach (var call in callings)
            {
                result += call.Call();
            }
            return result;
        }

        public string PrintCall(Calling newCall)
        {
            return newCall.Call();
        }

        public string PrintBrowsing()
        {
            string result = null;
            foreach (var url in browsings)
            {
                result += url.PrintBrowsing();
            }
            return result;
        }
    }

}
