using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Whether Ice is in the Drink or not.
        /// </summary>
        public override bool Ice { get; set; } = true;

        public SodaFlavor Flavor { get; set; }

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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }


        /// <summary>
        /// Special instructions for the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            sb.Append(' ');
            sb.Append(this.Flavor);
            return sb.ToString();
        }
    }
}
