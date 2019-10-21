using System.Collections.Generic;

namespace ShayMurtaghClassLibrary
{
    public class ShayMurtagh : IManufacturer
    {
        public ShayMurtagh()
        {

        }

        public List<IBeam> GetFullCatalogue()
        {
            List<IBeam> fullCatalogue = new List<IBeam>();
            //fullCatalogue.AppendBeamsToListOfIBeam(GetYBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetUBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetBoxBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetTBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetWBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetMBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetMYBeamCatalogue());
            fullCatalogue.AppendBeamsToListOfIBeam(GetTYBeamCatalogue());

            return fullCatalogue;
        }

        public List<IBeam> GetTYBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new TYBeam("TY1",765,400,4.5,11),
                new TYBeam("TY2",765,450,9.5,12.5),
                new TYBeam("TY3",765,500,10.5,13.5),
                new TYBeam("TY4",765,550,11.5,14.5),
                new TYBeam("TY5",765,600,13,16),
                new TYBeam("TY6",765,650,14,17),
                new TYBeam("TY7",765,700,15.5,18.5),
                new TYBeam("TY8",765,750,16.5,19.5),
                new TYBeam("TY9",765,800,17.5,20.5),
                new TYBeam("TY10",765,850,18.5,21.5),
                new TYBeam("TY11",765,900,19.5,22.5),
            };
        }

        public List<YBeam> GetYBeamCatalogue()
        {
            return new List<YBeam>()
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
                new BoxBeam("Box300",495,300,5,9),
                new BoxBeam("Box300",750,300,5.5,9.5),
                new BoxBeam("Box300",970,300,5.5,9.5),

                new BoxBeam("Box400",495,400,8,12),
                new BoxBeam("Box400",750,400,8.5,12.5),
                new BoxBeam("Box400",970,400,9,13),

                new BoxBeam("Box500",495,500,11,15),
                new BoxBeam("Box500",750,500,12,16),
                new BoxBeam("Box500",970,500,12,16),

                new BoxBeam("Box600",495,600,14.5,18.5),
                new BoxBeam("Box600",750,600,15,19),
                new BoxBeam("Box600",970,600,15,19),

                new BoxBeam("Box700",495,700,17,21),
                new BoxBeam("Box700",750,700,18,22),
                new BoxBeam("Box700",970,700,17.5,21.5),

                new BoxBeam("Box800",495,800,20.5,24.5),
                new BoxBeam("Box800",750,800,21,25),
                new BoxBeam("Box800",970,800,21.5,25.5),
            };
        }

        public List<IBeam> GetTBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new TBeam("T1",495,380,5,9),
                new TBeam("T2",495,420,7.5,9.5),
                new TBeam("T3",495,535,9,11),
                new TBeam("T4",495,575,10,12),
                new TBeam("T5",495,615,11,12.5),
                new TBeam("T6",495,655,11,13),
                new TBeam("T7",495,695,12,14.5),
                new TBeam("T8",495,735,12.5,15.5),
                new TBeam("T9",495,775,13,16),
                new TBeam("T10",495,815,14,17),
            };
        }

        public List<IBeam> GetWBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new WBeam("W1",3000,800,14,18),
                new WBeam("W1",3500,800,12.5,16.5),
                new WBeam("W1",4000,800,11.5,15.5),

                new WBeam("W3",3000,900,16,20),
                new WBeam("W3",3500,900,14.5,18.5),
                new WBeam("W3",4000,900,13,17),

                new WBeam("W5",3000,1000,17.5,21.5),
                new WBeam("W5",3500,1000,16,20),
                new WBeam("W5",4000,1000,14.5,18.5),

                new WBeam("W7",3000,1100,19.5,23.5),
                new WBeam("W7",3500,1100,18,22),
                new WBeam("W7",4000,1100,16.5,20.5),

                new WBeam("W8",3000,1200,21,25),
                new WBeam("W8",3500,1200,19.5,23.5),
                new WBeam("W8",4000,1200,18,22),

                new WBeam("W9",3000,1300,23,27),
                new WBeam("W9",3500,1300,21,25),
                new WBeam("W9",4000,1300,19.5,23.5),

                new WBeam("W10",3000,1400,24.5,28.5),
                new WBeam("W10",3500,1400,22.5,26.5),
                new WBeam("W10",4000,1400,21.5,25.5),

                new WBeam("W11",3000,1500,26,30),
                new WBeam("W11",3500,1500,24,28),
                new WBeam("W11",4000,1500,22.5,26.5),

                new WBeam("W12",3000,1600,27.5,31.5),
                new WBeam("W12",3500,1600,25.5,29.5),
                new WBeam("W12",4000,1600,23.5,27.5),

                new WBeam("W13",3000,1700,29,33),
                new WBeam("W13",3500,1700,27,31),
                new WBeam("W13",4000,1700,25,29),

                new WBeam("W14",3000,1800,30.5,34.5),
                new WBeam("W14",3500,1800,28.5,32.5),
                new WBeam("W14",4000,1800,26.5,30.5),

                new WBeam("W15",3000,1900,32,36),
                new WBeam("W15",3500,1900,30,34),
                new WBeam("W15",4000,1900,28,32),

                new WBeam("W16",3000,2000,33.5,37.5),
                new WBeam("W16",3500,2000,31.5,35.5),
                new WBeam("W16",4000,2000,29,33),

                new WBeam("W17",3000,2100,35,39),
                new WBeam("W17",3500,2100,32.5,36.5),
                new WBeam("W17",4000,2100,30.5,34.5),

                new WBeam("W18",3000,2200,36.5,40.5),
                new WBeam("W18",3500,2200,34,38),
                new WBeam("W18",4000,2200,31.5,35.5),

                new WBeam("W19",3000,2300,38,42),
                new WBeam("W19",3500,2300,35.5,39.5),
                new WBeam("W19",4000,2300,33,37),
            };
        }

        public List<IBeam> GetMBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new MBeam("M2",1000,720,16,18),
                new MBeam("M3",1000,800,17.5,19.5),
                new MBeam("M4",1000,880,19,21),
                new MBeam("M5",1000,960,20.5,22.5),
                new MBeam("M6",1000,1040,22,24),
                new MBeam("M7",1000,1120,23.5,26),
                new MBeam("M8",1000,1200,25.5,27.5),
                new MBeam("M9",1000,1280,26.5,28.5),
                new MBeam("M10",1000,1360,28,30),
            };
        }

        public List<IBeam> GetMYBeamCatalogue()
        {
            return new List<IBeam>()
            {
                new MYBeam("MY1",1,300,4,8.5),
                new MYBeam("MY1",2,300,4,10.5),

                new MYBeam("MY2",1,350,6,10),
                new MYBeam("MY2",2,350,7.5,11.5),

                new MYBeam("MY3",1,400,7,11),
                new MYBeam("MY3",2,400,9,13),

                new MYBeam("MY4",1,450,8.5,12.5),
                new MYBeam("MY4",2,450,10.5,14.5),

                new MYBeam("MY5",1,500,10,14),
                new MYBeam("MY5",2,500,12.5,16.5),

                new MYBeam("MY6",1,550,11,15),
                new MYBeam("MY6",2,550,13.5,17.5),

                new MYBeam("MY7",1,600,12,16),
                new MYBeam("MY7",2,600,15,19),
            };
        }

    }
}
