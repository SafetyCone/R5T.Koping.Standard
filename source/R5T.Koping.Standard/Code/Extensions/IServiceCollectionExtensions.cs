using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Koping.Default;


namespace R5T.Koping.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFolderProjectTypeGuidProvider"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFolderProjectTypeGuidProvider(this IServiceCollection services)
        {
            services.AddDefaultVisualStudioSolutionFolderProjectTypeGuidProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFolderProjectTypeGuidProvider"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFolderProjectTypeGuidProvider> AddVisualStudioSolutionFolderProjectTypeGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFolderProjectTypeGuidProvider>(() => services.AddVisualStudioSolutionFolderProjectTypeGuidProvider());
            return serviceAction;
        }
    }
}
