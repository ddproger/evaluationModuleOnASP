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
        private Dictionary<TypeIA, float> posibilities = new Dictionary<TypeIA, float>();

        public float possibilityBT { get; set; }
        public float possibilityPIDm { get; set; }
        public float possibilityKrD { get; set; }
        public float possibilityKT { get; set; }
        public float possibilityStO { get; set; }
        public float possibilityOl { get; set; }
        public float possibilityYI { get; set; }
        public float possibilityPD { get; set; }
        public float getPossibility(TypeIA type)
        {
            float value = 0;
            posibilities.TryGetValue(type, out value);
            return value;
        }
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
            posibilities.Add(TypeIA.BT,possibilityBT);
            posibilities.Add(TypeIA.PIDm, possibilityPIDm);
            posibilities.Add(TypeIA.KrD, possibilityKrD);
            posibilities.Add(TypeIA.KT, possibilityKT);
            posibilities.Add(TypeIA.StO, possibilityStO);
            posibilities.Add(TypeIA.Ol, possibilityOl);
            posibilities.Add(TypeIA.YI, possibilityYI);
            posibilities.Add(TypeIA.PD, possibilityPD);
        }
    }
}
