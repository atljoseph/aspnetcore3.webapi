using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using webapi.AuthDAL.Entities;

namespace webapi.AuthDAL
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<webapi.AuthDAL.Entities.User> Users { get; set; }
    }
}