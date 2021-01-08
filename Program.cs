using System;
using System.Collections.Generic;

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
            List<MobilePhones> mobileTrackingList = new List<MobilePhones>();
            List<LaptopComputers> computerTrackingList = new List<LaptopComputers>();
            string assetsInput = Console.ReadLine();
            while (assetsInput.ToLower() != "result")
            {
               if (assetsInput.ToLower() == "lap")
                {
                    Console.WriteLine("Write the laptop model !");
                    string laptopModel = Console.ReadLine();
                    if (laptopModel.ToLower() == "result")
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                    else if (laptopModel == "MacBook" || laptopModel == "Asus" || laptopModel == "Lenovo")
                    {
                        
                        Console.WriteLine("When did you bought it ?");
                        string dateOfBuying = Console.ReadLine();
                        Console.WriteLine("What was the price ?");
                        double priceOfLaptop = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Where is the office ?");
                        string country = Console.ReadLine();
                        LaptopComputers laptop = new LaptopComputers(dateOfBuying, laptopModel, priceOfLaptop, country);
                        computerTrackingList.Add(laptop);
                       
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                        break;
                    }
                   
                }
                else if (assetsInput.ToLower() == "mob")
                {
                    Console.WriteLine("Write the Mobile model !");
                    string mobileModel = Console.ReadLine();
                    if (mobileModel.ToLower()== "result")
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                   else if (mobileModel == "Iphone " || mobileModel == "Samsung" || mobileModel == "Nokia")
                    {
                        
                        Console.WriteLine("When did you bought it ?");
                        string dateOfBuying = Console.ReadLine();
                        Console.WriteLine("What was the price ?");
                        double priceOfMobile = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Where is the office ?");
                        string country = Console.ReadLine();
                        MobilePhones mob = new MobilePhones(dateOfBuying, mobileModel, priceOfMobile, country);
                        mobileTrackingList.Add(mob);
                    }
                   
                }
               

            }
            foreach (LaptopComputers lab in computerTrackingList)
            {
                Console.WriteLine(lab);

            }
            foreach (MobilePhones mobil in mobileTrackingList)
            {
                Console.WriteLine(mobil);

            }
        }
    }
}

