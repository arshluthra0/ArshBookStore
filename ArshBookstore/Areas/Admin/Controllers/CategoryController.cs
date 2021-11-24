using ArshBooks.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArshBookstore.Areas.Admin.Controllers
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

        #region #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
