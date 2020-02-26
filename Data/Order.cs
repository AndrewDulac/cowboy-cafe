using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An order class which holds data summarizing specific details of an Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// A group of Order Items that this Order consists of.
        /// </summary>
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public void Add(IOrderItem OrderItem)
        {

        }

        public void Remove(IOrderItem OrderItem)
        {

        }


    }
}
