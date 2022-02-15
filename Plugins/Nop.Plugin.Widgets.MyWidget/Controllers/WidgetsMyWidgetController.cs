using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.MyWidget.Models;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widgets.MyWidget.Controllers
{
    [Area(AreaNames.Admin)]
    [AuthorizeAdmin]
    [AutoValidateAntiforgeryToken]
    
    public class WidgetsMyWidgetController : BasePluginController
    {
        #region Fields

        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;

        #endregion

        #region Ctor

        public WidgetsMyWidgetController(
            ILocalizationService localizationService,
            INotificationService notificationService,
            IPermissionService permissionService,
            ISettingService settingService,
            IStoreContext storeContext)
        {
            _localizationService = localizationService;
            _notificationService = notificationService;
            _permissionService = permissionService;
            _settingService = settingService;
            _storeContext = storeContext;
        }

        #endregion

        #region Methods
        
        public IActionResult Configure()
        {
            var model = new ConfigurationModel();
            return View("~/Plugins/Widgets.MyWidget/Views/Configure.cshtml", model);
        }
        
        #endregion
    }
}