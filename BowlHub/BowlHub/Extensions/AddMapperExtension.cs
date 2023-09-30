namespace BowlHub.Extensions;

public static class AddMapperExtension
{
    public static void AddMapper(this IServiceCollection service)
    {
        service.AddAutoMapper(typeof(AppMapperProfile));
    }
}