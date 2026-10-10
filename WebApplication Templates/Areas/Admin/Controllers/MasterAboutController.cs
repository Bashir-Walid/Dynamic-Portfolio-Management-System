using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Helpers.File;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterAboutController : Controller
    {
        IRepository<MasterAbout> repository;
        IFileHelper FileHelper;

        public MasterAboutController(IRepository<MasterAbout> repository, IFileHelper FileHelper)
        {
            this.repository = repository;
            this.FileHelper = FileHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();
            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterAboutFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterAboutViewModels collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var alldata = repository.GetAll();

                    if (alldata.Any())
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    data.CVUrl = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                    data.ImageURL = FileHelper.SaveImge(collection.ImageFile, "MasterAboutImage");

                    if (data.ImageURL != "Error" && data.CVUrl != "Error")
                    {
                        repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image And Cv Are Required");
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    var oldData = repository.GetAll().FirstOrDefault(x => x.Id == collection.Id);

                    if (oldData == null)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    var data = collection.ToModel();

                    data.UpdatedBy = User.Identity?.Name;
                    data.ImageURL = oldData.ImageURL;
                    data.CVUrl = oldData.CVUrl;

                    if (collection.ImageFile != null)
                    {
                        data.ImageURL = FileHelper.SaveImge(collection.ImageFile, "MasterAboutImage");
                    }

                    if (collection.CVFile != null)
                    {
                        data.CVUrl = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                    }

                    repository.Update(data);
                }

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
        public ActionResult Delete(int id, MasterAboutFullViewModels collection)
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