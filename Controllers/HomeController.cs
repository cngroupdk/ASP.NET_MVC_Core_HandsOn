using Microsoft.AspNetCore.Mvc;

namespace  HandsOn
{
    public class HomeController : Controller  { 
        public string Index()
         { 
            return "our awesome home controller";
        }
    }
}