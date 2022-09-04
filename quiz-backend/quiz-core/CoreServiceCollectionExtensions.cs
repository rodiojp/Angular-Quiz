using System;
using System.Net.Http.Headers;
using System.Text;
//using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using quiz_core.Quizes;
using quiz_core.Quizes.Database;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CoreServiceCollectionExtensions
    {
        /// <summary>
        /// Registers Core services.
        /// </summary>
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.Configure<QuizOptions>(configuration.GetSection("Quiz"));
            services.AutoRegisterServicesFromAssembly(typeof(CoreServiceCollectionExtensions).Assembly);

            services.AddDbContextPool<QuizContext>((serviceProvider, optionsBuilder) =>
            {
                var quizOptions = serviceProvider.GetRequiredService<IOptions<QuizOptions>>();

                optionsBuilder.UseSqlServer(
                    quizOptions.Value.ConnectionString,
                    sqlOptionsBuilder =>
                    {
                        sqlOptionsBuilder.EnableRetryOnFailure();
                        sqlOptionsBuilder.CommandTimeout(300);
                    });
            });

            services.AddMemoryCache();

            return services;
        }
    }
}
