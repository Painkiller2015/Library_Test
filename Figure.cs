namespace Library
{
    public class Figure
    {
        public class Circle
        {
            public const double Pi = Math.PI;
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            /// <summary>
            /// Calculating area from radius 
            /// </summary>
            public double GetSizeArea()
            {
                double area = Pi * Math.Pow(Radius, 2);
                return area;
            }

            /// <summary>
            /// Convert Lenght round to round radius
            /// </summary>
            public double LengthToRadius(double length)
            {
                double _radius = length / (2 * Pi);
                return _radius;
            }

            /// <summary>
            /// Convert radius round to length radius
            /// </summary>
            public double RadiusToLenght(double radius)
            {
                double _lenght = 2 * Pi * radius;
                return _lenght;
            }
        }
        public class Triangle
        {
            public double Side1 { get; }
            public double Side2 { get; }
            public double Side3 { get; }
            public bool IsRectangular { get; }

            public Triangle(double side1, double side2, double side3)
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;

                if (Math.Pow(GetHypotenuse(), 2) == Math.Pow(Side1, 1) + Math.Pow(Side2, 2) ||
                    Math.Pow(GetHypotenuse(), 2) == Math.Pow(Side2, 2) + Math.Pow(Side2, 3) ||
                    Math.Pow(GetHypotenuse(), 2) == Math.Pow(Side1, 3) + Math.Pow(Side2, 1))
                {
                    IsRectangular = true;
                }
            }

            /// <summary>
            /// Calculating area from 3 catet on Gerone formul
            /// </summary>
            public double GetSizeArea()
            {
                double area;

                if (IsRectangular)
                {
                    area = (1 / 2) * Side1 * Side2 * Side3 / GetHypotenuse();
                    return area;
                }

                double halfPerimeter = GetPerimeter() / 2;
                area = Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
                return area;
            }

            /// <summary>
            /// Calculating perimeter from 3 catet
            /// </summary>
            public double GetPerimeter()
            {
                double perimeter = Side1 + Side2 + Side3;
                return perimeter;
            }
            public double GetHypotenuse()
            {
                double hypotenuse = Math.Max(Math.Max(Side1, Side2), Side3);
                return hypotenuse;
            }
        }
    }
}