using DependencyInjectionStarter.Library;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionStarter
{
    class Program
    {
        
        /** Testing 123 */
        static void Main()
        {
            ////via custom create band
            //List<IInstrument> instrumenten = new List<IInstrument>();
            //instrumenten.Add(new Guitar());
            //instrumenten.Add(new Guitar());
            //instrumenten.Add(new BassGuitar());
            //instrumenten.Add(new Drums());
            //instrumenten.Add(new Vocal());

            //Via locator and NINJECT
            Console.WriteLine("We're putting the band back together with Ninject");
            var locator = new BandLocatorNinject();
            var ninjectorock = locator.DefaultRockband;
            ninjectorock.DoSoundCheck();

            //via Microsoft.Extensions.DependencyInjection
            Console.WriteLine();
            Console.WriteLine("Microsoft's School of Rock");
            var provider = new BandProviderMicrosoft();
            var MSRockers = provider.DefaultRockband;
            MSRockers.DoSoundCheck();

            Console.ReadLine();
        }

       

    }
}
