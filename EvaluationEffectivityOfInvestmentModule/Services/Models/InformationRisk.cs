using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public class InformationRisk
    {
        public string name { get; set; }
        public long cost { get; set; }
        public long capitalOfExploitation { get; set; }
        public float significance { get; set; }

        public InformationRisk() { }
        public InformationRisk(string n, long cost, long capital, float s)
        {
            this.name = n;
            this.cost = cost;
            this.capitalOfExploitation = capital;
            this.significance = s;
        }
    }
}
