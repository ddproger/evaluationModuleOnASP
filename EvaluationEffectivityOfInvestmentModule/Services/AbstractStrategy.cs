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

        protected double p0 = 0d;
        protected int n;
        protected long C;
        protected int L;
        protected long Vp;
        protected double Tsh;
        protected double Trsh;
        protected int s;
        protected int r;
        protected double sum = -1;
        protected int M;
        protected int sigma;
        protected double Wnorm;
        protected double Weff;
        protected double B;
        public AbstractStrategy(Technology tech):this(tech,def_p0,def_L,def_Vp,def_Tsh,def_Trsh,def_s,def_r,def_M,def_sigma,def_B)
        {
        }
        public AbstractStrategy(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
        {
            this.p0 = p0;
            this.n = technology.getN();
            this.Wnorm = technology.getWnorm();
            this.Weff = technology.getWeff();
            this.C = technology.getC();
            this.L = l;
            this.Vp = Vp;
            this.Tsh = Tsh;
            this.Trsh = Trsh;
            this.s = s;
            this.r = r;
            this.M = m;
            this.sigma = sigma;
            this.B = B;
        }

        protected double F(double i)
        {
            return 0.5 * SpecialFunction.erf(i / 1.4121356237);
        }
        protected double p00()
        {
            return (1 - 1 / Math.Pow(2, r) * (0.5 - F((r + 1 - M) / sigma)));
        }
        protected double getSum()
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
        public abstract double getB();
        public abstract int getN();
        public abstract double getP();
        public abstract double getT();
        public abstract double getWeff();
        public abstract double getWnorm();
    }
}