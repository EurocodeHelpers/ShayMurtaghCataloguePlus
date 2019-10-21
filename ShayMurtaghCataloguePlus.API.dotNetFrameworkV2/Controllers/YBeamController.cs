using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShayMurtaghCataloguePlus.API.dotNetFrameworkV2.Controllers
{
    public class YBeamController : Controller
    {
        // GET: YBeam
        //https://localhost:44306/YBeam
        public ActionResult Index()
        {
            ShayMurtagh beamCatalogue = new ShayMurtagh();
            List<YBeam> ybeamCatalogue = beamCatalogue.GetYBeamCatalogue();

            ViewBag.fullCatalogue = ybeamCatalogue;
            ViewBag.Span = 3;

            return View();
        }       
    }
}