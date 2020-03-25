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

        /// <summary>
        /// The list of the item prices on the currentn order
        /// </summary>
        private List<string> itemPrices;

        /// <summary>
        /// Property to return the list of item prices in the current order 
        /// </summary>
        public IEnumerable<string> ItemPrices 
        { 
            get { return itemPrices.ToArray(); } 
        }

        /// <summary>
        /// Property to get the current order number
        /// </summary>
        public uint OrderNumber { get; private set; }

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

        /// <summary>
        /// Public constructor that initializes the list
        /// </summary>
        /// <param name="i">The current order number</param>
        public Order(uint i)
        {
            items = new List<IOrderItem>();
            itemPrices = new List<string>();
            OrderNumber = i;
        }


        public void Add(IOrderItem OrderItem)
        {
            items.Add(OrderItem);
            string priceOfItem = String.Format("{0:C}", OrderItem.Price);
            itemPrices.Add(priceOfItem);
            Subtotal += OrderItem.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem OrderItem)
        {
            items.Remove(OrderItem);
            string priceOfItem = String.Format("{0:C}", OrderItem.Price);
            itemPrices.Remove(priceOfItem);
            Subtotal -= OrderItem.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
