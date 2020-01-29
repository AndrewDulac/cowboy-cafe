﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        /// <summary>
        /// The Price of the Texas Triple Burger
        /// </summary>
        public double Price { get { return 6.45; } }
        /// <summary>
        /// The amount of calories in the Texas Triple Burger
        /// </summary>
        public uint Calories { get { return 698; } }
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with a bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with a tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// Whether or not the Texas Triple Burger comes with egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Texas Triple Burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); //initialize the list

                if (!Bun) instructions.Add("hold bread");     // if item is set to false, add hold item to the list
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;    //return the list
            }
        }
    }
}