using QLKho.Data.EF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKho.WebCore.CORE
{
    public class Repository: IRepository
    {
        private readonly QLKhoDbContext _context;

        public Repository(QLKhoDbContext context)
        {
            _context = context;
        }
        public int Add<T>(T entity) where T : class
        {
            _context.Add<T>(entity);
            return 1;
        }

        public int Delete<T>(T entity) where T : class
        {
            _context.Remove<T>(entity);
            return 1;
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _context.Query<T>().ToList();
        }

        public Service.DTOCommons.PageViewModel<T> GetAllPaging<T>(string key = "", int pageIndex = 1, int pageSize = 50) where T : class
        {
            throw new NotImplementedException();
        }
        public T GetByKey<T>(string Id) where T : class
        {
            T entity = _context.Find<T>(Id);
            return entity;
        }

        public int Update<T>(T entity) where T : class
        {
            _context.Update<T>(entity);
            return 1;
        }

        public int AddRange<T>(ICollection<T> listEntity) where T : class
        {
            foreach(var item in listEntity)
            {
                _context.Add<T>(item);
            }
            return 1;
        }
    }
}
