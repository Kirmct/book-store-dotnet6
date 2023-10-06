using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStoreApp.Domain.Entities
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Book Book { get; set; } = null!;
        [JsonIgnore]
        public Author Author { get; set; } = null!;
    }
}
