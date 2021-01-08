namespace MiniProject
{
    class LaptopComputers : Electronics
    {
        public LaptopComputers (string dateOfBuying, string laptopModel, double priceOfLaptop, string country)
        {
            buyingDate = dateOfBuying;
            productName = laptopModel;
            price = priceOfLaptop;
            office = country;


        }

    }
}
