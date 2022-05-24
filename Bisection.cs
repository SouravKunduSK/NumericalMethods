using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    public class Bisection
    {
        public double acc = 0.0001;
        public double c;
        public int i = 0;

        public double normResult = 1;

        public double Func(double x)
        {
            return x * x * x - 1;
        }

        public void FindRoot(double a, double b)
        {
            if(a<b && Func(a)*Func(b)<0)
            {
                while(true)
                {
                   i+= 1;
                    c = (a + b) / 2;
                    if(Math.Abs(Func(c))<=acc)
                    {
                        Console.WriteLine("Root = {0:0.0000}", c);
                        break;
                    }
                    else
                    {
                        if(Func(a)*Func(c)<0)
                        {
                            b = c;
                        }
                        else
                        {
                            a = c;
                        }
                    }
                }

                double error = Math.Abs(((normResult - c) / normResult) * 100);
                Console.WriteLine("Total iteration = {0}", i);
                Console.WriteLine("Total error = {0:0.0}%", error);
            }
        }


    }
}
