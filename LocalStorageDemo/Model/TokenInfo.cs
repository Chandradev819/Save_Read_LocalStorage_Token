using System.ComponentModel.DataAnnotations;

namespace LocalStorageDemo
{
    public class TokenInfo
    {
        [System.ComponentModel.DataAnnotations.Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set; } 
    }
}
