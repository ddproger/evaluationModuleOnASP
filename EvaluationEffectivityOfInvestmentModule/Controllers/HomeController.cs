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
        public ActionResult Index()
        {
            Collection<Intruder> intruders = feelDate();
            
            System.Collections.Generic.Dictionary<String, int> category = new DictionaryWithJsonToString<string, int>("Категория пользователя","Количество угроз");
            System.Collections.Generic.Dictionary<String, int> informationRisks = new Dictionary<string, int>();
            System.Collections.Generic.Dictionary<InformationAssets, long> infActivsInvestments = new Dictionary<InformationAssets, long>();

            
            foreach (Intruder item in intruders)
            {
                if (category.ContainsKey(item.uid.ToString()))
                {
                    int count = category[item.uid.ToString()];
                    category[item.uid.ToString()] = count + 1;
                }
                else
                {
                    category.Add(item.uid.ToString(), 1);
                }
                foreach (InformationRisk risks in item.risk)
                {
                    if (informationRisks.ContainsKey(risks.asset.name))
                    {
                        int count = informationRisks[risks.asset.name];
                        informationRisks[risks.asset.name] = count + 1;
                    }
                    else
                    {
                        informationRisks.Add(risks.asset.name, 1);
                    }
                    if (infActivsInvestments.ContainsKey(risks.asset))
                    {
                        long count = infActivsInvestments[risks.asset];
                        infActivsInvestments[risks.asset] = count + risks.capitalOfExploitation;
                    }
                    else
                    {
                        infActivsInvestments.Add(risks.asset, risks.capitalOfExploitation);
                    }
                }
            }

            ViewBag.intruders = intruders;
            ViewBag.categories = category;
            ViewBag.risks = informationRisks;
            ViewBag.infActivsInvestments = infActivsInvestments;
            return View();
        }
        
        /// <summary>
        /// Need correct this method. Use externals API
        /// </summary>
        /// <returns></returns>
        private Collection<Intruder> feelDate()
        {
            InformationAssets infAssets = new InformationAssets(TypeIA.BT, "Банковская тайна",48854, true, true, false, true, false);
            InformationRisk risk1 = new InformationRisk("Нарушение целосности", infAssets, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 4325, 0.5f);
            InformationRisk risk2 = new InformationRisk("Нарушение аутентичности", infAssets, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 222, 0.6f);
            InformationRisk risk3 = new InformationRisk("Нарушение безопасности", infAssets, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 113, 0.1f);
            InformationAssets infAssets2 = new InformationAssets(TypeIA.BT, "Конфиденциальная информация", 15625, true, true, false, true, false);
            InformationRisk risk4 = new InformationRisk("Нарушение целосности", infAssets2, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 124, 0.5f);
            InformationRisk risk5 = new InformationRisk("Нарушение аутентичности", infAssets2, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 1244, 0.5f);
            InformationRisk risk6 = new InformationRisk("Нарушение безопасности", infAssets2, new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) }, 4325, 0.3f);


            Collection<NetworkObject> netObjects = new Collection<NetworkObject>
            {
                new NetworkObject(LevelHierarchy.BL, "TO1"),
                new NetworkObject(LevelHierarchy.DBL, "TO2"),
                new NetworkObject(LevelHierarchy.DBL, "TO3"),
                new NetworkObject(LevelHierarchy.OSL, "TO4"),
                new NetworkObject(LevelHierarchy.OSL, "TO5"),
                new NetworkObject(LevelHierarchy.BL, "TO6")
            };

            Collection<Intruder> intruders = new Collection<Intruder>
            {
                new Intruder(Category.trusted,new Collection<InformationRisk>{risk1,risk2,risk3},1154,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 1",0.1f },
                                                                         {"Рекомендация 2",0.2f },
                                                                         {"Рекомендация 3",0.5f },
                                                                     }),
                new Intruder(Category.untrusted, new Collection<InformationRisk>{risk2,risk4,risk5,risk3},1512,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 4",0.1f },
                                                                         {"Рекомендация 5",0.2f },
                                                                         {"Рекомендация 6",0.5f },
                                                                     }),
                new Intruder(Category.trusted, new Collection<InformationRisk>{risk5,risk6},784,
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 7",0.1f },
                                                                         {"Рекомендация 8",0.2f },
                                                                         {"Рекомендация 9",0.5f },
                                                                     }),
            };
            return intruders;
        }
    }
}