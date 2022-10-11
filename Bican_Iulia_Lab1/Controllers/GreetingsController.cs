using Microsoft.AspNetCore.Mvc;

namespace Bican_Iulia_Lab1.Controllers
{
    public class GreetingsController : Controller
    {

        public string Index()
        {
            string x = "Welcome to this ASP.NET Homepage";
            return x;
        }

        public string Hello()
        {
            string x = "Hello User!";
            return x;
        }

        public string HelloWithInput(string name = "Gica", int age = 25)
        {
            
            return "Hello " + name + ", you are " + age + " years old.";
        }
    }
}
