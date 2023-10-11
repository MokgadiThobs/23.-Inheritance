using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class food
    {
        static void Main(string[] args)
        {
            // have a class be able to inherit characteristics of another
            //c can have a superclass and oher subclasses

            Chef chef = new Chef(); // The chef object
            chef.MakesChicken();


            ItalianChef chef1 = new ItalianChef();
            chef1.MakesChicken();
            chef1.MakesPasta();
            chef1.MakeSpecialDish();

            //freeze
            Console.ReadLine();

        }
    }
}
