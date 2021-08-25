using Core.CrossCutingConcerns.Caching;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Core.CrossCuttingConcerns.Caching.Microsoft;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {

        public void Load(ServiceCollection serviceColection)
        {
            serviceColection.AddMemoryCache();
            serviceColection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceColection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceColection.AddSingleton<Stopwatch>();
        }
    }
}
