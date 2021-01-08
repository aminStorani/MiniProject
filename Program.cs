using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weelcome to Asset Tracking Database ! choose a class of assets for tracking");
            Console.WriteLine("If you want to track LaptopComputers write lap");
            Console.WriteLine("If you want to track MobilePhones write mob");
            Console.WriteLine("If you want to finish tracking and see the list of your tracking result write result");
            List<Electronics> trackingList = new List<Electronics>();
            string assetsInput = Console.ReadLine();
            int i = 0;
            int k = 0;
            string laptopModel;
            string mobileModel;
            DateTime nu = new DateTime();
            nu = DateTime.Now;
            // TimeSpan diff = buy-nu;
            while (assetsInput.ToLower() != "result" && (assetsInput.ToLower() == "lap" || assetsInput.ToLower() == "mob"))
            {
               if (assetsInput.ToLower() == "lap")
                {
                    Console.WriteLine("Write a laptopModel from the list [MacBook, Asus, Lenovo] !");
                    laptopModel = Console.ReadLine();
                    if (laptopModel.ToLower() == "result")
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                    else if (laptopModel == "MacBook" || laptopModel == "Asus" || laptopModel == "Lenovo")
                    {
                        string laptopModel1 = "";
                        while (laptopModel == "MacBook" || laptopModel == "Asus" || laptopModel == "Lenovo")
                        {
                            Console.WriteLine("Write the laptopModel from the same list [MacBook, Asus, Lenovo] !");
                            laptopModel1 = Console.ReadLine();
                            if (laptopModel1.ToLower() == "result")
                            {
                                Console.WriteLine("Wrong input");
                                break;
                            }
                            Console.WriteLine("When did you bought it ?");
                            string dateOfBuying = Console.ReadLine();
                            Console.WriteLine("What was the price ?");
                            double priceOfLaptop = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Where is the office ?");
                            string country = Console.ReadLine();
                            LaptopComputers laptop = new LaptopComputers(dateOfBuying, laptopModel1, priceOfLaptop, country);
                            trackingList.Add(laptop);
                            i++;

                        }
                        laptopModel = laptopModel1;
                        
                    }
                    assetsInput = laptopModel;
               }
               else if (assetsInput.ToLower() == "mob")
                {
                    Console.WriteLine("Write a MobileModel from the list [Iphone, Samsung, Nokia] !");
                    mobileModel = Console.ReadLine();
                    if (mobileModel.ToLower() == "result")
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                    else if (mobileModel == "Iphone " || mobileModel == "Samsung" || mobileModel == "Nokia")
                    {
                        string mobileModel1 = "";
                        while (mobileModel == "Iphone " || mobileModel == "Samsung" || mobileModel == "Nokia")
                        {
                            Console.WriteLine("Write a MobileModel from the same list [Iphone, Samsung, Nokia] !");
                            Console.WriteLine("Write the Mobile model !");
                            mobileModel1 = Console.ReadLine();
                            if (mobileModel1.ToLower() == "result")
                            {
                                Console.WriteLine("Wrong input");
                                break;
                            }
                            Console.WriteLine("When did you bought it ?");
                            string dateOfBuying = Console.ReadLine();
                            Console.WriteLine("What was the price ?");
                            double priceOfMobile = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Where is the office ?");
                            string country = Console.ReadLine();
                            MobilePhones mob = new MobilePhones(dateOfBuying, mobileModel1, priceOfMobile, country);
                            trackingList.Add(mob);
                            k++;
                            
                        }
                        mobileModel = mobileModel1;
                    }
                    assetsInput = mobileModel;

               }
            }
            trackingList = trackingList.OrderBy(Electronics => Electronics.productName).ToList();
            Console.WriteLine("Listing the data.");
            foreach (Electronics assets in trackingList)
            {
                Console.WriteLine($"{assets.productName}\t {assets.buyingDate}\t {assets.price}\t {assets.office}");
                // Console.ReadLine();
            }
        }
    }
}

