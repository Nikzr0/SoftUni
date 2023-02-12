using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Http_Introduction
{
    public class Program
    {
        static async Task Main()
        {
            // Web page socket address  
            TcpListener tcpListener = new TcpListener(
                IPAddress.Loopback, 12345);

            // start
            tcpListener.Start();

            // The best way to write new line in http
            const string NewLine = "\r\n";

            while (true)
            {
                // Client implementation
                var client = tcpListener.AcceptTcpClient();
                // sream is disposable, so we use using 
                using (var stream = client.GetStream())
                {
                    // Tht long array is not the best wat but it is fine for the demo
                    byte[] buffer = new byte[1000000000];
                    var length = stream.Read(buffer, 0, buffer.Length);

                    //Request
                    string requestStr = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.WriteLine(requestStr);                   

                    // Resources
                    string html = $"<h1>Welcome on my web page at{DateTime.Now}!</h1>";
                    string html2 = $"<h1>I hope you enjoy it <3</h1>";
                    string paragraph = $"<p>My name is Nikola and I am here to learn and have fun</p>";
                    string form = $"<form method=post><input type=\"name\" name=\"name\">" +
                        $"<input type=\"password\" name=\"password\">" +
                        $"<input type=submit></form>";
                    string image = $"<img src=\"https://images.unsplash.com/photo-1503023345310-bd7c1de61c7d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8aHVtYW58ZW58MHx8MHx8&auto=format&fit=crop&w=1600&q=60\" alt=\"Pretty girl\">";

                    //Http response
                    string response = "HTTP/1.1 200 OK" + NewLine +
                        "Server: NikolaServer 2023" + NewLine +
                        "Content-Type: text/html; charset=utf-8" + NewLine +
                        "Content-Type: " + NewLine +
                        //"Content-Disposition: attachment; filename=nikolawebsite.txt" + NewLine +
                        "Content-Lenght: " + (html.Length + html2.Length + paragraph.Length + form.Length + image.Length) + NewLine +
                        NewLine +
                        html + html2 + paragraph + form  + image + NewLine;

                    // This converts "response" into a byte array using the Encoding.UTF8.GetBytes 
                    byte[] responseArray = Encoding.UTF8.GetBytes(response);
                    // Then it is written to the stream using the Write method
                    stream.Write(responseArray);

                    //Separator 
                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}