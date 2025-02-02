﻿using Core.Services;
using DataLayer;
using DataLayer.Repositories;

namespace Project.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            applicationBuilder.Services.AddDbContext<AppDbContext>();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<AuthorizationService>();
            services.AddScoped<StudentService>();
            services.AddScoped<ClassService>();
            services.AddScoped<GradeService>();
            services.AddScoped<UserService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<StudentsRepository>();
            services.AddScoped<ClassRepository>();
            services.AddScoped<GradesRepository>();
            services.AddScoped<UsersRepository>();
            services.AddScoped<RoleRepository>();
            services.AddScoped<UnitOfWork>();
        }
    }
}
