﻿using System.ComponentModel.DataAnnotations;

namespace EduLife.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
