using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> instruments;

        public RockBand(IEnumerable<IInstrument> instruments)
        {
            this.instruments = instruments.ToList();
        }

        public void DoSoundCheck()
        {
            this.instruments.ForEach(i => Console.WriteLine(i.Play()));
        }
    }
}
