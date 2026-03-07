using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.src.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? Avatar { get; set; }
        public int Coin { get; set; }

        public Libraries? Libraries { get; set; }
        public List<Ratings>? Ratings { get; set; }
    }
}