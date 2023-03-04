using MyFirstMvcApp.Controllers;
using SUS.HTTP;
using System;
using System.Diagnostics;
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

            // /user/register [user ==>> the name of the controller]
            // /user/register [register ==>> the name of the method]
            server.AddRoute("/", new HomeController().Index);
            server.AddRoute("/favicon", new StaticFilesController().Favicon);
            server.AddRoute("/about", new HomeController().About);;
            server.AddRoute("/user/login", new UsersController().Login);
            server.AddRoute("/user/register", new UsersController().Register);

            // Opens the localhost every time when the app is started
            Process.Start(new ProcessStartInfo("cmd", $"/c start http://localhost:180"));
            await server.StartAsynch(180);
        }
    }
}