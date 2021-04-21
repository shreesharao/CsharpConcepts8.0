using System;

namespace CsharpConcepts8._0
{
    class Topic1
    {
        public void Entry()
        {
            var point = new Topic1Point(2, 2);
            //point.X = 2; // This will not compile. readonly field can't be assigned
            point.Y = 2;
            Console.WriteLine($"{new Topic1Point()}");
        }
    }

    public struct Topic1Point
    {
        public Topic1Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Intention is to not allow X to be modified
        public readonly double X;
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}

