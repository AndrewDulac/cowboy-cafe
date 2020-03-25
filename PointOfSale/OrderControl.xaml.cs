using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var data = new Order(1);
            DataContext = data;
        }

        /*
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
        */

        /// <summary>
        /// Handler that takes care of completing an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Order o = (Order)this.DataContext;
            this.DataContext = new Order(o.OrderNumber + 1);
        }

        /// <summary>
        /// Handler that takes care of canceling an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Order o = (Order)this.DataContext;
            this.DataContext = new Order(o.OrderNumber + 1);
        }

        /// <summary>
        /// I do not know what this is suppose to do yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
