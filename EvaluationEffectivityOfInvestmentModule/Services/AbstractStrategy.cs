using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public abstract class AbstractStrategy : Strategy
    {
        public static double def_p0 = 0.01;
        public static int def_L = 1000000;
        public static long def_Vp = 3000000000;
        public static double def_Tsh = 0.01;
        public static double def_Trsh = 0.01;
        public static int def_s = 32;
        public static int def_r = 16;
        public static int def_M = 10;
        public static int def_sigma = 2;
        public static double def_B = 0.001d;
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