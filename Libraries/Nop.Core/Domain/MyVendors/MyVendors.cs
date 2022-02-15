using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.MyVendors
{
    public class MyVendors : BaseEntity
    {
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
