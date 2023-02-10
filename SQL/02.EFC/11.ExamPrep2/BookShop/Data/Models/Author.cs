namespace BookShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class Author
    {
        public Author()
        {
            this.AuthorsBooks = new HashSet<AuthorBook>();
        }

        public int Id { get; set; }
        [Required]
        [MinLength(3), MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3), MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]     
        public string Email { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string Phone { get; set; }

        // not sure for the next line
        [JsonIgnore]
        public ICollection<AuthorBook> AuthorsBooks { get; set; }
    }
}