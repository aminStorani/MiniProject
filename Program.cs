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

/*
while (true)

{

    Console.Write("Input category: ");

    categoryInput = Console.ReadLine();

    if (categoryInput.ToLower() == "q")

    {

        break;

    }



    //Reading input for product and break first while loop if 'q' 

    Console.Write("Input product: ");

    productInput = Console.ReadLine();

    if (productInput.ToLower() == "q")

    {

        break;

    }



    //second while loop 

    while (true)

    {

        //Reading input for category and breaking second while loop if 'q' 

        Console.Write("Input the price: ");

        priceInput = Console.ReadLine();

        if (priceInput.ToLower() == "q")

        {

            break;

        }

        else

        {

            //Check if input is an integer otherwise print error message 

            //and continue second while loop 

            if (int.TryParse(priceInput, out price) == false)

            {

                Console.WriteLine("Add Price like 123, no decimals allowed.");

                continue;

            }

            break;

        }

    }



    //Break first while loop if 'q' was pressed for price inside second while loop 

    if (priceInput.ToLower() == "q")

    {

        break;

    }



    //Add items to list 

    itemList.Add(new Item(categoryInput, productInput, price));

}

//Create Header 

Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price".PadRight(20));



//Create Header PadRight 

//Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price".PadLeft(20)); 



//Sort item list 

itemList = itemList.OrderBy(item => item.Price).ToList();



//loop through item list and print to Console 

foreach (Item item in itemList)

{

    Console.WriteLine(item.Category.PadRight(20) + item.Product.PadRight(20) + item.Price.ToString().PadLeft(20));

}

//Calculate sum of price 

int sum = itemList.Sum(item => item.Price);



//Print summary 

Console.WriteLine("Sum: " + sum);



//Print summary of price with PadRight  

//Console.WriteLine("Sum: ".PadLeft(60 - (sum.ToString().Length + 2)) + sum.ToString().PadLeft(sum.ToString().Length+2)); 



Console.ReadLine(); 

        } 

    } */