using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
{
    public interface InvestmentInterface
    {
        long cashFlov { get; set; }
        long salesRevenue { get; set; }
        string time { get; set; }
    }
}
