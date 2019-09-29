using ConcreteBridgeBeams;
using ConcreteBridgeBeams.BeamTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShayMurtaghClassLibrary
{
    public class BeamCatalogue
    {
        public BeamCatalogue()
        {

        }

        public List<IBeam> GetFullCatalogue()
        {
            List<IBeam> fullCatalogue = new List<IBeam>();
            fullCatalogue.AppendBeamsToListOfIBeam(GetYBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetUBeamCatalogue());

            return fullCatalogue;
        }

        public List<IBeam> GetYBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new YBeam("Y1",1000,700,16.5,19.5),
                new YBeam("Y1",1500,700,12.5,15.5),
                new YBeam("Y1",2000,700,11,13.5),

                new YBeam("Y2",1000,800,19,22),
                new YBeam("Y2",1500,800,15,18),
                new YBeam("Y2",2000,800,12.5,15.5),

                new YBeam("Y3",1000,900,22,25),
                new YBeam("Y3",1500,900,17,20),
                new YBeam("Y3",2000,900,14.5,17.5),

                new YBeam("Y4",1000,1000,24.5,27.5),
                new YBeam("Y4",1500,1000,19,22),
                new YBeam("Y4",2000,1000,16.5,19.5),

                new YBeam("Y5",1000,1100,27,31),
                new YBeam("Y5",1500,1100,21,24),
                new YBeam("Y5",2000,1100,18,21),

                new YBeam("Y6",1000,1200,29,32),
                new YBeam("Y6",1500,1200,23,26),
                new YBeam("Y6",2000,1200,20,23),

                new YBeam("Y7",1000,1300,31,34),
                new YBeam("Y7",1500,1300,25,28),
                new YBeam("Y7",2000,1300,21.5,24.5),

                new YBeam("Y8",1000,1400,33.5,36.5),
                new YBeam("Y8",1500,1400,27,30),
                new YBeam("Y8",2000,1400,23.5,26.5),
            };
        }

        public List<IBeam> GetUBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new UBeam("U1", 3000, 800, 12, 17),
                new UBeam("U1", 2500, 800, 14, 18),
                new UBeam("U1", 2000, 800, 16, 20),

                new UBeam("U3", 3000, 900, 14.5, 18.5),
                new UBeam("U3", 2500, 900, 15.5, 19.5),
                new UBeam("U3", 2000, 900, 17.5, 21.5),

                new UBeam("U5", 3000, 1000, 16.5, 20.5),
                new UBeam("U5", 2500, 1000, 17.5, 21.5),
                new UBeam("U5", 2000, 1000, 22, 26),

                new UBeam("U7", 3000, 1100, 18.5, 22.5),
                new UBeam("U7", 2500, 1100, 21, 25),
                new UBeam("U7", 2000, 1100, 24, 28),

                new UBeam("U8", 3000, 1200, 20, 24),
                new UBeam("U8", 2500, 1200, 21, 25),
                new UBeam("U8", 2000, 1200, 24, 28),

                new UBeam("U9", 3000, 1300, 21.5, 25.5),
                new UBeam("U9", 2500, 1300, 22.5, 26.5),
                new UBeam("U9", 2000, 1300, 26, 30),

                new UBeam("U10", 3000, 1400, 23, 27),
                new UBeam("U10", 2500, 1400, 24.5, 28.5),
                new UBeam("U10", 2000, 1400, 27.5, 31.5),

                new UBeam("U11", 3000, 1500, 25, 29),
                new UBeam("U11", 2500, 1500, 26, 30),
                new UBeam("U11", 2000, 1500, 29.5, 33.5),

                new UBeam("U12", 3000, 1600, 26.5, 30.5),
                new UBeam("U12", 2500, 1600, 28, 32),
                new UBeam("U12", 2000, 1600, 31.5, 35.5),
            };
        }

        public List<IBeam> GetBoxBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new BoxBeam("Box300",495,800,5,9),
new BoxBeam("Box300",750,800,5.5,9.5),
new BoxBeam("Box300",970,800,5.5,9.5),

new BoxBeam("Box400",495,900,8,12),
new BoxBeam("Box400",750,900,8.5,12.5),
new BoxBeam("Box400",970,900,9,13),

new BoxBeam("Box500",495,1000,11,15),
new BoxBeam("Box500",750,1000,12,16),
new BoxBeam("Box500",970,1000,12,16),

new BoxBeam("Box600",495,1100,14.5,18.5),
new BoxBeam("Box600",750,1100,15,19),
new BoxBeam("Box600",970,1100,15,19),

new BoxBeam("Box700",495,1200,17,21),
new BoxBeam("Box700",750,1200,18,22),
new BoxBeam("Box700",970,1200,17.5,21.5),

new BoxBeam("Box800",495,1300,20.5,24.5),
new BoxBeam("Box800",750,1300,21,25),
new BoxBeam("Box800",970,1300,21.5,25.5),
            };
        }

    }
}
