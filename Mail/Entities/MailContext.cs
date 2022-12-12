using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mail.Entities
{
    public class MailContext : IdentityDbContext
    {
        public MailContext(DbContextOptions<MailContext> options)
              : base(options)
        { }

        public DbSet<Mail> Mails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
