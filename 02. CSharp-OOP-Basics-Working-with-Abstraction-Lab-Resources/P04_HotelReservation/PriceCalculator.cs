namespace P04_HotelReservation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    //using System.Linq;

    public class PriceCalculator
    {
        private double pricePerDay;
        private int numberOfDays;
        private double seasonMultiply;
        private double discountTypeMultiply;
        public PriceCalculator(string[] inputCommand)
        {
            this.PricePerDay = double.Parse(inputCommand[0]);
            this.NumberOfDays = int.Parse(inputCommand[1]);
            this.SeasonMultiply = inputCommand[2];
            if (inputCommand.Length >3)
            {
                this.DiscountTypeMultiply = inputCommand[3];
            }
            else
            {
                this.DiscountTypeMultiply = null;
            }
        }

        enum Season
        {
            Autumn=1,
            Spring=2,
            Winter=3,
            Summer=4
        }

        enum DiscountType
        {
            VIP=20,
            SecondVisit=10,
            None=0
        }

        public double PricePerDay
        {
            get => this.pricePerDay;
            set => this.pricePerDay = value;
        }

        public int NumberOfDays
        {
            get => this.numberOfDays;
            set => this.numberOfDays = value;
        }

        public string SeasonMultiply
        {
            set
            {
                Season season = new Season();
                Enum.TryParse(value, out season);
                this.seasonMultiply = (int)season;
            }
        }
        public string DiscountTypeMultiply
        {
            set
            {
                if (value == null)
                {
                    this.discountTypeMultiply = 1;
                }
                else
                {
                    DiscountType discountType = new DiscountType();
                    Enum.TryParse(value, out discountType);
                    this.discountTypeMultiply = 1-(int)discountType/100.0;
                }
            }
        }

        public double Print()
        {
            return this.numberOfDays*this.PricePerDay*this.seasonMultiply*this.discountTypeMultiply;
        }
    }
}
