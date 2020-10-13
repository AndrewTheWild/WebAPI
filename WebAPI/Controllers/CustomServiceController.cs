using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class CustomServiceController : Controller
    {
        public string Index()
        {
            string message = ""; 
            message = "There is a connection";
            return message;
        }
    }
}
