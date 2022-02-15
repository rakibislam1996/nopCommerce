using System;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Services.Caching;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.AddFeature.Components
{
    [ViewComponent(Name = "AddFeatureComponent")]
    public class AddFeatureComponent : NopViewComponent
    {
        private readonly ICacheKeyService _cacheKeyService;
        private readonly IStoreContext _storeContext;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly ISettingService _settingService;
        private readonly IPictureService _pictureService;
        private readonly IWebHelper _webHelper;

        public AddFeatureComponent(ICacheKeyService cacheKeyService,
            IStoreContext storeContext, 
            IStaticCacheManager staticCacheManager, 
            ISettingService settingService, 
            IPictureService pictureService,
            IWebHelper webHelper)
        {
            _cacheKeyService = cacheKeyService;
            _storeContext = storeContext;
            _staticCacheManager = staticCacheManager;
            _settingService = settingService;
            _pictureService = pictureService;
            _webHelper = webHelper;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            return View("~/Plugins/AddFeature/Views/PublicInfo.cshtml");
        }
    }
}
