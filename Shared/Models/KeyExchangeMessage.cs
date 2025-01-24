namespace SecureConnect.Models;

public class KeyExchangeMessage
{
	public string PublicKey { get; set; }  // The RSA public key
	public string EncryptedAesKey { get; set; } // Encrypted symmetric AES key (if used)
}
