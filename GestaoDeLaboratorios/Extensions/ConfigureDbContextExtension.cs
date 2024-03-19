using GestaoDeLaboratorios.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace GestaoDeLaboratorios.Extensions;

public static class ConfigureDbContextExtension
{
    public static void ConfigureDbContext(this IServiceCollection services)
    {
        using var serviceProvider = services.BuildServiceProvider();
        
        var options = serviceProvider.GetRequiredService<IOptionsMonitor<DbOption>>();

        services.AddDbContextPool<InfnetDbContext>(opt =>
            opt.UseSqlServer(options.CurrentValue.LabBd));

        EnsureCreateDatabase(services);
    }

    private static void EnsureCreateDatabase(IServiceCollection services)
    {
        using var serviceProvider = services.BuildServiceProvider();
        var context = serviceProvider.GetRequiredService<InfnetDbContext>();
        context.Database.EnsureCreated();
    }
}
