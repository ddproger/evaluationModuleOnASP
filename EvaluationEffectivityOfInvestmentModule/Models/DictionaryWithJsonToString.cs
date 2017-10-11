using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Models
{
    public class DictionaryWithJsonToString<K,V> : Dictionary<K, V>
    {
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("");
            return base.ToString();
        }

    }
}