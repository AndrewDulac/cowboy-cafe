﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        /// <summary>
        /// The Price of the Pecos Pulled Pork
        /// </summary>
        public double Price { get { return 5.88; } }
        /// <summary>
        /// The amount of calories in the Pecos Pulled Pork
        /// </summary>
        public uint Calories { get { return 528; } }
        /// <summary>
        /// Whether or not the Pecos Pulled Pork comes with bread
        /// </summary>
        public bool Bread { get; set; } = true;
        /// <summary>
        /// Whether or not the Pecos Pulled Pork comes with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Pecos Pulled Pork
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
