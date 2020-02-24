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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            ///Initializes the Control Interface.
            InitializeComponent();

            ///Adds event handlers for each button click.
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPandeCampoButton.Click += OnAddPandeCampoButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;

        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPandeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }

        /// <summary>
        /// Sets the operation for each button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

    }
}
