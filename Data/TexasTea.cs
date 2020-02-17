using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// Whether Ice is in the Drink or not.
        /// </summary>
        public override bool Ice { get; set; } = true;

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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                        return 10;
                    case Size.Medium:
                        return 22;
                    case Size.Large:
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Whether the drink is sweet or not.
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether the drink has a lemon or not.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                var instructions = new List<string>();

                if (!Sweet) instructions.Add("unsweet");
                if (Lemon) instructions.Add("add lemon");
                if (!Ice) instructions.Add("hold ice");

                return instructions;
            }
        }
    }
}
