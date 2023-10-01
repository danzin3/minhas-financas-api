namespace MinhasFinancasApi.Configs
{
    internal static class HttpMiddlewares
    {
        public static void ConfigHttpMiddlewares(this WebApplication app, EnvVariables env) 
        {
            if (env?.CorsOptions?.PolicyName is null) throw new ArgumentNullException(nameof(env));

            app.UseCors(env.CorsOptions.PolicyName);
        }
    }
}
