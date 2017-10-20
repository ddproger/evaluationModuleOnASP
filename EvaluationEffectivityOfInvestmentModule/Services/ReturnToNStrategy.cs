using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public class ReturnToNStrategy : AbstractStrategy
    {
    public ReturnToNStrategy(Technology technology) :base(technology, def_p0,def_L,def_Vp,def_Tsh,def_Trsh,def_s,def_r,def_M,def_sigma,def_B)
    {
    }
    public ReturnToNStrategy(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
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
        result = n * 1.0 / C + L*1.0 / Vp + Tsh + Trsh + ((getSum() * p00()) / (1 - getSum())) * ((n + s) / C * 1.0 + 2 * L*1.0 / Vp);
        return result;
    }

    
    public override double getB()
    {
        return B;
    }

    
    public override double getP()
    {
        return (1 - getSum()) / (1 - getSum() * p00());
    }

    
    public override double getWnorm()
    {
        return Wnorm;
    }

    public override double getWeff()
    {
        return Weff;
    }
    
}

}