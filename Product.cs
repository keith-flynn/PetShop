﻿namespace PetShop
{
    internal class Product
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = "";
    }

    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; } = "";
    }
}
