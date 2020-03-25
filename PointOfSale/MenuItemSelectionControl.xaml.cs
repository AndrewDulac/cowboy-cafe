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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {
            ///Initializes the Control Interface.
            InitializeComponent();

        }

        /*
        public void OnItemAddButtonClickeD(object sender, RoutedEventArgs e) 
        {
            var orderControl = this.FindAncestor<OrderCtontrol>();
            if(DataContext is Order order)
            {
                if(sender is Button button) 
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                    }
                }
            }
        }
        */

        /// <summary>
        /// This method adds entrees to the list by converting the
        /// sender object to a button and filtering on the name of the button
        /// that was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemToList(object sender, RoutedEventArgs e)
        {
            //Ensure the DataContext is an Order and not NULL
            if (DataContext is Order data)
            {
                //Cast sender to button
                Button b = (Button)sender;

                //Filter which button was pressed based on name
                switch (b.Name)
                {
                    case "AddAngryChickenButton":
                        data.Add(new AngryChicken());
                        break;
                    case "AddCowpokeChiliButton":
                        data.Add(new CowpokeChili());
                        break;
                    case "AddDakotaDoubleBurgerButton":
                        data.Add(new DakotaDoubleBurger());
                        break;
                    case "AddPecosPulledPorkButton":
                        data.Add(new PecosPulledPork());
                        break;
                    case "AddRustlersRibsButton":
                        data.Add(new RustlersRibs());
                        break;
                    case "AddTexasTripleBurgerButton":
                        data.Add(new TexasTripleBurger());
                        break;
                    case "AddTrailBurgerButton":
                        data.Add(new TrailBurger());
                        break;
                    case "AddBakedBeansButton":
                        data.Add(new BakedBeans());
                        break;
                    case "AddChiliCheeseFriesButton":
                        data.Add(new ChiliCheeseFries());
                        break;
                    case "AddCornDodgersButton":
                        data.Add(new CornDodgers());
                        break;
                    case "AddPandeCampoButton":
                        data.Add(new PanDeCampo());
                        break;
                    case "AddCowboyCoffeeButton":
                        data.Add(new CowboyCoffee());
                        break;
                    case "AddJerkedSodaButton":
                        data.Add(new JerkedSoda());
                        break;
                    case "AddTexasTeaButton":
                        data.Add(new TexasTea());
                        break;
                    case "AddWaterButton":
                        data.Add(new Water());
                        break;
                    default:
                        throw new NotImplementedException("Unknown button clicked");
                }
            }
        }

    }
}
