﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{    /// <summary>
     /// A class representing the Dakota Double Burger entree.
     /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// The Price of the Dakota Double Burger.
        /// </summary>
        public override double Price { get { return 5.20; } }
        /// <summary>
        /// The amount of calories in the Dakota Double Burger.
        /// </summary>
        public override uint Calories { get { return 464; } }
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with a bun.
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with a pickle.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with a tomato.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Whether or not the Dakota Double Burger comes with mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); 
                // Initialize the list.

                if (!Bun) instructions.Add("hold bun");     
                // If item is set to false, add hold item to the list.
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");

                return instructions;    
                // Return the list.
            }
        }

        /// <summary>
        /// Returns name of Object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
