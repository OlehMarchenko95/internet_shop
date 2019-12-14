﻿using Microsoft.EntityFrameworkCore;
using internet_shop.Models;
using internet_shop.Entities;

namespace internet_shop.DbContexts
{
    public class ProfileDbContext : BaseDbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

