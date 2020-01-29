using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili
    {
        private bool cheese = true;  //uses setter in Cheese property to set status of cheese;  This is where the data is actually stored
        /// <summary>
        /// If the chili is topped with cheese
        /// property for cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; } // returns the value stored in cheese variable
            set { cheese = value; } //sets the value stored in cheese variable
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set { sourCream = value; }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set { greenOnions = value; }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set { tortillaStrips = value; }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); //initialize the list

                if (!cheese) instructions.Add("hold cheese");     // if cheese is set to false, add hold cheese to the list
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;    //return the list
            }
        }
    }
}

