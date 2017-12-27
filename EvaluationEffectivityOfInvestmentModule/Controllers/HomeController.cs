using EvaluationEffectivityOfInvestmentModule.Models;
using EvaluationEffectivityOfInvestmentModule.Services;
using EvaluationOfEffectivenessModul.Services.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluationEffectivityOfInvestmentModule.Controllers
{
    public class HomeController : Controller
    {
        Collection<InformationAssets> assets;
        Collection<InformationRisk> risks;
        Collection<Intruder> intruders;
        public ActionResult Index()
        {
            feelDate();
            ViewBag.assets = assets;
            ViewBag.risks = risks;
            if (Request.QueryString["calculate"] != null) addAnalyticDate();
            return View();
        }
        private void addAnalyticDate()
        {
            long cost, investment;
            long profit;
            long.TryParse(Request.QueryString["profit"], out profit);
            long.TryParse(Request.QueryString["remedies"], out cost);
            long.TryParse(Request.QueryString["investments"], out investment);

            long allCost = profit * cost / 100;
            long allInvestment = allCost * investment / 100;
            Int32 percent = 0;
            foreach (InformationAssets asset in assets)
            {
                Int32.TryParse(Request.QueryString["cost_" + asset.type], out percent);
                asset.cost = percent * allCost;
                asset.investment = percent * allInvestment;
            }
        }
        private void addDate(Collection<Intruder> intruders, Dictionary<string, int> category, Dictionary<string, int> informationRisks, Dictionary<InformationAssets, long> infActivsInvestments)
        {
            
        }

        /// <summary>
        /// Need correct this method. Use externals API
        /// </summary>
        /// <returns></returns>
        private void feelDate()
        {
            assets = new Collection<InformationAssets>
            {
                new InformationAssets(TypeIA.BT, "Банковская тайна", true, true, false, true, false),
                new InformationAssets(TypeIA.KT, "Комерческая тайна", true, true, false, true, false),
                new InformationAssets(TypeIA.Ol, "Общедоступная информация", true, true, false, true, false),
                new InformationAssets(TypeIA.PD, "Персональные данные", true, true, false, true, false),
                new InformationAssets(TypeIA.PIDm, "Платежные документы,", true, true, false, true, false),
                new InformationAssets(TypeIA.KrD, "Кредитные документы", true, true, false, true, false),
                new InformationAssets(TypeIA.StO, "Статические отчеты", true, true, false, true, false),
                new InformationAssets(TypeIA.YI, "Управляющая информация", true, true, false, true, false)
            };
            InformationRisk risk1 = new InformationRisk("02.03.01.05", 0.268f, 0.268f, 0.268f, 0.268f, 0.241f, 0.153f, 0.241f, 0.268f);
            InformationRisk risk2 = new InformationRisk("03.03.03.04", 0.332f, 0.332f, 0.332f, 0.332f, 0.166f, 0.066f, 0.166f, 0.332f);
            InformationRisk risk3 = new InformationRisk("03.03.02.03", 0.332f, 0.332f, 0.332f, 0.332f, 0.249f, 0.166f, 0.249f, 0.332f);

            risk1.active = true;
            risk2.active = true;
            risk3.active = true;

            risks = new Collection<InformationRisk>
            {
                risk1,risk2,risk3
            };


            Collection<NetworkObject> netObjects = new Collection<NetworkObject>
            {
                new NetworkObject(LevelHierarchy.BL, "TO1"),
                new NetworkObject(LevelHierarchy.DBL, "TO2"),
                new NetworkObject(LevelHierarchy.DBL, "TO3"),
                new NetworkObject(LevelHierarchy.OSL, "TO4"),
                new NetworkObject(LevelHierarchy.OSL, "TO5"),
                new NetworkObject(LevelHierarchy.BL, "TO6")
            };

            intruders = new Collection<Intruder>
            {
                new Intruder(Category.trusted,new Collection<InformationRisk>{risk1,risk2,risk3},1154,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 1",0.1f },
                                                                         {"Рекомендация 2",0.2f },
                                                                         {"Рекомендация 3",0.5f },
                                                                     }),
                new Intruder(Category.untrusted, new Collection<InformationRisk>{risk2,risk3},1512,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 4",0.1f },
                                                                         {"Рекомендация 5",0.2f },
                                                                         {"Рекомендация 6",0.5f },
                                                                     }),
                new Intruder(Category.trusted, new Collection<InformationRisk>{risk3},784,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 7",0.1f },
                                                                         {"Рекомендация 8",0.2f },
                                                                         {"Рекомендация 9",0.5f },
                                                                     }),
            };
        }
    }
}