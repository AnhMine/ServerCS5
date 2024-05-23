using ServerCS5.DTOs;
using ServerCS5.Models;

namespace ServerCS5.Service.CategoryService
{
    public interface ICategoryService
    {
        Task<string> AddCategory(string model);
        List<CategoryDTOs> GetCategories();
        Category ModelItem  (string model);
        List<Product> GetCategoryById(int id);
    }
}
