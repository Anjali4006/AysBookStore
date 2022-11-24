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

    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)        // action method for upsert
        {
            CoverType covertype = new CoverType();     //using AysBooks1.Model

            if (id == null)
            {
                //for create
                return View(covertype);
            }

            //for edit
            covertype = _unitOfWork.CoverType.Get(id.GetValueOrDefault());

            if (covertype == null)
            {
                return NotFound();
            }

            return View(covertype);
        }


        // API calls here
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)   // check all variables in the model (e.g. Name Required) to increase security
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.CoverType.Add(covertype);
                    //_unitOfWork.save();
                }
                else
                {
                    _unitOfWork.CoverType.Update(covertype);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));     // to see all types of covertypes
            }

            return View(covertype);
        }


        // API calls here for Delete
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);

            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting!!" });
            }

            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful!!" });
        }
        #endregion
    }
}

