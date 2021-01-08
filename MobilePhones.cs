namespace MiniProject
{
    class MobilePhones : Electronics
    {
        public MobilePhones(string dateOfBuying, string mobileModel, double mobilePrice, string country)
        {
            buyingDate = dateOfBuying;
            productName = mobileModel;
            price = mobilePrice;
            office = country;


        }
        
    }
}
