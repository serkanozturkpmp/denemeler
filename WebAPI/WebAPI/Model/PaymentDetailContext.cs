using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options) { }

        public DbSet<Login> Logins { get; set; }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = "localhost";
            var port = "5432";
            var name = "psDb";
            var user = "serkan";
            var password = "1234";

            optionsBuilder.UseNpgsql($"Host={server};Port={port};Database={name};Username={user};Password={password}");
        }
    }
}
