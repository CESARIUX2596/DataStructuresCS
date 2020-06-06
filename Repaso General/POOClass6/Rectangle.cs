using System;
using System.Collections.Generic;
using System.Text;

namespace POOClass6
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}
