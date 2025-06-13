using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
