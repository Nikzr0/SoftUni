using System;
using System.Threading.Tasks;

namespace SUS.HTTP
{
    public interface IHttpServer
    {
        // An interface for HttpServer containing 2 methods
        void AddRoute(string path, Func<HttpRequest, HttpResponse> action);
        Task StartAsynch(int port);
    }
}
