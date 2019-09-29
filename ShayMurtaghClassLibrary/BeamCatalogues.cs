using System;
using System.Collections.Generic;
using System.Text;

namespace ShayMurtaghClassLibrary
{
    public static class BeamCatalogues
    {
        public static List<IBeam> GetYBeamCatalogue()
        {
            //TODO - Fix hacky code which we have to place the largest beam spacing at the top. 
            return new List<IBeam>()
            {
                new YBeam("Y1",1000,700,200,16.5,19.5),
                new YBeam("Y1",1500,700,200,12.5,15.5),
                new YBeam("Y1",2000,700,200,11,13.5),

                new YBeam("Y2",1000,800,200,19,22),
                new YBeam("Y2",1500,800,200,15,18),
                new YBeam("Y2",2000,800,200,12.5,15.5),

                new YBeam("Y3",1000,900,200,22,25),
                new YBeam("Y3",1500,900,200,17,20),
                new YBeam("Y3",2000,900,200,14.5,17.5),

                new YBeam("Y4",1000,1000,200,24.5,27.5),
                new YBeam("Y4",1500,1000,200,19,22),
                new YBeam("Y4",2000,1000,200,16.5,19.5),

                new YBeam("Y5",1000,1100,200,27,31),
                new YBeam("Y5",1500,1100,200,21,24),
                new YBeam("Y5",2000,1100,200,18,21),

                new YBeam("Y6",1000,1200,200,29,32),
                new YBeam("Y6",1500,1200,200,23,26),
                new YBeam("Y6",2000,1200,200,20,23),

                new YBeam("Y7",1000,1300,200,31,34),
                new YBeam("Y7",1500,1300,200,25,28),
                new YBeam("Y7",2000,1300,200,21.5,24.5),

                new YBeam("Y8",1000,1400,200,33.5,36.5),
                new YBeam("Y8",1500,1400,200,27,30),
                new YBeam("Y8",2000,1400,200,23.5,26.5),
            };
        }

    }
}
