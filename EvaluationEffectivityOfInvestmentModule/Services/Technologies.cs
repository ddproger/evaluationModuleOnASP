using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public enum AvailableTechnologies : int
    {
        Ethernet = 1,
        FastEthernet = 2,
        GigabytEthernet = 3,
        TenGbEthernet = 4,
        _40_100_GbEthernet = 5
    }
    public class Technologies
    {
        private Technologies() { }
        public static Technology newTechnology(AvailableTechnologies tech)
        {
            switch (tech)
            {
                case AvailableTechnologies.Ethernet: return newEthernet();
                case AvailableTechnologies.FastEthernet: return newFastEthernet();
                case AvailableTechnologies.GigabytEthernet: return newGigabytEthernet();
                case AvailableTechnologies.TenGbEthernet: return new10GBEthernet();
                case AvailableTechnologies._40_100_GbEthernet: return new40_100GBEthernet();

            }
            return newFastEthernet();
        }
        public static Technology newEthernet()
        {
            return new ImplTechnology(1518, 0.95, 10000000L, 0.006, 1, 3, 216, 0.1875);
        }
        public static Technology newFastEthernet()
        {
            return new ImplTechnology(1518, 0.95, 100000000L, 0.006, 2, 3, 432, 0.3750);

        }
        public static Technology newGigabytEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 1000000000L, 0.006, 3, 3, 864, 0.75);
        }
        public static Technology new10GBEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 10000000000L, 0.006, 4, 3, 1152, 1);
        }
        public static Technology new40_100GBEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 400000000L,0.006, 5, 3, 720, 0.625);
        }

    }
}