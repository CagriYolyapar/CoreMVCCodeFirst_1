using CoreMVCCodeFirst_1.Models.Categories.PureVms;
using CoreMVCCodeFirst_1.Models.Categories.ResponseModels;
using CoreMVCCodeFirst_1.Models.Entities;

namespace CoreMVCCodeFirst_1.Models.MapperClasses
{
    public static class CategoryMapper
    {

        public static CategoryResponseModel GetCategoryResponseModel(Category category)
        {
            return new()
            {
                ID = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public static CategoryVM GetCategoryVM(Category category)
        {
            return new()
            {
                ID = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }
    }
}
