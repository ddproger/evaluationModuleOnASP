using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
{
    public enum LevelHierarchy{
    OSL = 8,
    DBL = 4,
    BL = 6
    }

    public interface INetworkObject:INetworkEntity
    {
        LevelHierarchy level { get; set; }
        string TO { get; set; }
    }
}
