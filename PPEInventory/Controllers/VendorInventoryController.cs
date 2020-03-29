using PPEInventory.Data.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPEInventory.Controllers
{
    [Authorize]
    public class VendorInventoryController : Controller
    {
        // GET: VendorInventory
        public ActionResult Index()
        {
             
            var instruments = new CommonManager().GetInstruments();
            return View();
        }
    }
}