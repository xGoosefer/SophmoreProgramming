﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCrafting.Models
{
    
    public class Recipe : IRecipe
    {
        public List<IItem> Ingredients { get; set; }
        public float YieldAmount { get; set; }
        
        public IItem YieldItem { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }

        Random r;

        public Recipe()
        {
            this.Ingredients = new List<IItem>();
            this.YieldItem = new Item();
            this.YieldAmount = 1f;
            this.Name = "Item Name";

            this.Description = "Item Description";
            r = new Random();
        }

        public string About()
        {
            string AboutString = $"Recipe ---------------------------\n";
            AboutString += $"Name:\t\t{this.Name}\n";
            AboutString += $"Desciption:\t\t{this.Description}\n";
            AboutString += $"YieldAmount:\t\t{this.YieldAmount:G}\n";
            AboutString += $"Yield Item:\t\t{this.YieldItem.Name}\n";
            AboutString += $"Yield Item Description:\t\t{this.YieldItem.Description}\n";
            AboutString += $"Ingredients ----------------------------\n";
            foreach ( var ingredient in Ingredients )
            {
                AboutString += ingredient.About();
            }
            return AboutString;
        }

        /// <summary>
        /// Make Recipe returns the Yeild Item id all of the souce items requiremnts if the Ingredients are met
        /// </summary>
        /// <param name="sourceItems">List of source items</param>
        /// <returns>a new Item of type YeildItem</returns>
        /// <exception cref="Exception">Throws and excpetion if the ingredients aren't met</exception>
        public IItem MakeRecipe(List<IItem> sourceItems)
        {
            List<IItem> requiredItems = this.Ingredients.ToList();
            
            foreach (var item in sourceItems)
            {
                IItem FoundItem = new Item();
                foreach (var ri in requiredItems) 
                { 
                    if(item.Name == ri.Name) { FoundItem = ri; break; }
                }
                if(FoundItem != null)
                {
                    requiredItems.Remove(FoundItem);
                }  
            }

            if(requiredItems.Count != 0)
            {
                throw new Exception($"{this.Name} source Items do not make  {YieldItem.Name}");
            }
            return this.ProfitProbability(YieldItem);
        }


        private IItem ProfitProbability(IItem yieldItem)
        {
            int random = r.Next(0, 10);
            int normal = 10;
            int above = 3;
            int rare = 1;
            
            switch (random)
            {
                case var expression when random == rare:
                    //rare
                    yieldItem.Name = "Rare " + this.Name;
                    yieldItem.Description = "Rare " + this.Name;
                    yieldItem.Price += yieldItem.Price * .20m;
                    break;
                case var expression when (random >= above && random <=normal):
                    //above
                    yieldItem.Name = "Good " + this.Name;
                    yieldItem.Description = "Good " + this.Name;
                    yieldItem.Price += yieldItem.Price * .10m;
                    break;
                default:

                    //normal
                    break;
            }
            return yieldItem;
        }
    }
}
