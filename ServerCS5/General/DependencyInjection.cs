using ServerCS5.Data.CategoryData;
using ServerCS5.Data.ProductData;
using ServerCS5.Service.CategoryService;
using ServerCS5.Service.ProductService;

namespace ServerCS5.General
{
    public static class DependencyInjection
    {
        public static void AddServices (this IServiceCollection services)
        {
            services.AddScoped<ICategoryService,CCategoryService>();
            services.AddScoped<IProductService,CProductService>();
            services.AddScoped<IProductData,CProductData>();
            services.AddScoped<ICategoryData,CCategoryData>();
        }
    }
}
