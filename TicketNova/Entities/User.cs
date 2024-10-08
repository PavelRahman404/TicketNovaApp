﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketNova_Domain.Entities
{
    public class User : IdentityUser
    {
        [Key]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string UserPicture { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
