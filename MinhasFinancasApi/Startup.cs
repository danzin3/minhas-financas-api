using MinhasFinancasApi.Configs;
using Microsoft.AspNetCore.CookiePolicy;

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

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.Secure = CookieSecurePolicy.Always;
                options.HttpOnly = HttpOnlyPolicy.Always;
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
            });

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
            app.ConfigHttpMiddlewares(EnvVar);
        }

        private static void RegisterServices(IServiceCollection services) {
            //Chamar a função de injeção de dependências da camada de IoC
        }
    }
}
