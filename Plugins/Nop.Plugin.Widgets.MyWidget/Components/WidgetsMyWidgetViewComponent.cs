using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Widgets.MyWidget.Models;
using Nop.Services.Catalog;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.Logging;
using Nop.Services.Orders;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.MyWidget.Components
{
    [ViewComponent(Name = "WidgetsMyWidget")]
    public class WidgetsMyWidgetViewComponent : NopViewComponent
    {
        #region Fields

        private readonly CurrencySettings _currencySettings;
        private readonly ICategoryService _categoryService;
        private readonly ICurrencyService _currencyService;
        private readonly ICustomerService _customerService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly ILogger _logger;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        #endregion

        #region Ctor

        public WidgetsMyWidgetViewComponent(CurrencySettings currencySettings,
            ICategoryService categoryService,
            ICurrencyService currencyService,
            ICustomerService customerService,
            IGenericAttributeService genericAttributeService,
            ILogger logger,
            IOrderService orderService,
            IProductService productService,
            ISettingService settingService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _currencySettings = currencySettings;
            _categoryService = categoryService;
            _currencyService = currencyService;
            _customerService = customerService;
            _genericAttributeService = genericAttributeService;
            _logger = logger;
            _orderService = orderService;
            _productService = productService;
            _settingService = settingService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        #endregion

        #region Methods

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            return View("~/Plugins/Widgets.MyWidget/Views/Default.cshtml","");
        }

        #endregion
    }
}