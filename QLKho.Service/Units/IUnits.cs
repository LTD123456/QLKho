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
        int UpdateRange(ICollection<Unit> listUnit);
        //int AddOrUpdate()
        int Delete(string Id);
        ICollection<Unit> GetAll();
        Unit GetByKey(string Key);
        PageViewModel<Unit> GetAllPaging(string key = "", int pageIndex = 1, int pageSize = 50);
    }
}
