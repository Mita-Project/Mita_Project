using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:IdentityDbContext<User, Role, int, IdentityUserClaim<int>, User_Role, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        //todo: Seeding 

        //todo: Configurations

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
