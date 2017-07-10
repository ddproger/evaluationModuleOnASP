using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
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
    public interface InformationAssetsInterface : INetworkEntity
    {
        TypeIA type { get; set; }
        bool aConfidentiality { get; set; }
        bool aAvailability { get; set; }
        bool aAuthenticity { get; set; }
        bool aIntegrity { get; set; }
        bool continuity { get; set; }
        ICollection<INetworkEntity> getNetworkEntities();
        void setNetworkEntities(ICollection<INetworkEntity> entities);
    }
}
