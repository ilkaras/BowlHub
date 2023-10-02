using BowlHub.BLL.Services.Classes;
using BowlHub.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BowlHub.BLL.Extentions;

public static class AddServices
{
    public static void AddServiceInjection(this IServiceCollection services)
    {
        services.AddScoped<IPlaceService, PlaceService>();
        services.AddScoped<IBoardService, BoardService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>();
        
        services.AddAutoMapper(typeof(AppMappingProfile));
    }
}