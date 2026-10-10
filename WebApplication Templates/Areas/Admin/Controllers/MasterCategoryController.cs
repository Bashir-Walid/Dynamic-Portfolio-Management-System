using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterCategoryController : Controller
    {
        IRepository<MasterCategory> repository;

        public MasterCategoryController(IRepository<MasterCategory> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterCategoryFullViewModels
            {
                list = data
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterCategoryViewModels collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    repository.Add(data);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var data = collection.ToModel();

                    data.UpdatedBy = User.Identity?.Name;

                    repository.Update(data);

                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id)
        {
            try
            {
                repository.Changsteates(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterCategoryFullViewModels collection)
        {
            if (collection.DeleteId <= 0)
            {
                return BadRequest();
            }

            repository.Delete(collection.DeleteId);

            return RedirectToAction(nameof(Index));
        }
    }
}