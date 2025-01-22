using System;
using System.Net.Sockets;
using System.Text;

TcpClient client = new TcpClient("127.0.0.1", 5000);
NetworkStream stream = client.GetStream();

string message = "Hello, Server!";
byte[] data = Encoding.UTF8.GetBytes(message);
stream.Write(data, 0, data.Length);

byte[] buffer = new byte[1024];
int bytesRead = stream.Read(buffer, 0, buffer.Length);
string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
Console.WriteLine($"Server response: {response}");

client.Close();
