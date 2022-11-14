using AysBooks1.DataAccess.Repository.IRepository;
using AysBooks1.DataAccess.Repository;
using AysBookStore.DataAccess;
using AysBookStore.Areas;
using AysBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AysBooks1.Models;

namespace AysBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)        // action method for upsert
        {
            Category category = new Category();     //using AysBooks1.Model

            if (id == null)
            {
                //for create
                return View(category);
            }

            //for edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }


        // API calls here
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)   // check all variables in the model (e.g. Name Required) to increase security
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    //_unitOfWork.save();
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));     // to see all the categories
            }

            return View(category);
        }


        // API calls here for Delete
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);

            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting!!" });
            }

            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful!!" });
        }
        #endregion
    }
}
