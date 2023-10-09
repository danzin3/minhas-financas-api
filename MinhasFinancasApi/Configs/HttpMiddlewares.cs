namespace MinhasFinancasApi.Configs
{
    internal static class HttpMiddlewares
    {
        public static void ConfigHttpMiddlewares(this WebApplication app, EnvVariables env) 
        {
            if (env?.CorsOptions?.PolicyName is null) throw new ArgumentNullException(nameof(env));

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(env.CorsOptions.PolicyName);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
