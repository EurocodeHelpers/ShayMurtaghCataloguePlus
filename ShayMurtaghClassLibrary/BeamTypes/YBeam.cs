using System;
using System.Collections.Generic;
using System.Linq;

namespace ShayMurtaghClassLibrary
{
    public class YBeam : IBeam
    {
        public YBeam(string type, double spacing, double db, double tslab, double lmin, double lmax)
        {
            Type = type;
            Spacing = spacing;
            Db = db;
            Dslab = tslab;
            Lmin = lmin;
            Lmax = lmax;
        }

        public string Type { get; private set; }
        public double Spacing { get; private set; }
        public double Db { get; private set; }
        public double Dslab { get; private set; }
        public double Lmin { get; private set; }
        public double Lmax { get; private set; }

        //Methods
        public double Dtot => Db + Dslab;
        public string Designation => $"{Type}'s @ {Spacing}mm centers. Dbeam = {Db} and Tslab = {Dslab} - Dtotal = {Dtot} ";


    }
}
