using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStoreApp.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? AuthorName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
        [JsonIgnore]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public Author()
        {}
    }
}
