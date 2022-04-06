using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to our all you can eat buffet for $9.99! We only charge extra for coffee! How many people are in your group? Please parties of 6 or fewer.");

            string partysize = Console.ReadLine();
            int num1 = int.Parse(partysize);
            
            int watertotal = 0;

            int coffeetotal = 0;

            double totalprice = 0;

            double priceofbuffet = 9.99;

            double priceofcoffee = 2.00;

           


            if (num1 > 6)
            {
                Console.WriteLine("I'm sorry, we can only seat parties up to six people. Have a nice day!");
            }
            else
            {
                Console.WriteLine("A table for " + num1 + "!" + " Please follow me and take a seat! Let's get everyone a beverage. We have water for free or coffee for $2.00 more.");


                for (int i = 1; i <= num1; i++)
                {
                    Console.WriteLine("Alright, person number " + i + ", water or coffee?");

                    string drinkchoice = Console.ReadLine();
                    totalprice = priceofbuffet + totalprice;




                    if (drinkchoice == "water")
                    {
                        Console.WriteLine("Water, good choice");
                        watertotal++;
                        
                        



                    }
                    else if (drinkchoice == "coffee")
                    {
                        Console.WriteLine("Coffee it is!");
                        coffeetotal++;
                        totalprice = priceofcoffee + totalprice;
                        
                        
                        



                    }
                    else
                    {
                        Console.WriteLine("We don't have that. No drink for you!");





                    }
                }

                

                Console.WriteLine("Ok! So that's " + watertotal + " waters and " + coffeetotal + " coffees. I'll be right back, feel free to grab your food!");




                Console.WriteLine("Here is your bill! The total comes to $ " + totalprice);
            


        }

            }




        }



        }
    


            




        
