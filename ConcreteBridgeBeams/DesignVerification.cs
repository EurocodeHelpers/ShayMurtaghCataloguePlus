using System;

namespace ShayMurtaghClassLibrary
{
    public class DesignVerification
    {
        public DesignVerification(IBeam beam, double l, double davail)
        {
            this.Beam = beam;
            L = l;
            Davail = davail;
        }

        public IBeam Beam {get; set;}
        public double L { get; set; }
        public double Davail { get; set; }

        //Verifications 
        public bool LminOK => (L >= Beam.Lmin);
        public bool LmaxOK => (L <= Beam.Lmax);
        public bool DmaxOK => (Davail >= Beam.Dtot);
        public bool sectionOk => LminOK & LmaxOK & DmaxOK;

        //Design Summary 
        public double RemainingDepth => Davail - Beam.Dtot;
        public double Util => Math.Round(L / Beam.Lmax, 2);

        public string Summary => $"{Beam.Type}'s @ {Beam.Spacing}mm centers. Dbeam = {Beam.Dbeam} and Tslab = {Beam.Dslab} - Dtotal = {Beam.Dtot}." +
            $"Util = {Util}, Remaining Depth = {RemainingDepth}";
    }
}
