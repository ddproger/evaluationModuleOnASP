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
        public NetworkEntity purpose { get; set; }
        public long allertTime { get; set; }
        public ICollection<Damage> damages { get; set; }
        public IDictionary<String, float> recomendations { get; set; }
        public long damage
        {
            get
            {
                long damage = 0;
                foreach (Damage item in damages)
                {
                    damage += item.damage;
                }
                return damage;
            }
        }
        public float hazardLevel
        {
            get
            {
                float level = 0;
                foreach (Damage damage in damages)
                {
                    level += damage.getWeightedMetric();
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
        
        public Intruder(Category uid, NetworkEntity purpose, long allertTime, ICollection<Damage> damages, IDictionary<String, float> recomendations)
        {
            this.uid = uid;
            this.purpose = purpose;
            this.allertTime = allertTime;
            this.damages = damages;
            this.recomendations = recomendations;
        }
    }
}
