﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an Entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gGets the calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
