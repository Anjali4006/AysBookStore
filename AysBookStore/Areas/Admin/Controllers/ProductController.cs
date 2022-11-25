using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.DataAccess.Repository;
using AysBookStore.DataAccess;
using AysBookStore.Areas;
using AysBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AysBooks1.Models;
//using AysBooks.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace AysBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;      // to upload images on the server inside wwwroot

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        /* 
       public IActionResult Upsert(int? id)        // action method for upsert
       {
           Product product = new Product();     //using AysBooks.Model

           if (id == null)
           {
               //this is for create
               return View(product);
           }

           //this is for edit
           product = _unitOfWork.Product.Get(id.GetValueOrDefault());

           if (product == null)
           {
               return NotFound();
           }

           return View(product);
       }
        */ //Code to be removed 

        public IActionResult Upsert(int? id)        // get action mwthod for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };      // using "AysBooks1.Models;

            if (id == null)
            {
                // this is for create
                return View(productVM);
            }

            // this for the edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
        }



        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)   // check all variables in the model (e.g. Name Required) to increase security
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);
                    //_unitOfWork.save();
                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));     // to see all the categories
            }

            return View(product);
        }

        // API calls here for Delete
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category, CoverType");
            return Json(new { data = allObj });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);

            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting!!" });
            }

            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful!!" });
        }
        #endregion
    }




}