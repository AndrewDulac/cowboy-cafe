using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The Price of the item.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// The Special Instructions for the item.
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
