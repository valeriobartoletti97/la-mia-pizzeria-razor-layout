﻿namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public Pizza (string name, string description, string image, decimal price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }

    
}
