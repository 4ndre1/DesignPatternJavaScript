using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternJavaScript.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var status = GerarStatusParaPesquisa(true, false, false);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ObserverPattern()
        {
            //Javascript pattern
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Código Temp!!
        private string[] GerarStatusParaPesquisa(bool emProcessamento, bool recebidoSemErros, bool recebidoComErros)
        {
            string[] status = new string[3];

            if (emProcessamento) status[0] = StatusArquivo.PRO.ToString();
            if (recebidoSemErros) status[1] = StatusArquivo.SEM.ToString();
            if (recebidoComErros) status[2] = StatusArquivo.COM.ToString();

            if (status.All(s => s == null))
            {
                status = new string[3] 
                {
                    StatusArquivo.PRO.ToString(),
                    StatusArquivo.SEM.ToString(),
                    StatusArquivo.COM.ToString()
                };
            }

            return status;
        }

    }

    public enum StatusArquivo
    {
        [Description("Em processamento")]
        PRO,
        [Description("Recebido sem erros")]
        SEM,
        [Description("Recebido com erros")]
        COM,
    }
}