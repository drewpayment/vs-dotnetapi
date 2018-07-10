using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using dotnetapi.Database;
using dotnetapi.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly VeroContext _context;
        
        public UserController(VeroContext context)
        {
            _context = context;

            if(_context.Users.Count() == 0)
            {
                byte[] salt = new byte[128 / 8];
                using(var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }

                var hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: "password",
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                _context.Users.Add(new User
                {
                    FirstName = "Drew",
                    LastName = "Payment",
                    Username = "paymean",
                    Email = "drew.payment@gmail.com",
                    Password = hash,
                    Active = true,
                    RememberToken = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                _context.SaveChanges();
            }
        }

        public ActionResult<List<User>> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> GetById(long id)
        {
            var item = _context.Users.Find(id);
            if(item == null)
            {
                return NotFound();    
            }
            return item;
        }
    }
}
