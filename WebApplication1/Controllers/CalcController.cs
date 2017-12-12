using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                    result = (firstVar + secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                case "Sub":
                    result = (firstVar - secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                case "Mult":
                    result = (firstVar * secondVar).ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    result = SecondVariable != "0" ? (firstVar / secondVar).ToString(CultureInfo.InvariantCulture) 
                        : "Incorrect parameters";
                    break;
            }

            ViewBag.Message = result;
            return View();
        }
    }
}