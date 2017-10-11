using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public enum Category
    {
        trusted,
        user,
        untrusted
    }
    public class Intruder
    {
        public Category uid { get; set; }
        public long allertTime { get; set; }
        public ICollection<InformationRisk> risk { get; set; }

        public IDictionary<String, float> recomendations { get; set; }
        public long damage
        {
            get
            {
                long damage = 0;
                foreach (InformationRisk riskItem in risk)
                {
                    foreach (Damage item in riskItem.damages)
                    {
                        damage += item.damage;
                    }
                }
                return damage;
            }
        }
        public float hazardLevel
        {
            get
            {
                float level = 0;
                foreach (InformationRisk riskItem in risk)
                {
                    foreach (Damage item in riskItem.damages)
                    {
                        level += item.getWeightedMetric();
                    }
                }
                return level;
            }
        }
        public float recomendation
        {
            get
            {
                float metric = 0;
                foreach (KeyValuePair<String, float> item in recomendations)
                {
                    metric += item.Value;
                }
                return metric;
            }
        }
        
        public Intruder(Category uid, ICollection<InformationRisk> risk, long allertTime, IDictionary<String, float> recomendations)
        {
            this.uid = uid;
            this.risk = risk;
            this.allertTime = allertTime;
            this.recomendations = recomendations;
        }
    }
}
