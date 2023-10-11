using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef:Chef
    {
        public void MakesPasta()
        {

            Console.WriteLine("Makes Pasta");
        }
        
        public override void MakeSpecialDish()   //use key word override
        {
            Console.WriteLine("The chef makes Italianspecials");
        }
        //this class inheeits from superclass
    }
}
