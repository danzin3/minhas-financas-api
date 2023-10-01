using MinhasFinancasApi.Configs;

namespace MinhasFinancasApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public EnvVariables EnvVar { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            EnvVar = new EnvVariables(Configuration);
        }

        /**
         * Método utilizado para configurar e registrar serviços que serão usados em todo o aplicativo
         * como serviço de banco de dados, autenticação, mensageria dentre outros.
         */
        public void ConfigureServices(IServiceCollection services) {

            services.AddSingleton<EnvVariables>();

            services.ConfigCoorsStartup(EnvVar);

            services.AddControllers();
            
            services.AddEndpointsApiExplorer();

            services.AddHttpContextAccessor();

            services.AddSwaggerGen();

            //RegisterServices(services);
        }

        /**
         * Método usado para configurar como o aplicativo lida com solicitações HTTP.
         */
        public void Configure(WebApplication app) {

            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.ConfigHttpMiddlewares(EnvVar);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

        private static void RegisterServices(IServiceCollection services) {
            //Chamar a função de injeção de dependências da camada de IoC
        }
    }
}
