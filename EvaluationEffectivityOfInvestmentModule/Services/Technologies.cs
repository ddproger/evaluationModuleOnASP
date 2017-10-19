using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public class Technologies
    {
        private Technologies() { }
        public static Technology newEthernet()
        {
            return new ImplTechnology(1518, 0.95, 0.006, 1, 3, 216, 0.1875);
        }
        public static Technology newFastEthernet()
        {
            return new ImplTechnology(1024, 0.95, 0.006, 2, 3, 432, 0.3750);

        }
        public static Technology newGigabytEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 0.006, 3, 3, 864, 0.75);
        }
        public static Technology new10GBEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 0.006, 4, 3, 1152, 1);
        }
        public static Technology new40_100GBEthernet()
        {
            return new ImplTechnology(1518, 0.9999, 0.006, 5, 3, 720, 0.625);
        }

    }
}