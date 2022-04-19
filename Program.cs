using System;

namespace Bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2;
            var root = new Bisection();
            root.FindRoot(a, b);
        }
    }
}
