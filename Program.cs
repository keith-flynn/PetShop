using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine() ?? "";

                if (userInput == "1")
                {
                    CatFood catFood = new CatFood();

                    Console.WriteLine("What is the name of the cat food?");
                    catFood.Name = Console.ReadLine() ?? "";

                    Console.WriteLine("What is the price of the cat food?");
                    if (decimal.TryParse(Console.ReadLine() ?? "0", out decimal priceResult))
                    {
                        catFood.Price = priceResult;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price");
                    }

                    Console.WriteLine("How many units to add?");
                    if (int.TryParse(Console.ReadLine() ?? "0", out int quantityResult))
                    {
                        catFood.Quantity = quantityResult;
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity");
                    }

                    Console.WriteLine("Provide a brief product description:");
                    catFood.Description = Console.ReadLine() ?? "";

                    Console.WriteLine("What is the weight of a single unit? (in imperial units of measurement)");
                    if (double.TryParse(Console.ReadLine() ?? "0", out double weightResult))
                    {
                        catFood.WeightPounds = weightResult;
                    }
                    else
                    {
                        Console.WriteLine("Invalid weight");
                    }

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
            }
        }
    }
}
