using EvaluationOfEffectivenessModul.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services
{
    class EvaluationClass
    {
       
        private double getImportanceInformationAsset(long E, double Y)//1
        {
            return E/Y;
        }
        private double getEfficiencyCost(double e, long b)//2
        {
            return e / b;
        }
        private double getSumSingleRiskList(IList<double> p, IList<long> u)//3
        {
            int n = p.Count;
            double res = 0;
            for (int i = 0; i<n;i++)
            {
               res+= p[i] * u[i];
            }
            return res;
        } 
        private double getRisk(Int32 E, Int32 M)//4
        {
            return E / M;
        }
        private double getAgregateRisk(List<double> p, List<long> u, Int32 E, Int32 M)//5
        {
            return getSumSingleRiskList(p, u)+getRisk(E,M);
        }
        public static double getRang(long sum, double p, long cost)//6
        {
            return (sum * p) / cost;
        }
        public static double getCost(double D, long IW)//7
        {
            return D + IW;
        }
        public static double getCoefficientRentabilnosti(ICollection<Investment> invest)//8
        {
            double res = 0;
            int i = 1;
            foreach(Investment item in invest){
                res+=item.cashFlov/Math.Pow((1+item.salesRevenue),i);
                i++;
            }
            return res;
        }
        //private double getDegreeOfRisk()
        

    }
}
