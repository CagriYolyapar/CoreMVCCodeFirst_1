using CoreMVCCodeFirst_1.Models.Categories.PageVms;
using CoreMVCCodeFirst_1.Models.Categories.RequestModels;
using CoreMVCCodeFirst_1.Models.Categories.ResponseModels;
using CoreMVCCodeFirst_1.Models.ContextClasses;
using CoreMVCCodeFirst_1.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCCodeFirst_1.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;

        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel category)
        {
            //Bir class'ın bilgilerini baska bir class'a aktarmaya Map'leme işlemi denir...Database Domain Entity kabul eder...Dolayısıyla biz aldıgımız CreateCategoryRequestModel icerisindeki bilgileri Category tipinde bir instance alıp o instance'in özellikleri icerisine attık ki database'e Category ekleyebilelim...Cünkü _db.Categories.Add() metodu sadece Category tipinde bir nesne kabul eder... Yani RequestModel'imizi Doman Entity'e mapledik...


            Category c = new()
            {
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            _db.Categories.Add(c);
            _db.SaveChanges();
            return View();
        }


        public IActionResult GetCategories()
        {
            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel 
            { 
                CategoryName = x.CategoryName,
                Description = x.Description 
            }).ToList();

            CategoryResponsePageVM cpvm = new CategoryResponsePageVM
            {
                Categories = categories
            };

            return View(cpvm);
        }
    }
}
