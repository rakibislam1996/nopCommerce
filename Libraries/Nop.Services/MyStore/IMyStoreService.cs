using Nop.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.MyStore;

namespace Nop.Services.MyStore
{
    public interface IMyStoreService
    {
        IList<Nop.Core.Domain.MyStore.MyStore> GetMyStores();
        public IList<Nop.Core.Domain.MyStore.MyStore> GetMyStores(int count);
        public Nop.Core.Domain.MyStore.MyStore GetMyStoreById(int StoreId);
        public void AddMyStore(Core.Domain.MyStore.MyStore newStore);
        public void EditMyStore(Nop.Core.Domain.MyStore.MyStore myStore);
        public void DeleteMyStore(Nop.Core.Domain.MyStore.MyStore myStore);
        public int CountMyStores();
    }
}
