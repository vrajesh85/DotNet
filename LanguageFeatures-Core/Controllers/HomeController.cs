using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            object[] objArray = new object[] { 1, 2, 3.5M, 4.5M, "Rajesh" };
            int result = 0;
            decimal decresult = 0.0M;
            foreach(var item in objArray)
            {
                if (item is int x)
                    result += x;
            }

            // Switch case pattern matching

            foreach(var item in objArray)
            {
                switch(item)
                {
                    case int intvalue:
                        result += intvalue;
                        break;
                    case decimal decimalvalue:
                        decresult += decimalvalue;
                        break;                                             
                }
            }

            return View(new string[] { "C#", "Language", "Features" });
        }
        
    }
}
