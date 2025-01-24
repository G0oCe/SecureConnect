namespace SecureConnect.Models;

public class DataMessage
{
	public string EncryptedData { get; set; } // Data encrypted with AES
	public string InitializationVector { get; set; } // Initialization Vector (IV) for AES
}
