namespace LocalStorageDemo
{
    public class TokenInfo
    {
        public string Name { get; set; } // Client Token, Shopper Token, etc.
        public string Value { get; set; } // Token value (string)
        public DateTime? ExpiryDate { get; set; } // Nullable for tokens without expiry (Account Id, Shopper Id)
    }
}
