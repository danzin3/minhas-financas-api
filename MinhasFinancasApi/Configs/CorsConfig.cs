namespace MinhasFinancasApi.Configs
{
    internal static class CorsConfig
    {
        public static void ConfigCoorsStartup(this IServiceCollection services, EnvVariables env)
        {
            if (
                env?.CorsOptions?.PolicyName is null ||
                env?.CorsOptions?.Origins is null ||
                env?.CorsOptions?.Methods is null ||
                env?.CorsOptions?.AllowCredentials is null
                ) throw new ArgumentNullException(nameof(env));

            services.AddCors(options =>
            {
                options.AddPolicy(env.CorsOptions.PolicyName, config =>
                {
                    config.WithOrigins(env.CorsOptions.Origins);
                    config.WithMethods(env.CorsOptions.Methods);
                    if (env.CorsOptions.AllowCredentials == true) config.AllowCredentials();
                });
            });
        }
    }
}
