using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
