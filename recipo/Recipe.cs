using System;
using System.Collections.Generic;
using System.Text;

namespace recipo
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public Recipe(int iD, string name, List<string> ingredients)
        {
            this.ID = iD;
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public object Clone()
        {
            Recipe recipe = (Recipe)this.MemberwiseClone();
            return recipe;
        }

        public override string ToString()
        {
            Console.WriteLine("The ingredients are:");
            foreach (var item in Ingredients)
            {
                Console.WriteLine(item);
            }
            return "ID: " + ID + " Name: " + Name;
        }
    }
}

   

