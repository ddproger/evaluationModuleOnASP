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
        public long capitalOfExploitation { get; set; }
        public float significance { get; set; }
        public Boolean active { get; set; }
        public float possibilityBT { get; set; }
        public float possibilityPIDm { get; set; }
        public float possibilityKrD { get; set; }
        public float possibilityKT { get; set; }
        public float possibilityStO { get; set; }
        public float possibilityOl { get; set; }
        public float possibilityYI { get; set; }
        public float possibilityPD { get; set; }

        public InformationRisk() { }
        public InformationRisk(string name,
            float possibilityBT, 
            float possibilityPIDm, 
            float possibilityKrD, 
            float possibilityKT, 
            float possibilityStO, 
            float possibilityOl, 
            float possibilityYI, 
            float possibilityPD)
        {
            this.name = name;
            capitalOfExploitation = 0;
            this.possibilityBT = possibilityBT;
            this.possibilityPIDm = possibilityPIDm;
            this.possibilityKrD = possibilityKrD;
            this.possibilityKT = possibilityKT;
            this.possibilityStO = possibilityStO;
            this.possibilityOl = possibilityOl;
            this.possibilityYI = possibilityYI;
            this.possibilityPD = possibilityPD;
        }
    }
}
