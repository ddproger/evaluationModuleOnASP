using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public enum AvailableStrategies : int
    {
        ReturnToN = 1,
        SlidingWindow = 2
    }
    public class Strategies
    {
        private Strategies() { }
        public static Strategy newReturnToNStrategies(Technology tech)
        {
            return new ReturnToNStrategy(tech);
        }
        public static Strategy newReturnToNStrategies(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
        {
            return new ReturnToNStrategy(technology,p0,l,Vp,Tsh,Trsh,s,r,m,sigma,B);
        }
        public static Strategy newSlidingWindowStrategies()
        {
            return null;
        }
    }
}