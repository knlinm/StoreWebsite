namespace StoreWebsite.Models
{
    public class User:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public int UserRoleId { get; set; }


        public virtual UserRole UserRole { get; set; }
    }
}
