using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }

        public String Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
