using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representnig the Chili Cheese Fries side.
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// overrides the ToString to give a better description of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            sb.Append(" Chili Cheese Fries");
            return sb.ToString();
        }
    }
}
