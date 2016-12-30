using Magic.Data.Models;
using System.Data.Entity;

namespace Magic.Persistence
{
    public partial class PlutoContext : DbContext
    {

        public PlutoContext() : base(nameOrConnectionString: "Development")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }

    }

}