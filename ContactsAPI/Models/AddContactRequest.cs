namespace ContactsAPI.Models
{
    public class AddContactRequest
    {
        public required  string FullName { get; set; }

        public required string Email { get; set; }
        public required long Phone { get; set; }
        public required string Address { get; set; }
    }
}
