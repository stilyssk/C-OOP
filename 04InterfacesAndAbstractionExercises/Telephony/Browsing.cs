namespace Telephony
{
    using System;
    using System.Text.RegularExpressions;

    public class Browsing : IBrowsing
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
                    throw new ArgumentException("Invalid URL!");
                }

                this.siteUrl = value;
            }
        }

        public string PrintBrowsing()
        {
            return $"Browsing: {this.SiteUrl}!";
        }
    }
}
