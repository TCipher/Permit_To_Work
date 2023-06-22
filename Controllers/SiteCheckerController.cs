using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService _notfy;
        public SiteCheckerController(ISiteCheckerService siteCheckerService, IEmailService mailService, IPermitToWorkService permitToWorkService, INotyfService notyf)
        {
            _siteCheckerService = siteCheckerService;
            _mailService = mailService;
            _permitToWorkService = permitToWorkService;
            _notfy = notyf;

        }

        public IActionResult Index()
        {
            _notfy.Success("Your Request to work permit has been Approved .", 10);
           
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

        public IActionResult FormRejectedVeiw()
        {
            _notfy.Error("Your Request to work permit was Rejected. please call (234)768430734 for more details");

            return View();

        }
        public IActionResult FormSubmitted()
        {

            return View();

        }
    }
}
