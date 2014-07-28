using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public abstract class Product
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get{ return _name; }
            set{
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentNullException("Name cannot be null");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (!(value < 0))
                {
                    _price = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number");
            }
        }

    }
}
