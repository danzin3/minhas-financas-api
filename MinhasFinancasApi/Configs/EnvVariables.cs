namespace MinhasFinancasApi.Configs
{
    public class CorsOptionsEnv
    {
        public string? PolicyName { get; set; }
        public string[]? Origins { get; set; }
        public string[]? Methods { get; set; }
        public string[]? Headers { get; set; }
        public string[]? ExposedHeaders { get; set; }
        public bool? AllowCredentials { get; set; }
    }
    public class EnvVariables
    {
        public CorsOptionsEnv? CorsOptions { get; set; } = new CorsOptionsEnv();

        public EnvVariables(IConfiguration configuration)
        {
            configuration.GetSection("CorsOptionsDefault").Bind(this.CorsOptions);
        }
    }
}
