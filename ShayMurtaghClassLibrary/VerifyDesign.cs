using System;
using System.Collections.Generic;
using System.Text;

namespace ShayMurtaghClassLibrary
{
    public class DesignVerification
    {
        public DesignVerification(IBeam beam, double l, double davail)
        {
            this.beam = beam;
            L = l;
            Davail = davail;
        }

        public IBeam beam {get; set;}
        public double L { get; set; }
        public double Davail { get; set; }

        //Verifications 
        public bool LminOK => (L >= beam.Lmin);
        public bool LmaxOK => (L <= beam.Lmax);
        public bool DmaxOK => (Davail >= beam.Dtot);
        public bool sectionOk => LminOK & LmaxOK & DmaxOK;

        //Design Summary 
        public double RemainingDepth => Davail - beam.Dtot;
        public double Util => Math.Round(L / beam.Lmax, 2);
        public string Summary => $"{beam.Type}'s @ {beam.Spacing}mm centers. Dbeam = {beam.Db} and Tslab = {beam.Dslab} - Dtotal = {beam.Dtot}." +
            $"Util = {Util}, Remaining Depth = {RemainingDepth}";


        public static List<DesignVerification> GetSuitablePrestressingBeamArrangements(List<IBeam> catalogue, double L, double Davail)
        {
            List<DesignVerification> workingDesigns = new List<DesignVerification>();

            foreach (IBeam beam in catalogue)
            {
                DesignVerification designCheck = new DesignVerification(beam, L, Davail);

                //If sectionOK is true, add it to collection of working designs. 
                if (designCheck.sectionOk)
                {
                    workingDesigns.Add(designCheck);
                }
            }
            return workingDesigns;
        }

    }
}
