using Magic.Core.Repositories;
using Magic.Data.Models;

namespace Magic.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category, int>, ICategory
    {
        public CategoryRepository(PlutoContext context) : base(context)
        {

        }
    }
}
