using Microsoft.AspNetCore.Authorization;
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
    public class MasterPortfolioController : Controller
    {
        IRepository<MasterPortfolio> repository;
        IRepository<MasterCategory> _repository;
        IFileHelper FileHelper;

        public MasterPortfolioController(
            IRepository<MasterPortfolio> repository,
            IRepository<MasterCategory> _repository,
            IFileHelper fileHelper)
        {
            this.repository = repository;
            this._repository = _repository;
            FileHelper = fileHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();
            var data2 = _repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new MasterPortfolioFullViewModels
            {
                listet = data2,
                list = data
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPortfolioViewModels collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    var image = FileHelper.SaveImge(
                        collection.ImageFile,
                        "MasterPortfolio"
                    );

                    if (image != "Error")
                    {
                        data.ThumbnailImg = image;
                        data.ViewImg = image;

                        repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image Is Required");

                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    var oldData = repository.GetAll()
                        .FirstOrDefault(x => x.Id == collection.Id);

                    if (oldData == null)
                    {
                        return NotFound();
                    }

                    var data = collection.ToModel();

                    data.UpdatedBy = User.Identity?.Name;

                    data.ThumbnailImg = oldData.ThumbnailImg;
                    data.ViewImg = oldData.ViewImg;

                    if (collection.ImageFile != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFile,
                            "MasterPortfolio"
                        );

                        if (image != "Error")
                        {
                            data.ThumbnailImg = image;
                            data.ViewImg = image;
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
        public ActionResult Delete(int id, MasterPortfolioFullViewModels collection)
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