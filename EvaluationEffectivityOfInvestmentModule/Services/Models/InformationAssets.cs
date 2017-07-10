using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public enum TypeIA
    {
        BT,
        PIDm,
        RrD,
        KT,
        StO,
        Ol,
        YI,
        PD
    }
    public class InformationAssets : NetworkEntity
    {
        public TypeIA type { get; set; }
        public bool aConfidentiality { get; set; }
        public bool aAvailability { get; set; }
        public bool aAuthenticity { get; set; }
        public bool aIntegrity { get; set; }
        public bool continuity { get; set; }
        public ICollection<NetworkEntity> networkEntities = new LinkedList<NetworkEntity>();
        public InformationAssets(String name):base(TypeEntity.InformationAssets,name)
        {
        }
        public InformationAssets(TypeIA t, String name, bool aConfidentiality,
                                bool aAvailability, bool aAuthenticity,
                                bool aIntegrity, bool continuity) : base(TypeEntity.InformationAssets,name)
        {
            this.type = t;
            this.aConfidentiality = aConfidentiality;
            this.aAvailability = aAvailability;
            this.aAuthenticity = aAuthenticity;
            this.aIntegrity = aIntegrity;
            this.continuity = continuity;


        }
    }
}
