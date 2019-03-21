namespace Telephony
{
    using System;
    using System.Text.RegularExpressions;

    public class Browsing:Ibrowsing
    {
        private string siteUrl;

        public Browsing(string inputUrl)
        {
            this.SiteUrl = inputUrl;
        }

        public string SiteUrl
        {
            get => this.siteUrl; set
            {
                var isLeterOrSymbol = Regex.Match(value, @"(^[a-zA-Z:\/.]+$)");
                if (!isLeterOrSymbol.Success)
                {
                    this.siteUrl = "Invalid URL!";
                    //throw new ArgumentException("Invalid URL!");
                }
                else
                {
                    this.siteUrl = value;

                }
            }
        }

        public string PrintBrowsing()
        {
            if (this.SiteUrl == "Invalid URL!")
            {
                return $"{this.SiteUrl}\n";

            }
            return $"Browsing: {this.SiteUrl}!\n";
        }
    }
}
