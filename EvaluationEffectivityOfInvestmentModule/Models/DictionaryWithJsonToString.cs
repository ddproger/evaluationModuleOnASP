using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EvaluationEffectivityOfInvestmentModule.Models
{
    public class DictionaryWithJsonToString<K, V> : Dictionary<K, V>
    {
        private String keyName, valueName;
        public DictionaryWithJsonToString(String keyName, String valueName){
            this.keyName = keyName;
            this.valueName = valueName;
        }
        override public string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[['"+keyName+"', '"+valueName+"']");
            foreach (KeyValuePair<K,V> item in this)
            {
                builder.AppendLine(",");
                builder.Append("['"+item.Key+"', "+item.Value+"]");
            }
            builder.AppendLine("]");
            return builder.ToString();
        }
    }
}