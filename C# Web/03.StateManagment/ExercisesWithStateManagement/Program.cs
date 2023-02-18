using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWithStateManagement
{
    public class Program
    {
        static async Task Main()
        {
            // Web page socket address  
            TcpListener tcpListener = new TcpListener(
                IPAddress.Loopback, 400);

            // start
            tcpListener.Start();

            // The best way to write new line in http
            const string NewLine = "\r\n";

            while (true)
            {
                // Client implementation
                var client = tcpListener.AcceptTcpClient();
                using (var stream = client.GetStream())
                {
                    byte[] buffer = new byte[1000000000];
                    var length = stream.Read(buffer, 0, buffer.Length);

                    string requestStr = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.WriteLine(requestStr);

                    string html = $"<h1>Welcome on my web page at{DateTime.Now}!</h1>";
                    string html2 = $"<h1>I hope you enjoy it <3</h1>";
                    string paragraph = $"<p>My name is Nikola and I am here to learn and have fun</p>";

                    string response = "HTTP/1.1 200 OK" + NewLine +
                        "Server: NikolaServer 2023" + NewLine +
                        "Content-Type: text/html; charset=utf-8" + NewLine +
                        "Content-Type: " + NewLine +
                        "Set-Cookie: sid=firstCookieEver; Security; HttpOnly; Parh=/;Max-Age = " + (10) + NewLine +
                        "Content-Lenght: " + (html.Length + html2.Length + paragraph.Length + NewLine +
                        NewLine +
                        html + html2 + paragraph + NewLine);

                    byte[] responseArray = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseArray);

                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}