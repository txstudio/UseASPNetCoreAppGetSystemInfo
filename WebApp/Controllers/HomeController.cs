using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PromptManager;
using OperatingSystemPlatform;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IPromptManager _promptManager;

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            if (PlatformHelper.IsWindows() == true)
            {
                this._promptManager = new WindowsPromptManager();
            }
            else if (PlatformHelper.IsLinux() == true)
            {
                this._promptManager = new LinuxPromptManager();
            }
            else if (PlatformHelper.IsMac() == true)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
            

            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            var _hostName = this._promptManager.GetHostName().Result;

            ViewData["HostName"] = _hostName;

            return View();
        }

        public IActionResult Reboot()
        {
            this._promptManager.Reboot();

            return Json(true);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
