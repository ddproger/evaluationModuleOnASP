using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public class InformationRisk
    {
        private string pName;
        public string name
        {
            get
            {
                return pName + " на " + asset.name;
            }
            
        }
        public long capitalOfExploitation { get; set; }
        public float significance { get; set; }
        public InformationAssets asset { get; set; }
        public ICollection<Damage> damages { get; set; }

        public InformationRisk() { }
        public InformationRisk(string n, InformationAssets asset, ICollection<Damage> damages , long capital, float s)
        {
            this.pName = n;
            this.asset = asset;
            this.damages = damages;
            this.capitalOfExploitation = capital;
            this.significance = s;
        }
    }
}
