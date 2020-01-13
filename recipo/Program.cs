using System;
using System.Collections.Generic;
/*
Recipes, Codecool
Write a program to manage a Recipe list, e.g. model data stored in a recipe with a Recipe class.

[C#]

Recipes should:

have a positive, numeric identifier (ID), which should be unique among recipe object (but this doesn’t need to be enforced, try anyway!).

have a name represented with a string.

a list of ingredients represented with a list of strings (or array of strings for a little extra difficulty).

override the toString/ToString method to create a string representation of their contents.

The recipe class should implement the Clonable or ICloneable interface so that it has a clone/Clone method.

Create a Main/Program class with a main/Main method and create 5 completely different instances of the Recipe class, by using instantiation with the new operator.

Print the instances directly (after creation) using System.out.println/Console.WriteLine.

Then create 3 cloned Recipe.

Clone 3 existing recipe (choose 3 from the 5 created before).

Change the ID, name, and ingredients. Add new ingredients to the existing ones and remove some old ones (be creative).

*/
namespace recipo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Recipe husLeves = new Recipe(5000, "husleves",new List<string> { "hus", "leves" });
            Recipe salata = new Recipe(5001, "salata", new List<string> { "salata", "szoszi" });
            Recipe krumplisTeszta = new Recipe(5002, "krumplisteszta", new List<string> { "krumpli", "teszta" });
            Recipe rantottHus = new Recipe(5003, "rantotthus", new List<string> { "rantott", "hus" });
            Recipe maglyaRakas = new Recipe(5004, "maglyarakas", new List<string> { "maglya", "rakas" });

            Console.WriteLine(husLeves);

            Recipe husosleves =  (Recipe)husLeves.Clone();
            husosleves.Ingredients.Add("alma");

            Console.WriteLine(husosleves);

        }
    }
}
