using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShayMurtaghCataloguePlus.API.dotNetFrameworkV2.Controllers
{
    public class BeamController : ApiController
    {
        private List<IBeam> fullCatalogue = new List<IBeam>();

        public BeamController()
        {
            var catalogue = new ShayMurtagh();
            this.fullCatalogue = catalogue.GetFullCatalogue();
        }

        // GET: Returns every beam in Shay Murtagh's Catalogue
        [Route("api/shaymurtaghcatalogue")]
        [HttpGet]
        public List<IBeam> Get_FullShayMurtaghCatalogue()
        {
            return fullCatalogue;
        }

        // GET: Returns every beam with Lmin and Lmax based off span 
        // GET: api/Beam/id where id = span
        public List<IBeam> Get_BeamsWithinLminAndLmax(int id)
        {
            List<IBeam> suitableDesigns = fullCatalogue.Where(x => id >= x.Lmin && id <= x.Lmax).ToList();
            return suitableDesigns;
        }

        //GET: Returns a list of designations e.g. Y8s ~ 3m c/c, Db=2000 etc etc 
        [Route("api/designations")]
        [HttpGet]
        public List<string> GetDesignations()
        {
            return (fullCatalogue.Select(item => item.Designation)).ToList();
        }

        //GET: Returns a list of beam designs which satisfy both construction depth and span length 
        [Route("api/Beams/GetWorkingDesigns/L={span:int}/Davail={constructionDepth:int}")]
        [HttpGet]
        public List<IBeam> Get_WorkingDesigns(int span, int constructionDepth)
        {
            return fullCatalogue.Where
                (x => span >= x.Lmin && span <= x.Lmax && constructionDepth >= x.Dtot).ToList();
        }

        // POST: api/Beam
        public void Post(IBeam beam)
        {
            fullCatalogue.Add(beam);
        }

        // PUT: api/Beam/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Beam/5
        public void Delete(int id)
        {
        }
    }
}
