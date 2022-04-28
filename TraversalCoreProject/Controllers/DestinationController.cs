using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManger = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManger.TGetList();
            return View(values);
        }
    }
}
