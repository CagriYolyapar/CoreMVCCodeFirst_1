using CoreMVCCodeFirst_1.Models.Categories.RequestModels;

namespace CoreMVCCodeFirst_1.Models.Categories.PageVms
{
    //Category Controller'i icin Request durumlarında model icerisinde veri paketlemek icin kullanılmak adına olusturulmus bir sınıftır.
    public class CategoryRequestPageVM
    {
        public CreateCategoryRequestModel Category { get; set; }
     
    }
}
