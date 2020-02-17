using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Whether Ice is in the Drink or not.
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public override double Price { get; } = 0.12;

        /// <summary>
        /// The amount of calories in the drink.
        /// </summary>
        public override uint Calories { get; } = 0;

        /// <summary>
        /// Whether the drink has a lemon or not.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon) instructions.Add("add lemon");
                if (!Ice) instructions.Add("hold ice");

                return instructions;
            }
        }
    }
}
