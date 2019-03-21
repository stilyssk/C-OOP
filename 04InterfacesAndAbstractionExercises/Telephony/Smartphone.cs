namespace Telephony
{
    using System;
    using System.Linq;

    public class Smartphone
    {
        public Smartphone(string inputCalling, string inputBrowsing)
        {
            this.LoadCallingList(inputCalling);
            this.LoadBrowsingList(inputBrowsing);
        }

        public void LoadCallingList(string inputCalling)
        {
            var listOfCalls = inputCalling
                .Split(new[] { ' ' })
                .ToList();
            foreach (var phoneNumber in listOfCalls)
            {
                try
                {
                    var validNumber = new Calling(phoneNumber);
                    Console.WriteLine(this.PrintCall(validNumber));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void LoadBrowsingList(string inputBrowsing)
        {
            var listOfUrl = inputBrowsing
                .Split(new[] { ' ' })
                .ToList();
            foreach (var phoneNumber in listOfUrl)
            {
                try
                {
                    var validUrl = new Browsing(phoneNumber);                
                    Console.WriteLine(this.PrintBrowse(validUrl));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string PrintBrowse(Browsing newBrowse)
        {
            return newBrowse.PrintBrowsing();
        }

        public string PrintCall(Calling newCall)
        {
            return newCall.Call();
        }
    }
}
