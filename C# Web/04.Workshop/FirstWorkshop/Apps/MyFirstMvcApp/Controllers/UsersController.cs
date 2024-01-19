using SUS.HTTP;
using SUS.MsFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcApp.Controllers
{
    public class UsersController : Controller   
    {
        public HttpResponse Login(HttpRequest request)
        {
            //Implement
            return this.View();       
        }
        public HttpResponse Register(HttpRequest request)
        {
            return this.View();
        }
    }
}
