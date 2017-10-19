using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public abstract class AbstractStratagy : Strategy
    {
        protected double F(double i)
        {
            return 0.5 * SpecialFunction.erf(i / 1.4121356237);
        }
        public abstract double getB();
        public abstract int getN();
        public abstract double getP();
        public abstract double getT();
        public abstract double getWeff();
        public abstract double getWnorm();
    }
}