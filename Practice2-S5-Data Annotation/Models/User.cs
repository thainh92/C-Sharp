using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practice2_S5_Data_Annotation.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must have at least 8 character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }

        public User(string id, string name, string password, string confirmPassword, string email)
        {
            Id = id;
            Name = name;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }

        public User()
        {
        }
    }
}