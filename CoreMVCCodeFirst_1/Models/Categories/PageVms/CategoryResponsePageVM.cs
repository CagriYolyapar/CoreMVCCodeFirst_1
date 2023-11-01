using CoreMVCCodeFirst_1.Models.Categories.ResponseModels;

namespace CoreMVCCodeFirst_1.Models.Categories.PageVms
{
    public class CategoryResponsePageVM
    {
        public List<CategoryResponseModel> Categories { get; set; }
        public CategoryResponseModel Category { get; set; }

    }
}
