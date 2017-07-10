using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
{
    public enum TypeEntity
    {
        NetworkObject,
        InformationAssets
    }
    public enum TypeOfBind
    {
        cs,
        pt,
        so
    }
    public interface INetworkEntity
    {        
        TypeEntity type { get; set; }
        String name { get; set; }
        IDictionary<NetworkEntity, TypeOfBind> networkEntity { get; set; }
        void addBind(TypeOfBind type, INetworkEntity entity);
    }
}
