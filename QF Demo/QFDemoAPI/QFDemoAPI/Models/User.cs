﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class User 
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Alias { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }
    }
}
