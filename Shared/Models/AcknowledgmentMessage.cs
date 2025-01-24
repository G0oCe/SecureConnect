namespace SecureConnect.Models;

public class AcknowledgmentMessage
{
	public string Status { get; set; } // "Success" or "Failure"
	public string MessageId { get; set; } // the confirmed message (if necessary)
}
