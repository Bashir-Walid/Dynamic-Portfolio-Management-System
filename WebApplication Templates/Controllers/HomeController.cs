using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication_Templates.Controllers
{
    public class HomeController : Controller
        
    {
        private readonly ILogger <HomeController> _logger;
        IRepository<MasterAbout> MasterAboutRepository;
        IRepository<MasterPositions> MasterPositionsRepository;
        IRepository<MasterSocialMedia> MasterSocialMediaRepository;
        IRepository<MasterTitles> MasterTitlesRepository;
        IRepository<MasterServices> MasterServicesRepository;
        IRepository<MasterTestimonials> MasterTestimonialsRepository;
        IRepository<MasterClients> MasterClientsRepository;
        IRepository<MasterPlans> MasterPlansRepository;
        IRepository<MasterPlanItems> MasterPlanItemsRepository;
        IRepository<MasterFacts> MasterFactsRepository;
        IRepository<MasterEducation> MasterEducationRepository;
        IRepository<MasterExperience> MasterExperienceRepository;
        IRepository<MasterSkills> MasterSkillsRepository;
        IRepository<MasterCertificates> MasterCertificatesRepository;
        IRepository<MasterCategory> MasterCategoryRepository;
        IRepository<MasterPortfolio> MasterPortfolioRepository;
        IRepository<MasterContactUs> MasterContactUsRepository;
        IRepository<MasterTransactionContactUs> MasterTransactionContactUsRepository;
        private readonly IRepository<MasterTransactionContactUs> _transactionContactUs;


        public HomeController(IRepository<MasterPositions> masterPositionsRepository, IRepository<MasterSocialMedia> masterSocialMediaRepository, IRepository<MasterTitles> masterTitlesRepository, IRepository<MasterAbout> masterAboutRepository = null, ILogger<HomeController> logger = null, IRepository<MasterServices> masterServicesRepository = null, IRepository<MasterTestimonials> masterTestimonialsRepository = null, IRepository<MasterClients> masterClientsRepository = null, IRepository<MasterPlans> masterPlansRepository = null, IRepository<MasterPlanItems> masterPlanItemsRepository = null, IRepository<MasterFacts> masterFactsRepository = null, IRepository<MasterEducation> masterEducationRepository = null, IRepository<MasterExperience> masterExperienceRepository = null, IRepository<MasterSkills> masterSkillsRepository = null, IRepository<MasterCertificates> masterCertificatesRepository = null, IRepository<MasterCategory> masterCategoryRepository = null, IRepository<MasterPortfolio> masterPortfolioRepository = null, IRepository<MasterContactUs> masterContactUsRepository = null, IRepository<MasterTransactionContactUs> masterTransactionContactUsRepository = null, IRepository<MasterTransactionContactUs> transactionContactUs = null)
        {
            _logger = logger;
            MasterPositionsRepository = masterPositionsRepository;
            MasterSocialMediaRepository = masterSocialMediaRepository;
            MasterTitlesRepository = masterTitlesRepository;
            MasterAboutRepository = masterAboutRepository;
            MasterServicesRepository = masterServicesRepository;
            MasterTestimonialsRepository = masterTestimonialsRepository;
            MasterClientsRepository = masterClientsRepository;
            MasterPlansRepository = masterPlansRepository;
            MasterPlanItemsRepository = masterPlanItemsRepository;
            MasterFactsRepository = masterFactsRepository;
            MasterEducationRepository = masterEducationRepository;
            MasterExperienceRepository = masterExperienceRepository;
            MasterSkillsRepository = masterSkillsRepository;
            MasterCertificatesRepository = masterCertificatesRepository;
            MasterCategoryRepository = masterCategoryRepository;
            MasterPortfolioRepository = masterPortfolioRepository;
            MasterContactUsRepository = masterContactUsRepository;
            MasterTransactionContactUsRepository = masterTransactionContactUsRepository;
            _transactionContactUs = transactionContactUs;
        }



        public IActionResult Index()
        {
            var data = new HomeViewModels
            {
                MasterAbout=MasterAboutRepository.GetAllClint()?.FirstOrDefault()?.ToViewModel(),
                MasterPositions = MasterPositionsRepository.GetAllClint()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClint()?.ToViewModelList(),
                MasterTitles = MasterTitlesRepository.GetAllClint()?.ToViewModelList(),
                MasterServices = MasterServicesRepository.GetAllClint()?.ToViewModelList(),
                MasterTestimonials = MasterTestimonialsRepository.GetAllClint()?.ToViewModelList(),
                MasterClients = MasterClientsRepository.GetAllClint()?.ToViewModelList(),
                MasterPlanItems = MasterPlanItemsRepository.GetAllClint()?.ToViewModelList(),
                MasterPlans = MasterPlansRepository.GetAllClint()?.ToViewModelList(),
                MasterFacts = MasterFactsRepository.GetAllClint()?.ToViewModelList(),
                MasterEducation = MasterEducationRepository.GetAllClint()?.ToViewModelList(),
                MasterExperience = MasterExperienceRepository.GetAllClint()?.ToViewModelList(),
                MasterSkills = MasterSkillsRepository.GetAllClint()?.ToViewModelList(),
                MasterCertificates = MasterCertificatesRepository.GetAllClint()?.ToViewModelList(),
                MasterCategory = MasterCategoryRepository.GetAllClint()?.ToViewModelList(),
                MasterPortfolio = MasterPortfolioRepository.GetAllClint()?.ToViewModelList(),
                MasterContactUs = MasterContactUsRepository.GetAllClint()?.ToViewModelList(),
                MasterTransactionContactUs = MasterTransactionContactUsRepository.GetAllClint()?.ToViewModelList(),


            };
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public IActionResult SendMessage(MasterTransactionContactUsFullViewModel model)
        {
            var data = new MasterTransactionContactUs
            {
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message,
                Datesent = DateTime.Now
            };

            _transactionContactUs.Add(data);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
