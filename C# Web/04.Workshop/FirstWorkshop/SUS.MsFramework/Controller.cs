using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using SUS.HTTP;
using System.Runtime.CompilerServices;

namespace SUS.MsFramework
{
    public abstract class Controller
    {
        // All html file
        public HttpResponse View([CallerMemberName] string viewPath = null)
        {
            var layout = System.IO.File.ReadAllText("Views/Shared/_Layout.html");

            var viewContent = System.IO.File
                .ReadAllText("Views/" + this.GetType().Name
                .Replace("Controller", string.Empty) + "/" + viewPath + ".html");

            var responseHtml = layout.Replace(" @RenderBody()", viewContent);

            var responseBodyBytes = Encoding.UTF8.GetBytes(viewContent);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
        // The rest
        public HttpResponse File(string filePath, string contentType)
        {
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var respose = new HttpResponse(contentType, fileBytes);
            return respose;
        }
    }
}