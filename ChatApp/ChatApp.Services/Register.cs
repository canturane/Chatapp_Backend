using ChatApp.Services.Services.Group;
using ChatApp.Services.Services.Message;
using ChatApp.Services.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace ChatApp.Services
{
    public static class Register
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IMessageService, MessageService>();
        }
    }
}
