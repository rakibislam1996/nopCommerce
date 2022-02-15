using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Data;


namespace Nop.Services.MyStore
{
    public class MyStoreService : IMyStoreService
    {
        private readonly IRepository<Nop.Core.Domain.MyStore.MyStore> _myStoreRepository;
        public MyStoreService(IRepository<Nop.Core.Domain.MyStore.MyStore> myStoreRepository)
        {
            _myStoreRepository = myStoreRepository;
        }
        public IList<Nop.Core.Domain.MyStore.MyStore> GetMyStores()
        {
            var query = _myStoreRepository.Table;
            
            query = from o in query
                    select o;

            return query.ToList();
        }
        public IList<Nop.Core.Domain.MyStore.MyStore> GetMyStores(int count)
        {
            var query = _myStoreRepository.Table;

            query = (from o in _myStoreRepository.Table
                    select o).Take(count);
            return query.ToList();
        }
        public Nop.Core.Domain.MyStore.MyStore GetMyStoreById(int StoreId)
        {
            var query = _myStoreRepository.Table;

            query = from o in _myStoreRepository.Table
                        where o.Id == StoreId
                    select o;
            if (query.Count() > 0)
                return query.First();
            else
                return null;
        }
        public int CountMyStores()
        {
            return _myStoreRepository.Table.Count();
        }
        public void AddMyStore(Nop.Core.Domain.MyStore.MyStore myStore)
        {
            _myStoreRepository.Insert(myStore);
        }
        public void EditMyStore(Nop.Core.Domain.MyStore.MyStore myStore)
        {
            _myStoreRepository.Update(myStore);
        }
        public void DeleteMyStore(Nop.Core.Domain.MyStore.MyStore myStore)
        {
            _myStoreRepository.Delete(myStore);
        }

    }
}
