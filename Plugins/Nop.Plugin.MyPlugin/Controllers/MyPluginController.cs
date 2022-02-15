using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.MyPlugin.Models;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.MyPlugin.Controllers
{
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class MyPluginController : BasePluginController
    {
        public IActionResult Configure()
        {
            var model = new MyPluginModel();
            return View("~/Plugins/MyPlugin/Views/Configure.cshtml", model);
        }
    }
}
