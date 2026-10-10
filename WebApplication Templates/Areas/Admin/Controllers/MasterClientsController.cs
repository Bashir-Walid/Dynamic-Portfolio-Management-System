using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Helpers.File;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterClientsController : Controller
    {
        IRepository<MasterClients> repository;
        IFileHelper FileHelper;

        public MasterClientsController(IRepository<MasterClients> repository, IFileHelper FileHelper)
        {
            this.repository = repository;
            this.FileHelper = FileHelper;
        }

        // GET: MasterClientsController
        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();
            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterClientsFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterClientsViewModels collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    data.ImageURL = FileHelper.SaveImge(
                        collection.ImageFile,
                        "MasterClientsImage"
                    );

                    if (data.ImageURL != "Error")
                    {
                        repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image Are Required");
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    var oldData = repository.GetAll()
                        .FirstOrDefault(x => x.Id == collection.Id);

                    if (oldData == null)
                    {
                        return BadRequest();
                    }

                    var data = collection.ToModel();

                    data.UpdatedBy = User.Identity?.Name;

                    data.ImageURL = oldData.ImageURL;

                    if (collection.ImageFile != null)
                    {
                        var newImage = FileHelper.SaveImge(
                            collection.ImageFile,
                            "MasterClientsImage"
                        );

                        if (newImage != "Error")
                        {
                            data.ImageURL = newImage;
                        }
                    }

                    repository.Update(data);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
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
        public ActionResult Delete(int id, MasterClientsFullViewModels collection)
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