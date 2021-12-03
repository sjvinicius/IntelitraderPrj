using InteliTrader.Dominio.Handlers.Autentica��o;
using InteliTrader.Dominio.Handlers.Usuarios;
using InteliTrader.Dominio.Handlers.Vagas;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Infra.Data.Contexts;
using InteliTrader.Infra.Data.Repositories.Vagas;
using InteliTrader.Infra.Data.Repositorio;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Configuramos o servi�o de contexto:
            services.AddDbContext<InteliTraderContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InteliTrader.API", Version = "v1" });
            });

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //Valida��o Controller
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "InteliTrader",
                        ValidAudience = "InteliTrader",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Intelitrader-chave-autenticacao")),
                        ClockSkew = TimeSpan.FromMinutes(50),
                    };
                });

            // adiciona a pol�tica CORS ao projeto
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder =>
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod());
            });

            //Inje��es de depend�ncia
            #region Inje��o de Depend�ncia Usuario
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<CriarContaHandler, CriarContaHandler>();
            services.AddTransient<LogarHandle, LogarHandle>();
            #endregion
            #region Inje��o de Dependencia Vagas
            services.AddTransient<IVagasRepository, VagasRepository>();
            services.AddTransient<CriarVagasHandler, CriarVagasHandler>();
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "InteliTrader.API v1");
                    

                    });
            }

            
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
           
            //CORS
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
