using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public class SlidingWindowStrategy : AbstractStrategy
    {
        public SlidingWindowStrategy(Technology technology) :base(technology, def_p0,def_L,def_Vp,def_Tsh,def_Trsh,def_s,def_r,def_M,def_sigma,def_B)
        {
        }
        public SlidingWindowStrategy(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
            : base(technology, p0, l, Vp, Tsh, Trsh, s, r, m, sigma,B)
        {
        }


    public override int getN()
    {
        return n;
    }
        public override double getT()
    {
        double result;
        //System.out.printf("T=%.10f\n",(getSum()*(1-1/Math.pow(2,r)*(0.5-F((r+1-M)/sigma)))));
        result = (n + s) * 1.0 / C + 2 * L * 1.0 / Vp + Tsh + Trsh + n*1.0* (getSum() * p00() / (1 - getSum())) / C;
        return result;
    }

    
    public override double getB()
    {
        return B;
    }

    
    public override double getP()
    {
        return (1 - getSum()) * (1 - getSum() * Math.Pow(p00(), n)) / (1 - getSum() * p00());
           // (1 - getSum()) / (1 - getSum() * (1 - 1 / Math.Pow(2, r) * (0.5 - F((r + 1 - M) / sigma))));
    }

    
    public override double getWnorm()
    {
        return Wnorm;
    }

    public override double getWeff()
    {
        return Weff;
    }
    private double getSum()
    {
        if (sum < 0)
        {
            double res = 0;
            for (int i = 0; i < n; i++)
            {
                res += (1 - Math.Pow(1 - p0, n + i)) * (F((i + 1 - M) / sigma) - F((i - M) / sigma));
                //System.out.printf("Res=%.20f", F(0.5));
            }
            sum = res;
        }
        //sum=0.999968877;
        //System.out.printf("Sum=%.10f\n",sum);
        return sum;
    }
}

}