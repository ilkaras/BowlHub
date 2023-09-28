namespace BowlHub.DAL.Extensions;

public class DbInitializer
{
    public static void Initialize(DataBaseContext context)
    {
        context.Database.EnsureCreated();
    }
}