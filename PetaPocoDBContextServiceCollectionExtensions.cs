using System;
using Microsoft.Extensions.DependencyInjection;

namespace XmSoft.NetCore.PetaPocoExtensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class PetaPocoDBContextServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddPetaPoco<T>(
            this IServiceCollection services,
            Action<PetaPocoDBContextOptions> setupAction)
            where T : class, IPetaPocoDBContext
        {
            if (null == services)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (null == setupAction)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<IPetaPocoDBContext, T>();

            return services;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddPetaPocoConfiguration<T>(
            this IServiceCollection services,
            Action<PetaPocoDBContextConfigurationOptions> setupAction)
            where T : class, IPetaPocoDBContext
        {
            if (null == services)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (null == setupAction)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<IPetaPocoDBContext, T>();

            return services;
        }

    }
}
