namespace TernarySearch
{
    public class TernarySearch
    {
        public double FindMinimum(Func<double, double> function, double left, double right, double epsilon = 1e-9)
        {
            while (right - left > epsilon)
            {
                double m1 = left + (right - left) / 3;
                double m2 = right - (right - left) / 3;

                double f1 = function(m1);
                double f2 = function(m2);

                if (f1 < f2) right = m2;
                else left = m1;
            }

            return (left + right) / 2;
        }

        public double FindMaximum(Func<double, double> function, double left, double right, double epsilon = 1e-9)
        {
            while (right - left > epsilon)
            {
                double m1 = left + (right - left) / 3;
                double m2 = right - (right - left) / 3;

                double f1 = function(m1);
                double f2 = function(m2);

                if (f1 > f2) right = m2;
                else left = m1;
            }

            return (left + right) / 2;
        }

        public double FindMinimumRecursive(Func<double, double> function,  double left, double right, double epsilon = 1e-9)
        {
            if (right - left <= epsilon) return (left + right) / 2;

            double m1 = left + (right - left) / 3;
            double m2 = right - (right - left) / 3;

            if (function(m1) < function(m2)) return FindMinimumRecursive(function, left, m2, epsilon);
            else return FindMinimumRecursive(function, m1, right, epsilon);
        }

        public double FindManimumRecursive(Func<double, double> function, double left, double right, double epsilon = 1e-9)
        {
            if (right - left <= epsilon) return (left + right) / 2;

            double m1 = left + (right - left) / 3;
            double m2 = right - (right - left) / 3;

            if (function(m1) > function(m2)) return FindManimumRecursive(function, left, m2, epsilon);
            else return FindManimumRecursive(function, m1, right, epsilon);
        }
    }
}
