using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.MathService;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult Calculate(string FirstVariable, string SecondVariable, string action)
        {
            var client = new MathServiceClient();
            string result = "";
            if (!Double.TryParse(FirstVariable.Replace(',', '.'), out var firstVar))
            {
                result = "Incorrect first parameter";

                ViewBag.Message = result;
                return View();
            }
            if (!Double.TryParse(SecondVariable.Replace(',', '.'), out var secondVar))
            {
                result = "Incorrect second parameter";

                ViewBag.Message = result;
                return View();
            }
            switch (action)
            {
                case "Add":
                    result = client.Add(firstVar, secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                case "Sub":
                    result = client.Sub(firstVar, secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                case "Mult":
                    result = client.Mul(firstVar, secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    result = SecondVariable != "0" ? client.Div(firstVar, secondVar).ToString(CultureInfo.InvariantCulture) 
                        : "Incorrect parameters";
                    break;
            }

            ViewBag.Message = result;
            return View();
        }
    }
}