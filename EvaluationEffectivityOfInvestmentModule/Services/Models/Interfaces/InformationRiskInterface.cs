using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
{
    public interface InformationRiskInterface
    {
        string name { get; set; }
        long cost { get; set; }
        long capitalOfExploitation { get; set; }
        float significance { get; set; }        
    }
}
