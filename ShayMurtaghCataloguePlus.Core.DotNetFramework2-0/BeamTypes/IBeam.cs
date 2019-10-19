namespace ShayMurtaghClassLibrary
{
    public interface IBeam
    {
        string Type { get; }
        double Spacing { get; }
        double Dbeam { get; }
        double Dslab { get; }
        double Dtot { get; }
        double Lmax { get; }
        double Lmin { get; }
        string Designation { get; }
    }
}