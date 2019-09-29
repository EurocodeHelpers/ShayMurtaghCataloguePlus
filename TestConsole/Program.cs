using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalogue = BeamCatalogues.GetYBeamCatalogue();
            List<DesignVerification> listOfDesigns = DesignVerification.GetSuitablePrestressingBeamArrangements(catalogue, 19, 1500);

            foreach (var design in listOfDesigns)
            {
                Console.WriteLine(design.Summary);
            }
        }
    }
}
