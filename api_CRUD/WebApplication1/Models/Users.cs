﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
