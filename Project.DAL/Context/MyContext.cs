using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.MAP.Configurations;

namespace Project.DAL.Context
{
    public class MyContext:IdentityDbContext<User, Role, int, IdentityUserClaim<int>, User_Role, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // todo: Seed

            // Configurations(Mapping)

            builder.ApplyConfiguration(new Branch_Configuration());
            builder.ApplyConfiguration(new BranchType_Configuration());
            builder.ApplyConfiguration(new Company_Configuration());
            builder.ApplyConfiguration(new Document_Configuration());
            builder.ApplyConfiguration(new EMail_Configuration());
            builder.ApplyConfiguration(new Gadget_Configuration());
            builder.ApplyConfiguration(new GadgetType_Configuration());
            builder.ApplyConfiguration(new Gadget_Maintenance_Configuration());
            builder.ApplyConfiguration(new Gadget_ServiceRecord_Configuration());
            builder.ApplyConfiguration(new Maintenance_Configuration());
            builder.ApplyConfiguration(new MaintenanceRecord_Configuration());
            builder.ApplyConfiguration(new MaintenanceRecord_Material_Configuration());
            builder.ApplyConfiguration(new MaintenanceType_Configuration());
            builder.ApplyConfiguration(new Material_Configuration());
            builder.ApplyConfiguration(new MaterialType_Configuration());
            builder.ApplyConfiguration(new Message_Configuration());
            builder.ApplyConfiguration(new Request_Configuration());
            builder.ApplyConfiguration(new Role_Configuration());
            builder.ApplyConfiguration(new ServiceRecord_Company_Configuration());
            builder.ApplyConfiguration(new ServiceRecord_Material_Configuration());
            builder.ApplyConfiguration(new ServiceRecord_User_Configuration());
            builder.ApplyConfiguration(new Team_Configuration());
            builder.ApplyConfiguration(new User_Configuration());
            builder.ApplyConfiguration(new User_Role_Configuration());
            builder.ApplyConfiguration(new Offer_Configuration());
            builder.ApplyConfiguration(new Offer_Company_Configuration());
            builder.ApplyConfiguration(new Photograph_Configuration());
        }

        //DBSets

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EMail> EMails { get; set; }
        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Gadget_Maintenance> Gadget_Maintenances { get; set; }
        public DbSet<Gadget_ServiceRecord> Gadget_ServiceRecords { get; set; }
        public DbSet<GadgetType> GadgetTypes { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public DbSet<MaintenanceRecord_Material> MaintenanceRecord_Materials { get; set; }
        public DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Offer_Company> Offer_Companies { get; set; }
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<ServiceRecord_Company> ServiceRecord_Companies { get; set; }
        public DbSet<ServiceRecord_Material> ServiceRecord_Materials { get; set; }
        public DbSet<ServiceRecord_User> ServiceRecord_Users { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
