namespace AreaCalculators.Implementation
{
    public class Triangle : Shape
    {
        public Triangle(
            double sideA,
            double sideB,
            double sideC)
        {
            if (sideA <= 0 ||
                sideB <= 0 ||
                sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Three sides must be over 0.");
            }

            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The provided sides do not form a valid triangle.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Calculates triangle area by three sides (the Geron theorem).
        /// </summary>
        /// <returns>Triangle area</returns>
        public override double CalculateArea()
        {
            double halfP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }

        /// <summary>
        /// Check if triangle is right.
        /// </summary>
        /// <returns>true if triangle is right, otherwise false </returns>
        public bool CheckIsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            double hypotenuse = sides.Max();
            double[] legs = sides.Where(side => side != hypotenuse).ToArray();

            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(legs[0],2) + Math.Pow(legs[1], 2))) < 1e-10;
        }

        /// <summary>
        /// Check if triangle is valid.
        /// </summary>
        /// <param name="sideA">First side of triangle</param>
        /// <param name="sideB">Second side of triangle</param>
        /// <param name="sideC">Third side of triangle</param>
        /// <returns>true - if triangle is valid, otherwise false </returns>
        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB;
        }
    }
}
