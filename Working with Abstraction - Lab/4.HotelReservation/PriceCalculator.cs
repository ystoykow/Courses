namespace _4.HotelReservation
{
    using System;

    public class PriceCalculator
    {
        private int nights;
        private decimal pricePerNight;
        private Seasons season;
        private Discount discount;


        public PriceCalculator(string[] input)
        {
            this.pricePerNight = decimal.Parse(input[0]);
            this.nights = int.Parse(input[1]);
            this.season = Enum.Parse<Seasons>(input[2]);
            this.discount = 0;
            if (input.Length > 3)
            {
                this.discount = Enum.Parse<Discount>(input[3]);
            }
        }

        public decimal GetPrice()
        {
            return this.nights * this.pricePerNight * (int)this.season * (1-((decimal)this.discount/100));
        }
    }
}
