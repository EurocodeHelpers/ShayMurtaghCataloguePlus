using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteBridgeBeams
{
    public class SuitableSections
    {
        public SuitableSections(double l, double dmax, List<IBeam> sectionCatalogue)
        {
            L = l;
            Dmax = dmax;
            this.sectionCatalogue = sectionCatalogue;
        }

        private double L { get; set; }
        private double Dmax { get; set; }
        private List<IBeam> sectionCatalogue { get; set; }

        public List<DesignVerification> GetSuitableSections()
        {
            List<DesignVerification> workingDesigns = new List<DesignVerification>();

            foreach (IBeam beam in sectionCatalogue)
            {
                DesignVerification designCheck = new DesignVerification(beam, L, Dmax);

                bool check1 = designCheck.sectionOk;
                
                if (designCheck.sectionOk)
                {
                    workingDesigns.Add(designCheck);
                }
            }
            return workingDesigns;
        }
    }
}
