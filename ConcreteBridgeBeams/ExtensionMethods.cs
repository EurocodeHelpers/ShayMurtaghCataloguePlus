using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteBridgeBeams
{
    public static class ExtensionMethods
    {
        public static void AppendBeamsToListOfIBeam(this List<IBeam> mainList, List<IBeam> beamList)
        {
            foreach (IBeam beam in beamList)
            {
                mainList.Add(beam);
            }
        }


    }
}
