using Nop.Core;
using Nop.Services.Plugins;

namespace Nop.Plugin.MyPlugin
{
    public class AddMyPlugin : BasePlugin
    {
        private readonly IWebHelper _webHelper;
        public AddMyPlugin(IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/MyPlugin/Configure";
        }
        public override void Install()
        {
           base.Install();
        }
        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}
