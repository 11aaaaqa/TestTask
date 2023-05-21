using System;

namespace Mindbox1
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Square()
        {
            return Math.Round(radius * radius * Math.PI, 2);
        }
    }
}
