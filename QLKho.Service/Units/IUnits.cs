using QLKho.Data.Entities;
using QLKho.Service.DTOCommons;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Service.Units
{
    public interface IUnits
    {
        int Add(Unit unit);
        int Update(Unit unit);
        int UpdateRange(IEnumerable<Unit> listUnit);
        //int AddOrUpdate()
        int Delete(Unit unit);
        IEnumerable<Unit> GetAll();
        Unit GetByKey(string unit);
        PageViewModel<Unit> GetAllPaging(string key = "", int pageIndex = 1, int pageSize = 50);
    }
}
