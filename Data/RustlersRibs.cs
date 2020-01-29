using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {

        /// <summary>
        /// The price of Rustler's Ribs
        /// </summary>
        public double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calories of the Rustler's Ribs
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Special instructions for the preparation of the Rustler's Ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>(); //initialize the list

                return instructions;    //return the list
            }
        }
    }
}
