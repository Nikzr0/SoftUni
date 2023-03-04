using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SUS.HTTP
{
    
    public class HttpServer : IHttpServer
    {
        Dictionary<string, Func<HttpRequest, HttpResponse>> dic =
            new Dictionary<string, Func<HttpRequest, HttpResponse>>();
        public void AddRoute(string path, Func<HttpRequest, HttpResponse> action)
        {
            if (dic.ContainsKey(path))
            {
                dic[path] = action;
            }
            else
            {
                dic.Add(path, action);
            }
        }

        public async Task StartAsynch(int port)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, port);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                ProcessClientAsynch(tcpClient);
            }
        }

        private async Task ProcessClientAsynch(TcpClient tcpClient)
        {
            using (NetworkStream stream = tcpClient.GetStream())
            {
                List<byte> data = new List<byte>();

                while (true)
                {
                    int position = 0;
                    byte[] buffer = new byte[4092];

                    int count = await stream.ReadAsync(buffer, position, buffer.Length);
                    position += count;

                    if (count < buffer.Length)
                    {
                        // it means it is the end of the buffer
                        var fullBuffer = new byte[count];
                        Array.Copy(buffer, fullBuffer, count);
                        data.AddRange(fullBuffer);
                        break;
                    }
                    else
                    {                       
                        data.AddRange(buffer);
                    }
                }

                var resultString = Encoding.UTF8.GetString(data.ToArray());
                
                var request = new HttpRequest(resultString);
                Console.WriteLine($"{request.Method} {request.Path} " +
                    $"{request.Headres.Count} headers");

                var title = "<h1>Welcome everybody</h1>" + request.Headres
                    .FirstOrDefault(x=> x.Name == "User-Agent")?.Value;
                var responseBodyTitleBytes = Encoding.UTF8.GetBytes(title);

                var response = new HttpResponse("text/html", responseBodyTitleBytes);
                response.Headers.Add(new Header("Serve:",  "SUS Serve: 1.0"));                           
                response.Cookies.Add(new ResponseCookie
                    ("sid", Guid.NewGuid().ToString()) {HttpOnly = true, MaxAge = 60 * 24 * 60 * 60}); 
                var responseHeaderBytes = Encoding.UTF8.GetBytes(response.ToString());
                await stream.WriteAsync(responseHeaderBytes, 0 , responseHeaderBytes.Length);

                await stream.WriteAsync(responseBodyTitleBytes, 0 , responseBodyTitleBytes.Length);
                await stream.WriteAsync(response.Body, 0, response.Body.Length);
            }

            tcpClient.Close();
        }
    }
}
