using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterPositionsController : Controller
    {
        IRepository<MasterPositions> repository;

        public MasterPositionsController(IRepository<MasterPositions> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();
            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterPositionsFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPositionsViewModels collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var alldata = repository.GetAll();

                    if (collection.IsPrimary && alldata.Any(x => x.IsPrimary))
                    {
                        ModelState.AddModelError("", "Only one Positions Allowed to be Primary");
                        return RedirectToAction(nameof(Index));
                    }

                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    repository.Add(data);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var alldata = repository.GetAll();

                    if (collection.IsPrimary && alldata.Any(x => x.IsPrimary && x.Id != collection.Id))
                    {
                        ModelState.AddModelError("", "Only one Positions Allowed to be Primary");
                        return RedirectToAction(nameof(Index));
                    }

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
                var data = repository.GetAll().FirstOrDefault(x => x.Id == id);

                if (data == null)
                {
                    return BadRequest();
                }

                if (data.IsActive)
                {
                    data.IsActive = false;
                }
                else
                {
                    data.IsActive = true;
                }

                data.UpdatedBy = User.Identity?.Name;

                repository.Update(data);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePrimary(int id)
        {
            try
            {
                var data = repository.GetAll().FirstOrDefault(x => x.Id == id);

                if (data == null)
                {
                    return BadRequest();
                }

                if (data.IsPrimary)
                {
                    data.IsPrimary = false;
                }
                else
                {
                    var alldata = repository.GetAll();

                    if (alldata.Any(x => x.IsPrimary && x.Id != id))
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    data.IsPrimary = true;
                }

                data.UpdatedBy = User.Identity?.Name;

                repository.Update(data);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterPositionsFullViewModels collection)
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