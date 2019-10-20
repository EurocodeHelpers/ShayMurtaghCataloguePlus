using System.Collections.Generic;

namespace ShayMurtaghClassLibrary
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
