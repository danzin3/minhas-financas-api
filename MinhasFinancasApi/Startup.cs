using Microsoft.OpenApi.Models;

namespace MinhasFinancasApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        /**
         * Método utilizado para configurar e registrar serviços que serão usados em todo o aplicativo
         * como serviço de banco de dados, autenticação, mensageria dentre outros.
         * Os serviços configurados aqui estarão disponíveis para serem injetados em todo
         * o projeto por meio do mecanismo de injeção de dependência do ASP.NET Core.
         */
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddHttpContextAccessor();

            services.AddSwaggerGen();

            //RegisterServices(services);
        }

        /**
         * Método usado para configurar como o aplicativo lida com solicitações HTTP.
         * Cada método chamado pelo parâmetro 'app' adiciona um middleware específico ao pipeline.
         */
        public void Configure(WebApplication app) {

            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

        private static void RegisterServices(IServiceCollection services) {
            //Chamar a função de injeção de dependências da camada de IoC
        }
    }
}
