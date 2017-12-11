using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Сводное описание для CalcService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Message()
        {
            return "Just a message, since I know how to show it";
        }

        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Sub(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Mul(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
