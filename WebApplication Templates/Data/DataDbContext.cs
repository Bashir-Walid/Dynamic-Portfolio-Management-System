using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> op):base(op)
        {

        }
        public DbSet<MasterAbout> MasterAbout { get; set; }
        public DbSet<MasterPositions> MasterPositions { get; set; }
        public DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }
        public DbSet<MasterTitles> MasterTitles { get; set; }
        public DbSet<MasterServices> MasterServices { get; set; }
        public DbSet<MasterTestimonials> MasterTestimonials { get; set; }
        public DbSet<MasterClients> MasterClients { get; set; }
        public DbSet<MasterPlans> MasterPlans { get; set; }
        public DbSet<MasterPlanItems> MasterPlanItems { get; set; }
        public DbSet<MasterFacts> MasterFacts { get; set; }
        public DbSet<MasterEducation> MasterEducation { get; set; }
        public DbSet<MasterExperience> MasterExperience { get; set; }
        public DbSet<MasterSkills> MasterSkills { get; set; }
        public DbSet<MasterCertificates> MasterCertificates { get; set; }
        public DbSet<MasterCategory> MasterCategory { get; set; }
        public DbSet<MasterPortfolio> MasterPortfolio { get; set; }
        public DbSet<MasterContactUs> MasterContactUs { get; set; }
        public DbSet<MasterTransactionContactUs> MasterTransactionContactUs { get; set; }


    }
}
