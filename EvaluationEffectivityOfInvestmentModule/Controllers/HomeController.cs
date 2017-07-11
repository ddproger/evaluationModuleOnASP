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
            ViewBag.intruders = feelDate();
            return View();
        }
        /// <summary>
        /// Need correct this method. Use externals API
        /// </summary>
        /// <returns></returns>
        private Collection<Intruder> feelDate()
        {
            InformationAssets infAssets = new InformationAssets(TypeIA.BT, "infAsset1", true, true, false, true, false);
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
                new Intruder(Category.trusted, infAssets,1000,new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,10002),
                                                                     new Damage(0.516f,0.3f,10002),
                                                                     new Damage(0.3f,0.3f,102132) },
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 1",0.1f },
                                                                         {"Рекомендация 2",0.2f },
                                                                         {"Рекомендация 3",0.5f },
                                                                     }),
                new Intruder(Category.untrusted, infAssets,784,new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f,29384),
                                                                     new Damage(0.6f,0.3f,24841),
                                                                     new Damage(0.3f,0.3f,23331) },
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 4",0.1f },
                                                                         {"Рекомендация 5",0.2f },
                                                                         {"Рекомендация 6",0.5f },
                                                                     }),
                new Intruder(Category.trusted, infAssets,589,new Collection<Damage>{
                                                                     new Damage(0.1f,0.4f,756583),
                                                                     new Damage(0.39f,0.4f,88843),
                                                                     new Damage(0.15f,0.2f,342113) },
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