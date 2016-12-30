using Magic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.Repositories;
using Magic.Persistence.Repositories;

namespace Magic.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public IUserRepository Users { get; }

        public UnitOfWork(PlutoContext context)
        {
            _context = context;

            Users = new UserRepository(_context);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
