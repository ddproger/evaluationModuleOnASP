using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationEffectivityOfInvestmentModule.Services
{
    public interface Technology
    {
        int getN();
        double getP();
        double getT();
        int getV();
        int getCapacity();
        double getWeff();
        double getWnorm();
    }

}
