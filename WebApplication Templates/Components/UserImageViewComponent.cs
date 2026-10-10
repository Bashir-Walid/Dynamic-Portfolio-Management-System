using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Templates.Data;

namespace WebApplication_Templates.ViewComponents
{
    public class UserImageViewComponent : ViewComponent
    {
        private readonly DataDbContext _context;

        public UserImageViewComponent(DataDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string cssClass = "")
        {
            var imageUrl = await _context.MasterAbout
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .Select(x => x.ImageURL)
                .FirstOrDefaultAsync();

            ViewBag.CssClass = cssClass;

            return View("Default", imageUrl);
        }
    }
}