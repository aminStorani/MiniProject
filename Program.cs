using System;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Amin Storani");
        }
    }
    public class LaptopComputers
    {
        public string purchaseDate { get; set; }
        public double price { get; set; }
        public string modelNames { get; set; }
        public LaptopComputers(string purchaseD, double pris, string pruductName)
        {
            purchaseDate = purchaseD;
            price = pris;
            modelNames = pruductName;
        }

    }
    class MobilePhones
    {
        public MobilePhones(string purchaseD, string modelName, double pris)
        {
            PurchaseDate = purchaseD;
            ProductName = modelName;
            Price = pris;

        }
        public string ProductName { get; set; }
        public string PurchaseDate { get; set; }
        public double Price { get; set; }
    }
}
