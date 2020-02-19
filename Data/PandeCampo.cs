using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan De Campo Side
    /// </summary>
    public class PanDeCampo : Side
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
            sb.Append(" Pan de Campo");
            return sb.ToString();
        }
    }
}
