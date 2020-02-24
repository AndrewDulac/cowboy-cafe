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

        /// <summary>
        /// Custom ToString override for Object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            switch (this.Flavor)
            {
                case SodaFlavor.CreamSoda:
                    sb.Append(" Cream Soda");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append(" Orange Soda");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append(" Sarsparilla");
                    break;
                case SodaFlavor.BirchBeer:
                    sb.Append(" Birch Beer");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append(" Root Beer");
                    break;
            }
            sb.Append(" Jerked Soda");
            return sb.ToString();
        }
    }
}
