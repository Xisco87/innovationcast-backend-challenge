﻿using Backend.Challenge.Application.Interfaces;
using Backend.Challenge.Application.Services;
using Backend.Challenge.Domain.Interfaces.Repositories;
using Backend.Challenge.Infrastructure.Persistence.DataContext;
using Backend.Challenge.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Challenge.API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DiscussaoDBContext>();
            services.AddScoped<IEntidadeRepository, EntidadeRepository>();

            services.AddScoped<IEntidadeService, EntidadeService>();

            services.AddAutoMapper(typeof(AutoMapperProfileConfiguration));
        }
    }
}
