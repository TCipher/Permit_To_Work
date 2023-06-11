using Microsoft.AspNetCore.Mvc;
using PermitToWorkSystem.Data;
using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Data.Service;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;
using PermitToWorkSystem.Utility;

namespace PermitToWorkSystem.Controllers
{
    public class SiteCheckerController : Controller
    {
        private readonly ISiteCheckerService _siteCheckerService;
        private readonly IEmailService _mailService;
        private readonly IPermitToWorkService _permitToWorkService;
        public SiteCheckerController(ISiteCheckerService siteCheckerService, IEmailService mailService, IPermitToWorkService permitToWorkService)
        {
            _siteCheckerService = siteCheckerService;
            _mailService = mailService;
            _permitToWorkService = permitToWorkService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult>Index(SiteCheckerVM siteCheckerVM)
        {
           //var res = await _permitToWorkService.AddPermitToWorkAsync(PM);
           var ApproverEmail = "tochind29@gmail.com";
            if (!ModelState.IsValid)
            {
                return View(siteCheckerVM);
            }
            var result = await _siteCheckerService.AddSiteCheckData(siteCheckerVM);

            var baseUrl = $"https://localhost:7269/SiteChecker/Approved/{result.Id}";
            var link = $"{baseUrl}";
            var emailRequest = new EmailMessage(new string[] { ApproverEmail }, $"you permit to work request was granted", $"use this link to see veiw details of your approval {link}");
            await _mailService.SendEmailAsync(emailRequest);

            return RedirectToAction(nameof(FormSubmitted));
        }

        public async Task<IActionResult> Approved()
        {
            var approvedInfo = await _permitToWorkService.GetAllAsync();
            return View(approvedInfo);
        }
        public async Task<IActionResult> FormRejected(SiteCheckerVM siteCheckerVM)
        {
            var ApproverEmail = "tochind29@gmail.com";
          
            //var result = await _siteCheckerService.AddSiteCheckData(siteCheckerVM);

            var baseUrl = $"https://localhost:7269/SiteChecker/FormRejectedVeiw";
            var link = $"{baseUrl}";
            var emailRequest = new EmailMessage(new string[] { ApproverEmail }, $"you permit to work request was Rejected", $"you can use this link for more details {link}");
            await _mailService.SendEmailAsync(emailRequest);

            return RedirectToAction(nameof(FormSubmitted));
        }

        public async Task<IActionResult> FormRejectedVeiw()
        {

            return View();

        }
        public async Task<IActionResult> FormSubmitted()
        {

            return View();

        }
    }
}
