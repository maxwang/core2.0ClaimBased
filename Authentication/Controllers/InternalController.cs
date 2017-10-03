using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication.Extensions;

namespace Authentication.Controllers
{
    public class InternalController : Controller
    {
        [ClaimAuthorize("CustomerPortal.Internal.Menu", "Customers")]
        public IActionResult Index()
        {
            return View();
        }
    }
}