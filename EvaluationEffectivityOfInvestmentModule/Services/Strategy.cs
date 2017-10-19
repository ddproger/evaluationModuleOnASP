using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public interface Strategy
    {        
        int getN();
        double getT();
        double getB();
        double getP();
        double getWnorm();
        double getWeff();
        //default double F(double i)
        //    {
        //        return 0.5 * ErrorFunction.erf(i / 1.4121356237);
        //    }
    }
}
