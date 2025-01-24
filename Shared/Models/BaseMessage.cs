namespace SecureConnect.Models;

public class BaseMessage
{
	public string MessageType { get; set; } // ("KeyExchange", "Data", "Error")
	public string Payload { get; set; }    // Message body (encrypted data or JSON)
}