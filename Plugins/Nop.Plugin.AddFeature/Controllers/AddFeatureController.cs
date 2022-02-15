using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Discounts;

using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Localization;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.AddFeature.Controllers
{
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class AddFeatureController : BasePluginController
    {
        #region Fields

        private readonly ICustomerService _customerService;
        private readonly IDiscountService _discountService;
        private readonly ILocalizationService _localizationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;

        #endregion

        #region Ctor

        public AddFeatureController(ICustomerService customerService,
            IDiscountService discountService,
            ILocalizationService localizationService,
            IPermissionService permissionService,
            ISettingService settingService)
        {
            _customerService = customerService;
            _discountService = discountService;
            _localizationService = localizationService;
            _permissionService = permissionService;
            _settingService = settingService;
        }

        #endregion

        #region Methods

        public IActionResult Configure(int discountId, int? discountRequirementId)
        {
            return View("~/Plugins/AddFeature/Views/PublicInfo.cshtml");
        }

        //[HttpPost]        
        //public IActionResult Configure(RequirementModel model)
        //{
        //    return View(model);
        //}

        #endregion
    }
}