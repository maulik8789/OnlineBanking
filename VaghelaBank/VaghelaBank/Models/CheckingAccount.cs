﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VaghelaBank.Models;

namespace VaghelaBank.Models
{
    public class CheckingAccount
    {
        public int AccountNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public decimal Balance { get; set; }
    }
}