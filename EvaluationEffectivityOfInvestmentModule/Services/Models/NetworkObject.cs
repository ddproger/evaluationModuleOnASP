using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public enum LevelHierarchy{
    OSL = 8,
    DBL = 4,
    BL = 6
    }
    public class NetworkObject:NetworkEntity
    {
        public LevelHierarchy level { get; set; }
        public string TO { get; set; }
        
        public NetworkObject(LevelHierarchy l, String t) : base(TypeEntity.InformationAssets,t)
        {
            this.level = l;
            this.TO = t;
        }
    }
}
