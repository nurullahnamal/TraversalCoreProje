using Autofac;
using Autofac.Extensions.DependencyInjection;
using BusinessLayer.DependencyResolver.Autofac;
using BusinessLayer.ValidationRules;
using BusinessLayer.ValidationRules.ContactUs;
using DataAccessLayer.Concrete;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.Models;

namespace TraversalCoreProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });

            builder.Services.AddHttpClient();

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<Context>();

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>()
                .AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(options =>
            {
                options.RegisterModule(new AutofacBusinessModule());
            });

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();

            builder.Services.AddScoped<GetAllDestinationQueryHandler>();
            builder.Services.AddScoped<GetDestinationByIDQueryHandler>();
            builder.Services.AddScoped<CreateDestinationCommandHandler>();
            builder.Services.AddScoped<RemoveDestinationCommandHandler>();
            builder.Services.AddScoped<UpdateDestinationCommandHandler>();


            builder.Services.AddMediatR(typeof(Program));


            builder.Services.AddControllersWithViews().AddFluentValidation();

            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
            }); 

            builder.Services.AddMvc();
            var app = builder.Build();

            var loggerFactory = app.Services.GetService<ILoggerFactory>();
            loggerFactory.AddFile(builder.Configuration["Logging:LogFilePath"].ToString());
            // /-----------------------------------------------------------------------------------------------------------------------------------------------------


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

          

            app.Run();

           
        }
    }
}