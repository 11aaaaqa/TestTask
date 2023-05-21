using System;

namespace Mindbox1
{
    public class Triangle : Figure
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        private double halfPerimeter;
        private double squareInSecondDegree;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override double Square() 
        {
            if (firstSide < secondSide+thirdSide && secondSide < firstSide+thirdSide && thirdSide < firstSide + secondSide)
            {
                halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
                squareInSecondDegree = halfPerimeter * (halfPerimeter - firstSide) *
                                       (halfPerimeter - secondSide) * (halfPerimeter - thirdSide); 
            }
            else
            {
                Console.WriteLine("Треугольника с такими сторонами не существует!");
                return 0;
            }
            return Math.Round(Math.Sqrt(squareInSecondDegree),2);

        }

        public bool IsRectangular()
        {
            if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide &&
                thirdSide < firstSide + secondSide)
            {
                if (firstSide > secondSide && firstSide > thirdSide)
                {
                    if (firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide)
                        return true;
                }

                if (secondSide > firstSide && secondSide > thirdSide)
                {
                    if (secondSide * secondSide == firstSide * firstSide + thirdSide * thirdSide)
                        return true;
                }

                if (thirdSide > firstSide && thirdSide > secondSide)
                {
                    if (thirdSide * thirdSide == secondSide * secondSide + firstSide * firstSide)
                        return true;
                }
            }
            else
            {
                Console.WriteLine("Треугольника с такими сторонами не существует!");
            }

            return false;
        }
    }
}
