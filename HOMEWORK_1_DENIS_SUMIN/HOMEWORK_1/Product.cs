using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_1
{
    internal class Product
    {
        private string name = "";

        private decimal price = default;

        private int weight = default;
        
        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set
            {
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Product()
        {
            Weight = default;

            Price = default;

            Name = "";
        }

        public Product(string name, decimal price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            string result = "";
            result = string.Format($"Товар {Name} вартує:{Price} грн,та має вагу:{Weight} кг.");
            return result;
        }
    }
}
