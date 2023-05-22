﻿using Microsoft.AspNetCore.Identity;

namespace RunGroupWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public int Pace { get; set; }

        public int Mileage { get; set; }

        public Address? Address { get; set; }

        public ICollection<Club>? Clubs { get; set; }

        public ICollection<Race>? Races { get; set; }
    }
}
