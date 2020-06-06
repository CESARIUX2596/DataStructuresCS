using System;
using System.Collections.Generic;
using System.Text;

namespace POOClass6
{
    class Cheff
    {
        public Cheff()
        {

        }
        public void MakeChicken()
        {
            Console.WriteLine("Cheff Makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("Cheff Makes Salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Cheff Makes BBQ Ribs");
        }
    }
}
