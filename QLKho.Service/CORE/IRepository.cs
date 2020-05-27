using QLKho.Service.DTOCommons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QLKho.WebCore.CORE
{
    public interface IRepository
    {
        int Add<T>(T entity) where T : class;
        int Update<T>(T entity) where T : class;
        int AddRange<T>(ICollection<T> listEntity) where T : class;
        //int AddOrUpdate()
        int Delete<T>(T entity) where T : class;
        IEnumerable<T> GetAll<T>() where T : class;
        T GetByKey<T>(string Id) where T : class;
        PageViewModel<T> GetAllPaging<T>(string key = "", int pageIndex = 1, int pageSize = 50) where T : class;
    }
}
