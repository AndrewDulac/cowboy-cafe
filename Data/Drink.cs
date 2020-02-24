using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Public Drink class object
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Enum property to hold the size of the Drink.
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Price property for Drink.
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in the Drink.
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Whether the Drink has ice or not.
        /// </summary>
        public abstract bool Ice { get; set; }
        /// <summary>
        /// Special instructions for the Drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
