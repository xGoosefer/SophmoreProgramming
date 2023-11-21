using ConsoleAppCrafting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCraftProject.classes
{
    class Vendor : Person
    {
        List<Elixer> Elixers;
        List<Item> ingredients;
        List<Recipe> recipes;
        MagicalElixerRecipes fcrecipes;
        public Vendor()
        {
            Elixers = new List<Elixer>()
            {
                new Elixer() { Name = "Yellow Elixer", Description = "Turns things Yellow" },
                new Elixer() { Name = "Red Elixer", Description = "Turns things Red" },
                new Elixer() { Name = "Blue Elixer", Description = "Turns things Blue" },
                new Elixer() { Name = "Green Elixer", Description = "Turns things Green" },
                new Elixer() { Name = "Purple Elixer", Description = "Turns things purple" }

            };
            ingredients = new List<Item>()
            {
                //Ingredients
                new Item() { Name = "Yellow Elixering", Description = "Yellow stuff" },
                new Item() { Name = "Red Elixering", Description = "Red stuff" },
                new Item() { Name = "Blue Elixering", Description = "Blue stuff" }
            };
            fcrecipes = new MagicalElixerRecipes();
            recipes = fcrecipes.Recipes;
        }

        public List<IItem> GetElixerList()
        {
            return this.Elixers.ToList<IItem>();
        }

        public IItem GetElixer(string ItemName)
        {
            var Elixer = (IItem)this.Elixers.Select(i => i.Name.Contains(ItemName));
            if (Elixer != null)
            {
                return Elixer;
            }
            throw new Exception($"Elixer {ItemName} not found");
        }

        public List<IRecipe> GetRecipeList()
        {
            return this.recipes.ToList<IRecipe>();
        }

        public IRecipe GetRecipe(string RecipeName)
        {
            var recipe = this.recipes.Where(i => i.Name.Contains(RecipeName)).FirstOrDefault<IRecipe>();
            if (recipe != null)
            {
                return recipe;
            }
            throw new Exception($"Recipe {RecipeName} not found");
        }

        public List<IItem> GetItemList()
        {
            return this.ingredients.ToList<IItem>();
        }

        public IItem GetItem(int Index)
        {
            return this.ingredients[Index];
        }



        public IItem GetItem(string ItemName)
        {
            var item = this.ingredients.Where(i => i.Name == ItemName).FirstOrDefault<IItem>();
            if (item != null)
            {
                return item;
            }
            throw new Exception($"Ingretient {ItemName} not found");
        }

    }
}

