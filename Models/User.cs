using System;
using System.Collections.Generic;

namespace dotnetapi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberToken { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //RELATIONSHIPS
        public UserDetail Detail { get; set; }
        public Agent Agent { get; set; }
    }
}
