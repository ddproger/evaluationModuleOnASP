using EvaluationEffectivityOfInvestmentModule.Services;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Technology technology = Technologies.newFastEthernet();
            double p0 = 0.01;
            double C = 56_000;
            int L = 1_000_000;
            double Vp = 300_000_000;
            double Tsh = 0.01;
            double Trsh = 0.01;
            int s = 32;
            int r = 16;
            int M = 10;
            int sigma = 2;
            double B = 0.001d;
            ReturnToNStrategy strategy = new ReturnToNStrategy(technology, p0, C, L, Vp, Tsh, Trsh, s, r, M, sigma, B);
           Console.WriteLine("T=%.10f\n", strategy.getT());
            Console.WriteLine("P=%.10f\n", strategy.getP());
            //System.out.printf("213=%d\n", strategy.getB());


            double result = (strategy.getN() - strategy.getT()) / strategy.getN() *
                    strategy.getB() *
                    strategy.getP() *
                    strategy.getWeff() *
                    strategy.getWnorm();
            Console.WriteLine(result);
        }
    }
}