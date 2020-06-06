using System;
using System.Collections.Generic;
using System.Text;

namespace POOClass6
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
