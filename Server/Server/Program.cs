namespace SecureConnect.Server;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		TcpListener server = new TcpListener(IPAddress.Any, 5000);
		server.Start();
		Console.WriteLine("Server started...");

		while (true)
		{
			TcpClient client = server.AcceptTcpClient();
			Console.WriteLine("Client connected!");

			NetworkStream stream = client.GetStream();
			byte[] buffer = new byte[1024];
			int bytesRead = stream.Read(buffer, 0, buffer.Length);

			string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
			Console.WriteLine($"Received: {message}");

			byte[] response = Encoding.UTF8.GetBytes("Message received");
			stream.Write(response, 0, response.Length);

			client.Close();
		}
	}
}
