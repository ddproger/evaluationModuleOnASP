using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public class Investment
    {
        public static string[] title = {"Денежный поток","Доход от реализации","Период времени"};
        public long cashFlov { get; set; }
        public long salesRevenue { get; set; }
        public string time { get; set; }
        public Investment()
        {
            
        }
        public Investment(long c, long s, string time)
        {
            this.cashFlov = c;
            this.salesRevenue = s;
            this.time = time;
        }
    }
}
