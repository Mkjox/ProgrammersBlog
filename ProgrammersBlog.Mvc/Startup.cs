﻿using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgrammersBlog.Mvc.AutoMapper.Profiles;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Mvc.Helpers.Concrete;
using ProgrammersBlog.Services.AutoMapper.Profiles;
using ProgrammersBlog.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IImageHelper, ImageHelper>();
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new ArticleProfile());
                cfg.AddProfile(new ViewModelsProfile());
                //cfg.AddProfile(new CommentProfile());
            }));

            services.AddControllersWithViews(options =>
            {
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "Bu alan boş geçilmemelidir.");
            }).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            }).AddNToastNotifyToastr();
            services.AddSession();
            //services.AddRazorPages();
            services.AddAutoMapper(typeof(CategoryProfile), typeof(ArticleProfile), typeof(UserProfile), typeof(ViewModelsProfile), typeof(CommentProfile));
            services.LoadMyServices(connectionString: Configuration.GetConnectionString("LocalDB"));
            services.AddScoped<IImageHelper, ImageHelper>();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login");
                options.LogoutPath = new PathString("/Admin/Auth/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "ProgrammersBlog",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                    //Its not recommended to use as SameAsRequest so change to Always when you publish the site.
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
                options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseNToastNotify();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                /*endpoints.MapControllerRoute(
                    name: "article",
                    pattern: "{title}/{articleId}",
                    defaults: new { controller = "Article", action"Detail" }
                    );*/
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}