using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public void MakesChicken()
        {
            Console.WriteLine("The chef makes Chicken");
        }
        public void MakeSalad()
        { }
            public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes special dish");
        }
        }
    }

