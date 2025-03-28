using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Data.Repositories.GroupRepository;
using ChatApp.Data.Repositories.MessageRepository;
using ChatApp.Data.Repositories.UserRepository;
using ChatApp.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ChatApp.Data
{
    public static class Register
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
        }
    }
}
