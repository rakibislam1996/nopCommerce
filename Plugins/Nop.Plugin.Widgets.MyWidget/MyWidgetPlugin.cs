using System.Collections.Generic;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.MyWidget
{
    public class MyWidgetPlugin : BasePlugin, IWidgetPlugin
    {

        #region Fields

        private readonly ILocalizationService _localizationService;
        private readonly IWebHelper _webHelper;
        private readonly ISettingService _settingService;

        #endregion

        #region Ctor
        public MyWidgetPlugin(ILocalizationService localizationService,
            IWebHelper webHelper,
            ISettingService settingService)
        {
            _localizationService = localizationService;
            _webHelper = webHelper;
            _settingService = settingService;
        }
        #endregion

        #region Methods
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/WidgetsMyWidget/Configure";
        }
        public override void Install()
        {
            base.Install();
        }
        public override void Uninstall()
        {
            base.Uninstall();
        }
        // Methods & Properties of IWidgetPlugin
        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.ProductDetailsAddInfo };
        }
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsMyWidget";
        }
        public bool HideInWidgetList => false;

        

        #endregion
    }
}
