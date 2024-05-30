namespace AreaCalculators.Implementation
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be over 0.");
            }
            Radius = radius;
        }
        public double Radius { get; }

        /// <summary>
        /// Calculates circle area by radius.
        /// </summary>
        /// <returns>Circle area</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
