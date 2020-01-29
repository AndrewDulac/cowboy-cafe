﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        /// <summary>
        /// The Price of the Angry Chicken
        /// </summary>
        public double Price { get { return 5.99;  } }
        /// <summary>
        /// The amount of calories in the Angry Chicken
        /// </summary>
        public uint Calories { get { return 190;  } }
        /// <summary>
        /// Whether or not the Angry Chicken comes with bread
        /// </summary>
        public bool Bread { get; set; } = true;
        /// <summary>
        /// Whether or not the Angry Chicken comes with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Angry Chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); //initialize the list

                if (!Bread) instructions.Add("hold bread");     // if item is set to false, add hold item to the list
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;    //return the list
            }
        }
    }
}