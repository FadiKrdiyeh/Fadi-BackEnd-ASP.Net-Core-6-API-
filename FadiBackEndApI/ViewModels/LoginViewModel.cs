﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FadiBackEndApI.ViewModels
{
    public class LoginViewModel
    {
        public string Id { get; set; }
        //[Required]
        public string Username { get; set; }
        //[Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string FullName { get; set; }

        public string Token { get; set; }
    }
}
