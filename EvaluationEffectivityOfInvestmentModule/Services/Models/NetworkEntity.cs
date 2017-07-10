using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public class NetworkEntity
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
        public TypeEntity type { get; set; }
        public String name { get; set; }
        public IDictionary<NetworkEntity, TypeOfBind> networkEntity;
        public NetworkEntity(TypeEntity type, String name)
        {
            this.name = name;
            this.type = type;
            networkEntity = new Dictionary<NetworkEntity, TypeOfBind>();
        }
        public NetworkEntity(IDictionary<NetworkEntity, TypeOfBind> networkEntity, TypeEntity type)
        {
            this.type = type;
            this.networkEntity = networkEntity;
        }
        public void addBind(TypeOfBind type, NetworkEntity entity)
        {
            networkEntity.Add(entity,type);
        }
    }
}
