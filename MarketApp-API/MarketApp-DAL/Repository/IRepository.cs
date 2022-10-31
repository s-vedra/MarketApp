using MarketApp_DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_DAL.Repository
{
    public interface IRepository<T, ID>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(ID id);
    }
}
