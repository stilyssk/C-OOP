namespace Telephony
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Calling : ICalling
    {
        private string phoneNumber;

        public Calling(string inputNumber)
        {
            this.PhoneNumber = inputNumber;
        }

        public string PhoneNumber
        {
            get => this.phoneNumber;
            set
            {
                var isNumber = Regex.Match(value, @"(^[a-zA-Z:\/.]+$)");

                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("Invalid number!");
                }

                this.phoneNumber = value;
            }
        }

        public string Call()
        {
            return $"Calling... {this.PhoneNumber}";
        }
    }
}
