using System;

namespace webapi.AuthDAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        // public byte[] PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        // public byte[] PasswordSalt { get; set; }
    }
}
