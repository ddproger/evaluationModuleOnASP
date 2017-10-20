using EvaluationEffectivityOfInvestmentModule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluationEffectivityOfInvestmentModule.Controllers
{
    public class NetworkController : Controller
    {
        // GET: Network
        public ActionResult Index()
        {
            Technology technology = Technologies.newFastEthernet();

            string str_technology = Request.QueryString["technology"];
            string str_p0= Request.QueryString["p0"];
            string str_C = Request.QueryString["C"];
            string str_L = Request.QueryString["L"];
            string str_Vp = Request.QueryString["Vp"];
            string str_Tsh = Request.QueryString["Tsh"];
            string str_Trsh = Request.QueryString["Trsh"];
            string str_s = Request.QueryString["s"];
            string str_r = Request.QueryString["r"];
            string str_m = Request.QueryString["m"];
            string str_sigma = Request.QueryString["sigma"];
            string str_B = Request.QueryString["B"];

            double p0, Tsh, Trsh, B;
            int L, s, r, m, sigma;
            long C, Vp;

            if (str_p0 == null || str_p0.Equals("")||!double.TryParse(str_p0,out p0))
            {
                p0 = AbstractStrategy.def_p0;
            }
            if (str_Tsh == null || str_Tsh.Equals("") || !double.TryParse(str_Tsh, out Tsh))
            {
                Tsh = AbstractStrategy.def_Tsh;
            }
            if (str_Trsh == null || str_Trsh.Equals("") || !double.TryParse(str_Trsh, out Trsh))
            {
                Trsh = AbstractStrategy.def_Trsh;
            }
            if (str_B == null || str_B.Equals("") || !double.TryParse(str_B, out B))
            {
                B = AbstractStrategy.def_B;
            }
            if (str_C == null || str_C.Equals("") || !long.TryParse(str_C, out C))
            {
                C = AbstractStrategy.def_C;
            }
            if (str_Vp == null || str_Vp.Equals("") || !long.TryParse(str_Vp, out Vp))
            {
                Vp = AbstractStrategy.def_Vp;
            }
            if (str_L == null || str_L.Equals("") || !int.TryParse(str_L, out L))
            {
                L = AbstractStrategy.def_L;
            }
            if (str_s == null || str_s.Equals("") || !int.TryParse(str_s, out s))
            {
                s = AbstractStrategy.def_s;
            }
            if (str_r == null || str_r.Equals("") || !int.TryParse(str_r, out r))
            {
                r = AbstractStrategy.def_r;
            }
            if (str_m == null || str_m.Equals("") || !int.TryParse(str_m, out m))
            {
                m = AbstractStrategy.def_M;
            }
            if (str_sigma == null || str_sigma.Equals("") || !int.TryParse(str_sigma, out sigma))
            {
                sigma = AbstractStrategy.def_sigma;
            }
            
            ViewBag.p0 = p0;
            ViewBag.C = C;
            ViewBag.L = L;
            ViewBag.Vp = Vp;
            ViewBag.Tsh = Tsh;
            ViewBag.Trsh = Trsh;
            ViewBag.s = s;
            ViewBag.r = r;
            ViewBag.m = m;
            ViewBag.sigma = sigma;
            ViewBag.B = B;
            Dictionary<AvailableTechnologies, string> technologies = new Dictionary<AvailableTechnologies, string>();
            technologies.Add(AvailableTechnologies.Ethernet, AvailableTechnologies.Ethernet.ToString());
            technologies.Add(AvailableTechnologies.FastEthernet, AvailableTechnologies.FastEthernet.ToString());
            technologies.Add(AvailableTechnologies.GigabytEthernet, AvailableTechnologies.GigabytEthernet.ToString());
            technologies.Add(AvailableTechnologies.TenGbEthernet, AvailableTechnologies.TenGbEthernet.ToString());
            technologies.Add(AvailableTechnologies._40_100_GbEthernet, AvailableTechnologies._40_100_GbEthernet.ToString());
            Dictionary<AvailableStrategies, string> strategies = new Dictionary<AvailableStrategies, string>();
            strategies.Add(AvailableStrategies.ReturnToN, AvailableStrategies.ReturnToN.ToString());
            strategies.Add(AvailableStrategies.SlidingWindow, AvailableStrategies.SlidingWindow.ToString());


            ViewBag.technologies = technologies;
            ViewBag.strategies = strategies;

            if (Request.QueryString["calculate"] == null) return View();
            AbstractStrategy strategy = new ReturnToNStrategy(technology, p0, C, L, Vp, Tsh, Trsh, s, r, m, sigma, B);
            ViewBag.value = getValue(strategy);
            
            return View();
        }
        
        private double getValue(Strategy strategy)
        {  
            Console.WriteLine("T=%.10f\n", strategy.getT());
            Console.WriteLine("P=%.10f\n", strategy.getP());
            //System.out.printf("213=%d\n", strategy.getB());

            double result = (strategy.getN() - strategy.getT()) / strategy.getN() *
                    strategy.getB() *
                    strategy.getP() *
                    strategy.getWeff() *
                    strategy.getWnorm();
            return result;
        }
    }
}