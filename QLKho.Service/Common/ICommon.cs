using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Service.Common
{
    public interface ICommon<T> where T:class
    {
        IList<T> getAll(string tableName,string ArrJoin, string ArrKey, string Condition);
    }
}
