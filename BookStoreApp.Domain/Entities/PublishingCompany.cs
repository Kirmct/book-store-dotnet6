using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStoreApp.Domain.Entities
{
    public class PublishingCompany
    {
        public int Id { get; set; }

        public string Cnpj { get; set; }

        public string SocialName { get; set; }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; } = new List<Book>();

        public PublishingCompany()
        {}

    }
}
