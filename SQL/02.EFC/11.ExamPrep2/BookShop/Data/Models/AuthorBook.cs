namespace BookShop.Data.Models
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    
    public class AuthorBook
    {
        [Required]
        public int AuthorId { get; set; }

        [JsonIgnore]
        public Author Author { get; set; }

        public int BookId { get; set; }

        [JsonIgnore]
        public Book Book { get; set; }
    }
}