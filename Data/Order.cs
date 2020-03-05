using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An order class which holds data summarizing specific details of an Order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private uint lastOrderNumber => 0;

        private List<IOrderItem> items =  new List<IOrderItem>();
        /// <summary>
        /// A group of Order Items that this Order consists of.
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get { return items.ToArray(); }
        }

        private double subtotal;
        public double Subtotal
        {
            get 
            {   
                return subtotal;
            }
            set
            {
                subtotal = value;
            }
        }
                

        public uint OrderNumber => 1;

        public void Add(IOrderItem OrderItem)
        {
            items.Add(OrderItem);
            Subtotal += OrderItem.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem OrderItem)
        {
            items.Remove(OrderItem);
            Subtotal -= OrderItem.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }


    }
}
