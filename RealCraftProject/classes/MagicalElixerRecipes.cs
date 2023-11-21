using RealCraftProject.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleAppCrafting.Models
{
    internal class MagicalElixerRecipes
    {
        List<Recipe> recipes;

        public List<Recipe> Recipes
        {
            get { return recipes; }
        }

        public MagicalElixerRecipes()
        {
            recipes = this.LoadRecipes();
        }


        public virtual List<Recipe> LoadRecipes()
        {
            //Ingredients
            IItem freshHerbs = new Item() { Name = "Fresh Herbs", Description = "Natural herbs with a slight healing property." };
            IItem metalSlime = new Item() { Name = "Metallic Slime", Description = "A piece of liquid metal harvested from one of the thoughest slimes." };
            IItem redStrand = new Item() { Name = "Horse's Red Hair", Description = "A strand of hair retrieved from the mighty red horse." };
            IItem silverFeather = new Item() { Name = "Silver Feather", Description = "A feather plucked from the rare silver birds." };
            IItem dragonEye = new Item() { Name = "Dragon Eye", Description = "A trophy brought home from whatever warriors survived that dreaded encounter." };

            IItem rejuvinatingElixer = new Elixer() { Name = "Rejuvinating Elixer", Description = "Turns things Yellow", Price=1, ElixerName ="Yellow"};
            IItem adrenalineElixer = new Elixer() { Name = "Elixer of Adrenaline", Description = "Turns things Red", Price = 1, ElixerName = "Red" };
            IItem lightfootElixer = new Elixer() { Name = "Lightfoot Elixer", Description = "Turns things Blue", Price = 1, ElixerName = "Blue" };
            IItem blissElixer = new Elixer() { Name = "Elixer of Bliss", Description = "Turns things Green" , Price = 2.5m, ElixerName = "Green" };
            IItem goldenElixer = new Elixer() { Name = "Golden Warrior's Elixer", Description = "Turns things purple" , Price = 2.5m, ElixerName = "Purple" };

            //Recipes
            Recipe rejuvinatingElixerRecipe = new Recipe()
            {
                Description = "",
                Name = "Rejuvinating Elixer",
                Ingredients = new List<IItem> {
                    freshHerbs, metalSlime
                },
                YieldAmount = 1,
                YieldItem = rejuvinatingElixer,
            };

            Recipe adrenalineElixerRecipe = new Recipe()
            {
                Description = "Red Elixer",
                Name = "Elixer of Adrenaline",
                Ingredients = new List<IItem> {
                    metalSlime, redStrand
                },
                YieldAmount = 1,
                YieldItem = adrenalineElixer
            };

            Recipe lightfootElixerRecipe = new Recipe()
            {
                Description = "",
                Name = "Lightfoot Elixer",
                Ingredients = new List<IItem> {
                    freshHerbs, silverFeather
                },
                YieldAmount = 1,
                YieldItem = lightfootElixer
            };


            Recipe blissElixerRecipe = new Recipe()
            {
                Description = "",
                Name = "Bliss Elixer Recipe",
                Ingredients = new List<IItem> {
                    dragonEye, silverFeather
                },
                YieldAmount = 1,
                YieldItem = blissElixer
            };

            Recipe goldenElixerRecipe = new Recipe()
            {
                Description = "",
                Name = "Golden Warrior Elixer Recipe",
                Ingredients = new List<IItem> {
                    rejuvinatingElixer, adrenalineElixer, lightfootElixer, dragonEye
                 },
                YieldAmount = 1,
                YieldItem = goldenElixer
            };

            List<Recipe> recipes = new List<Recipe>()
            {
                 rejuvinatingElixerRecipe, adrenalineElixerRecipe, lightfootElixerRecipe, blissElixerRecipe, goldenElixerRecipe
            };

            return recipes;
        }

        internal string About()
        {
            string strAbout = string.Empty;
            foreach (Recipe recipe in recipes) 
            {
                strAbout += recipe.About();
            }
            return strAbout;
        }
    }
}
