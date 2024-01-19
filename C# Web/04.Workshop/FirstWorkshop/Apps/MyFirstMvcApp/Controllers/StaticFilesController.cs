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
    public class StaticFilesController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            //path, content type
            return this.File("views/wwwroot/favicon.png", "image/vnd.microsoft.icon");
            //var fileBytes = File.ReadAllBytes("views/wwwroot/favicon.png");
            //var response = new HttpResponse("image/vnd.microsoft.icon", fileBytes);
            //return response;
        }
    }
}
