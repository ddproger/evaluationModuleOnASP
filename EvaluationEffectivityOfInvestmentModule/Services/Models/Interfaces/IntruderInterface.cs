using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models.Interfaces
{
    public enum Category
    {
        trusted,
        user,
        untrusted
    }
    public interface IntruderInterface
    {
        Category uid { get; set; }
        INetworkEntity purpose { get; set; }
        long allertTime { get; set; }
        ICollection<IDamage> damages { get; set; }
        IDictionary<String, float> recomendations { get; set; }
        float damagу{ get;}
        float recomendation { get; }
        
    }
}
