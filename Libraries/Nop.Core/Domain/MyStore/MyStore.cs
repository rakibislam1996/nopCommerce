using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.MyStore
{
    public class MyStore : BaseEntity
    {
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string ContactNumber { get; set; }
        //public int StoreId { get; set; }
        
        
    }
}
