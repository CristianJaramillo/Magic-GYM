using Magic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Core
{
    /// <summary>
    /// Abtraction layer between functional and database context
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets <see cref="People"/> context
        /// </summary>
        IUserRepository Users { get; }

        int Complete();
    }
}
