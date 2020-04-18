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
    /// Interaction logic for OrderControl.xaml 
    /// Aspects of Zachery Brunner's cowboy cafe solution were used to complete this class.
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {
            ///Initializes the Control Interface.
            InitializeComponent();
           

        }

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
                if (sender is Button)
                {
                    IOrderItem item;
                    FrameworkElement screen = null;
                    var orderControl = this.FindAncestor<OrderControl>();

                    //Cast sender to button
                    Button b = (Button)sender;

                    //Filter which button was pressed based on name
                    switch (b.Name)
                    {
                        case "AddAngryChickenButton":
                            item = new AngryChicken();
                            screen = new AngryChickenCustomization(DataContext);
                            break;
                        case "AddCowpokeChiliButton":
                            item = new CowpokeChili();
                            screen = new CowpokeChiliCustomization(DataContext);
                            break;
                        case "AddDakotaDoubleBurgerButton":
                            item = new DakotaDoubleBurger();
                            screen = new DakotaDoubleCustomization(DataContext);
                            break;
                        case "AddPecosPulledPorkButton":
                            item = new PecosPulledPork();
                            screen = new PecosPulledPorkCustomization(DataContext);
                            break;
                        case "AddRustlersRibsButton":
                            item = new RustlersRibs();
                            break;
                        case "AddTexasTripleBurgerButton":
                            item = new TexasTripleBurger();
                            screen = new TexasTripleCustomization(DataContext);
                            break;
                        case "AddTrailBurgerButton":
                            item = new TrailBurger();
                            screen = new TrailBurgerCustomization(DataContext);
                            break;
                        case "AddBakedBeansButton":
                            item = new BakedBeans();
                            break;
                        case "AddChiliCheeseFriesButton":
                            item = new ChiliCheeseFries();
                            break;
                        case "AddCornDodgersButton":
                            item = new CornDodgers();
                            break;
                        case "AddPandeCampoButton":
                            item = new PanDeCampo();
                            break;
                        case "AddCowboyCoffeeButton":
                            item = new CowboyCoffee();
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "AddJerkedSodaButton":
                            item = new JerkedSoda();
                            screen = new JerkedSodaCustomization(DataContext);
                            break;
                        case "AddTexasTeaButton":
                            item = new TexasTea();
                            screen = new TexasTeaCustomization(DataContext);
                            break;
                        case "AddWaterButton":
                            item = new Water();
                            screen = new WaterCustomization(DataContext);
                            break;
                        default:
                            throw new NotImplementedException("Unknown button clicked");
                    }
                    if (screen != null) screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }
    }
}
