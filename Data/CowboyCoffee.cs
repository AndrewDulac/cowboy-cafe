using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Whether Ice is in the Drink or not.
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public override double Price 
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The amount of calories in the drink.
        /// </summary>
        public override uint Calories 
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Whether the drink  has cream or not.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether the drink  has cream or not.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (RoomForCream) instructions.Add("Room for Cream");
                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }
        }
    }
}
