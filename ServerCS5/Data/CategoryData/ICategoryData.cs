using ServerCS5.Models;

namespace ServerCS5.Data.CategoryData
{
    public interface ICategoryData
    {
        List<Category> GetAllCategory();
        List<Product> GetProductsByCategoryId(int id);
    }
}
