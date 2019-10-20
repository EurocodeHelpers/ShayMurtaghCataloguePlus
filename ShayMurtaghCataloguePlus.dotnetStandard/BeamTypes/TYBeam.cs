using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayMurtaghClassLibrary
{
    public class TYBeam : IBeam
    {
        public TYBeam(string type, double spacing, double dbeam, double lmin, double lmax)
        {
            Type = type;
            Spacing = spacing;
            Dbeam = dbeam;
            Lmin = lmin;
            Lmax = lmax;
        }

        public string Type { get; private set; }
        public double Spacing { get; private set; }
        public double Dbeam { get; private set; }
        public double Dslab => 150;
        public double Lmin { get; private set; }
        public double Lmax { get; private set; }

        //Methods
        public double Dtot => Dbeam + Dslab;
        public string Designation => $"{Type}'s @ {Spacing}mm centers. Dbeam = {Dbeam} and Dslab = {Dslab} - Dtotal = {Dtot} ";


    }
}
