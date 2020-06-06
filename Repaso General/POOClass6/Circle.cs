using System;
using System.Collections.Generic;
using System.Text;

namespace POOClass6
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
            base.Draw();
        }
    }
}
