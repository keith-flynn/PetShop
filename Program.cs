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
                    if (decimal.TryParse(Console.ReadLine() ?? "0", out decimal result))
                    {
                        catFood.Price = result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price");
                    }

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
            }
        }
    }
}
