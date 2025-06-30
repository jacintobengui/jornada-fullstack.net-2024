namespace Fina.Api.Common.Api;

public static class AppExtension
{
    public static void ConfigureDevEvironment(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
