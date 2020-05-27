using QLKho.Data.Entities;
using QLKho.Service.DTOCommons;
using QLKho.Service.Units;
using QLKho.WebCore.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.WebCore.Units
{
    public class Units : IUnits
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;
        public Units(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public int Add(Unit unit)
        {
            _repository.Add<Unit>(unit);
            _unitOfWork.SaveChages();
            return 1;
        }

        public int Delete(Unit unit)
        {
            _repository.Delete<Unit>(unit);
            _unitOfWork.SaveChages();
            return 1;
        }

        public IEnumerable<Unit> GetAll()
        {
            var list =  _repository.GetAll<Unit>();
            return list;
        }

        public PageViewModel<Unit> GetAllPaging(string key = "", int pageIndex = 1, int pageSize = 50)
        {
            throw new NotImplementedException();
        }

        public Unit GetByKey(string unit)
        {
            
            return _repository.GetByKey<Unit>(unit);
        }

        public int Update(Unit unit)
        {
            _repository.Update<Unit>(unit);
            return 1;
        }

        public int UpdateRange(IEnumerable<Unit> listUnit)
        {
            throw new NotImplementedException();
        }
    }
}
