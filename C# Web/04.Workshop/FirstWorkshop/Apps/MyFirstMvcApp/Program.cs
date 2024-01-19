using MyFirstMvcApp.Controllers;
using SUS.HTTP;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MyFirstMvcApp
{
    public class Program
    {
        static async Task Main()
        {
            IHttpServer server = new HttpServer();
            server.AddRoute("/", new HomeController().Index);
            //server.AddRoute("/favicon", new StaticFilesController().Favicon);

            server.AddRoute("/users/login", new UsersController().Login);
            server.AddRoute("/users/register", new UsersController().Register);

            Process.Start(new ProcessStartInfo("cmd", $"/c start http://localhost"));
            await server.StartAsynch(80);
        }
    }
}