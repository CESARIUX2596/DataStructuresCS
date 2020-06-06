using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace POOClass6
{
    class ItalianCheff : Cheff
    {
        public ItalianCheff()
        {
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Cheff Makes Chicken Parm");
        }
    }
}
