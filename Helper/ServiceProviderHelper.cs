using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Lib.Helper
{
    public static class ServiceProviderHelper
    {
        public static object GetServiceOrCreateInstance(this IServiceProvider provider, Type type)
            => ActivatorUtilities.GetServiceOrCreateInstance(provider, type);

        public static object CreateInstance(this IServiceProvider provider, Type type, params object[] paramaters)
            => ActivatorUtilities.CreateInstance(provider, type, paramaters);

        public static T GetServiceOrCreateInstance<T>(this IServiceProvider provider)
            => ActivatorUtilities.GetServiceOrCreateInstance<T>(provider);

        public static T CreateInstance<T>(this IServiceProvider provider, params object[] paramaters)
            => ActivatorUtilities.CreateInstance<T>(provider, paramaters);

        public static object GetServiceOrCreateInstance(this IServiceProvider provider, ServiceDescriptor descriptor)
            => descriptor.ImplementationInstance
                ?? descriptor.ImplementationFactory?.Invoke(provider)
                ?? provider.GetServiceOrCreateInstance(descriptor.ImplementationType);
    }
}
