using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Helpers.Email;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterPlansController : Controller
    {
        IRepository<MasterPlans> repository;
        IEmailHelper emailHelper;

        public MasterPlansController(IRepository<MasterPlans> repository, IEmailHelper emailHelper)
        {
            this.repository = repository;
            this.emailHelper = emailHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();
            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterPlansFullViewModels
            {
                list = data
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPlansViewModels collection)
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
        public ActionResult ChangeSuggested(int id)
        {
            try
            {
                var data = repository.GetAll().FirstOrDefault(x => x.Id == id);

                if (data == null)
                {
                    return BadRequest();
                }

                if (data.IsSuggested)
                {
                    data.IsSuggested = false;
                }
                else
                {
                    data.IsSuggested = true;
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
        public ActionResult Delete(int id, MasterPlansFullViewModels collection)
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