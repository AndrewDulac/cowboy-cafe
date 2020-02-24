﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree.
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The Price of the Trailburger.
        /// </summary>
        public override double Price { get { return 4.50; } }
        /// <summary>
        /// The amount of calories in the Trailburger.
        /// </summary>
        public override uint Calories { get { return 288; } }
        /// <summary>
        /// Whether or not the Trailburger comes with a bun.
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Whether or not the Trailburger comes with ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Whether or not the Trailburger comes with mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Whether or not the Trailburger comes with a pickle.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Whether or not the Trailburger comes with cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Trailburger.
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
            return "Trail Burger";
        }
    }
}
