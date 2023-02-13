using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public abstract class Product
    {
        public String name;
        public double price;

        public abstract double computeTax(); // Abstract Method

        public void printInformation()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
        }
    }

    class Book : Product  // inharit Abstract class 
    {
        //Method override
        public override double computeTax()
        {
            return 0.05 * price;
        }
    }

    class Clothing : Product
    {
        //Method override
        public override double computeTax()
        {
            return 0.1 * price;
        }
    }
}
