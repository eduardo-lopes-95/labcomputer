using GestaoDeLaboratorios.Infra;

namespace GestaoDeLaboratorios.Extensions;

public static class ConfigureDbOptions
{
    public static void ConfigureDb(this IServiceCollection services)
    {
        services.AddOptions<DbOption>()
                 .BindConfiguration(DbOption.SECTION_KEY)
                 .ValidateDataAnnotations().ValidateOnStart();
    }
}
