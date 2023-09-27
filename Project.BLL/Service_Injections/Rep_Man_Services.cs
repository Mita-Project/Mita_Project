using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Manager_Services.Abstracts;
using Project.BLL.Manager_Services.Concretes;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Service_Injections
{
    public static class Rep_Man_Service
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {
            //Repositories

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IBranch_Repository, Branch_Repository>();
            services.AddScoped<IBranchType_Repository, BranchType_Repository>();
            services.AddScoped<ICompany_Repository, Company_Repository>();
            services.AddScoped<IDocument_Repository, Document_Repository>();
            services.AddScoped<IEMail_Repository, EMail_Repository>();
            services.AddScoped<IGadget_Maintenance_Repository, Gadget_Maintenance_Repository>();
            services.AddScoped<IGadget_Repository, Gadget_Repository>();
            services.AddScoped<IGadget_ServiceRecord_Repository, Gadget_ServiceRecord_Repository>();
            services.AddScoped<IGadgetType_Repository, GadgetType_Repository>();
            services.AddScoped<IMaintenance_Repository, Maintenance_Repository>();
            services.AddScoped<IMaintenanceRecord_Material_Repository, MaintenanceRecord_Material_Repository>();
            services.AddScoped<IMaintenanceRecord_Repository, MaintenanceRecord_Repository>();
            services.AddScoped<IMaintenanceType_Repository, MaintenanceType_Repository>();
            services.AddScoped<IMaterial_Repository, Material_Repository>();
            services.AddScoped<IMaterialType_Repository, MaterialType_Repository>();
            services.AddScoped<IMessage_Repository, Message_Repository>();
            services.AddScoped<IOffer_Company_Repository, Offer_Company_Repository>();
            services.AddScoped<IOffer_Repository, Offer_Repository>();
            services.AddScoped<IPhotograph_Repository, Photograph_Repository>();
            services.AddScoped<IRequest_Repository, Request_Repository>();
            services.AddScoped<IRole_Repository, Role_Repository>();
            services.AddScoped<IServiceRecord_Company_Repository, ServiceRecord_Company_Repository>();
            services.AddScoped<IServiceRecord_Material_Repository, ServiceRecord_Material_Repository>();
            services.AddScoped<IServiceRecord_Repository, ServiceRecord_Repository>();
            services.AddScoped<IServiceRecord_User_Repository, ServiceRecord_User_Repository>();
            services.AddScoped<ITeam_Repository, Team_Repository>();
            services.AddScoped<IUser_Repository, User_Repository>();
            services.AddScoped<IUser_Role_Repository, User_Role_Repository>();

            //Managers

            services.AddScoped(typeof(IManager<>), typeof(Base_Manager<>));

            services.AddScoped<IBranch_Manager, Branch_Manager>();
            services.AddScoped<IBranchType_Manager, BranchType_Manager>();
            services.AddScoped<ICompany_Manager, Company_Manager>();
            services.AddScoped<IDocument_Manager, Document_Manager>();
            services.AddScoped<IEMail_Manager, EMail_Manager>();
            services.AddScoped<IGadget_Maintenance_Manager, Gadget_Maintenance_Manager>();
            services.AddScoped<IGadget_Manager, Gadget_Manager>();
            services.AddScoped<IGadget_ServiceRecord_Manager, Gadget_ServiceRecord_Manager>();
            services.AddScoped<IGadgetType_Manager, GadgetType_Manager>();
            services.AddScoped<IMaintenance_Manager, Maintenance_Manager>();
            services.AddScoped<IMaintenanceRecord_Manager, MaintenanceRecord_Manager>();
            services.AddScoped<IMaintenanceRecord_Material_Manager, MaintenanceRecord_Material_Manager>();
            services.AddScoped<IMaintenanceType_Manager, MaintenanceType_Manager>();
            services.AddScoped<IMaterial_Manager, Material_Manager>();
            services.AddScoped<IMaterialType_Manager, MaterialType_Manager>();
            services.AddScoped<IMessage_Manager, Message_Manager>();
            services.AddScoped<IOffer_Company_Manager, Offer_Company_Manager>();
            services.AddScoped<IOffer_Manager, Offer_Manager>();
            services.AddScoped<IPhotograph_Manager, Photograph_Manager>();
            services.AddScoped<IRequest_Manager, Request_Manager>();
            services.AddScoped<IServiceRecord_Company_Manager, ServiceRecord_Company_Manager>();
            services.AddScoped<IServiceRecord_Manager, ServiceRecord_Manager>();
            services.AddScoped<IServiceRecord_Material_Manager, ServiceRecord_Material_Manager>();
            services.AddScoped<ITeam_Manager, Team_Manager>();
            services.AddScoped<IRole_Manager, Role_Manager>();
            services.AddScoped<IUser_Manager, User_Manager>();
            services.AddScoped<IServiceRecord_User_Manager, ServiceRecord_User_Manager>();
            services.AddScoped<IUser_Role_Manager, User_Role_Manager>();

            return services;
        }
    }
}
