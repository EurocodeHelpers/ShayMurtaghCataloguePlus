namespace ShayMurtaghClassLibrary
{
    public interface IBeam
    {
        double Db { get; }
        string Designation { get; }
        double Dslab { get; }
        double Dtot { get; }
        double Lmax { get; }
        double Lmin { get; }
        double Spacing { get; }
        string Type { get; }
    }
}