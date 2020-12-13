using HarrisContactsWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactsWeb.Data
{
    public class HarrisDbContext : DbContext 
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
