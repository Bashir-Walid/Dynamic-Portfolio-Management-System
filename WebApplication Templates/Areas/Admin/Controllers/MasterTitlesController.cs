using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterTitlesController : Controller
    {
        IRepository<MasterTitles> repository;

        public MasterTitlesController(IRepository<MasterTitles> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterTitlesFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterTitlesViewModels collection)
        {
            try
            {
                if (collection.Id <= 0)
                {
                    return RedirectToAction(nameof(Index));
                }

                var oldData = repository.GetAll().FirstOrDefault(x => x.Id == collection.Id);

                if (oldData == null)
                {
                    return BadRequest();
                }

                oldData.Title = collection.Title;
                oldData.UpdatedBy = User.Identity?.Name;

                repository.Update(oldData);

                return RedirectToAction(nameof(Index));
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
        public ActionResult Delete(int id, MasterTitlesFullViewModels collection)
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