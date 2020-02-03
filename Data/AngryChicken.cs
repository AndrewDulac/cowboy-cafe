using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{    /// <summary>
     /// A class representing the Angry Chicken entree.
     /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The Price of the Angry Chicken.
        /// </summary>
        public override double Price { get { return 5.99;  } }
        /// <summary>
        /// The amount of calories in the Angry Chicken.
        /// </summary>
        public override uint Calories { get { return 190;  } }
        /// <summary>
        /// Whether or not the Angry Chicken comes with bread.
        /// </summary>
        public bool Bread { get; set; } = true;
        /// <summary>
        /// Whether or not the Angry Chicken comes with a pickle.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Angry Chicken.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); 
                // Initialize the list.

                if (!Bread) instructions.Add("hold bread");     
                // If item is set to false, add hold item to the list.
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;    
                // Return the list.
            }
        }
    }
}
