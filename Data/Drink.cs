using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        public Size Size { get; set; } = Size.Small;

        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract bool Ice { get; set; }

        public abstract List<string> SpecialInstructions { get; }
    }
}
