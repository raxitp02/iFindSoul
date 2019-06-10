using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id  {get; set;}

        public string Username {get; set;}

        public byte[] passwordHash { get; set; }

        public byte[] passwordSalt { get; set;}
    }
}