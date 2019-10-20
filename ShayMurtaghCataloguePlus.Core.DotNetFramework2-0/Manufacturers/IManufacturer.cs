using System.Collections.Generic;

namespace ShayMurtaghClassLibrary
{
    public interface IManufacturer
    {
        List<IBeam> GetFullCatalogue();
    }
}