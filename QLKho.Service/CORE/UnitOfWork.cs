using QLKho.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.WebCore.CORE
{
    public class UnitOfWork : IUnitOfWork
    {
        public QLKhoDbContext context { get; }
        public UnitOfWork(QLKhoDbContext _context)
        {
            context = _context;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public void SaveChages()
        {
            this.context.SaveChanges();
        }
    }
}
