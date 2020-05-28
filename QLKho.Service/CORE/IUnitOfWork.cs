using QLKho.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.WebCore.CORE
{
    public interface IUnitOfWork:IDisposable
    {
        QLKhoDbContext context { get; }
        void SaveChages();
    }
}
