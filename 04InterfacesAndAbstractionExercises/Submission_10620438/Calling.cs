using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Calling:Icalling
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
                    this.phoneNumber = "Invalid number!";
                    //throw new ArgumentException("Invalid number!");
                }
                else
                {
                    this.phoneNumber = value;

                }

            }
        }

        public string Call()
        {
            if (this.PhoneNumber == "Invalid number!")
            {
                return $"{this.PhoneNumber}\n";
            }
            return $"Calling... {this.PhoneNumber}\n";
        }

    }
}
