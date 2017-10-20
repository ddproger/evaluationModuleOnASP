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
        public static Strategy newStrategies(AvailableStrategies strategy, Technology technology)
        {
            switch (strategy)
            {
                case AvailableStrategies.ReturnToN: return new ReturnToNStrategy(technology);
                case AvailableStrategies.SlidingWindow: return new SlidingWindowStrategy(technology);
            }
            return new ReturnToNStrategy(technology);
        }
        public static Strategy newStrategies(AvailableStrategies strategy,Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
        {
            switch (strategy)
            {
                case AvailableStrategies.ReturnToN: return new ReturnToNStrategy(technology, p0, l, Vp, Tsh, Trsh, s, r, m, sigma, B);
                case AvailableStrategies.SlidingWindow: return new SlidingWindowStrategy(technology, p0, l, Vp, Tsh, Trsh, s, r, m, sigma, B);
            }
            return new ReturnToNStrategy(technology);
        }
        public static Strategy newReturnToNStrategies(Technology technology)
        {
            return new ReturnToNStrategy(technology);
        }
        public static Strategy newReturnToNStrategies(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
        {
            return new ReturnToNStrategy(technology,p0,l,Vp,Tsh,Trsh,s,r,m,sigma,B);
        }
        public static Strategy newSlidingWindowStrategies(Technology technology)
        {
            return new ReturnToNStrategy(technology);
        }
        public static Strategy newSlidingWindowStrategies(Technology technology, double p0, int l, long Vp, double Tsh, double Trsh, int s, int r, int m, int sigma, double B)
        {
            return new ReturnToNStrategy(technology, p0, l, Vp, Tsh, Trsh, s, r, m, sigma, B);
        }
    }
}