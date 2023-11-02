using CoreMVCCodeFirst_1.Models.Entities;

namespace CoreMVCCodeFirst_1.Models.Products
{
    //Normalde PageVM'ler Request, Response ve Shared olarak ayrılır.. Aynı zamanda iclerinde Domain entity barındırmazlar...
    public class ProductPageVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }

    }
}
