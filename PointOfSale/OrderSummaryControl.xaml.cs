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
using CowboyCafe.Extensions;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderListView_Selected(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                
                if (sender is ListBox)
                {
                    MessageBox.Show("closer");
                }
                MessageBox.Show("close");
            }
        }

        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
