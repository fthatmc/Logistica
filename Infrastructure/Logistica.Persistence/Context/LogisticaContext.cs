using Logistica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Persistence.Context
{
    public class LogisticaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ATMACA\\SQLEXPRESS;initial Catalog=LogisticaDb;integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<AboutUs2> AboutUs2s { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureImage> FeatureImages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSocialMedia> TeamSocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
