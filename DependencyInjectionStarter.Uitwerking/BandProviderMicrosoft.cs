using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionStarter.Library;

namespace DependencyInjectionStarter
{
    public class BandProviderMicrosoft
    {
        private static IServiceProvider _serviceProvider;

        public BandProviderMicrosoft()
        {
            _serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddTransient<IInstrument, Guitar>()
                .AddTransient<IInstrument, Vocal>()
                .AddTransient<IInstrument, BassGuitar>()
                .AddTransient<IInstrument, Drums>()
                // horrible piece of code here -> not as fancy as NINJECT
                .AddSingleton<RockBand>(prov => new RockBand(prov.GetServices<IInstrument>()))
                .BuildServiceProvider(new ServiceProviderOptions() { ValidateOnBuild = true, ValidateScopes = true }); ;
        }

        public RockBand DefaultRockband
        {
            get { return _serviceProvider.GetService<RockBand>(); }
        }
    }
}
