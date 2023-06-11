using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PermitToWorkSystem.Data;
using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Data.Service;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;
using PermitToWorkSystem.Utility;

namespace PermitToWorkSystem.Controllers
{
    public class PermitToWorkFormController : Controller
    {
        private readonly IPermitToWorkService _permitToWorkService;
        private readonly IEmailService _mailService;

        public PermitToWorkFormController(IPermitToWorkService permitToWorkService, IEmailService mailService)
        {
            _permitToWorkService = permitToWorkService;
            _mailService = mailService;
        }


        public IActionResult Create()
        
        
        {
            return View();
        }

        // POST: PermitToWorkForms/Create
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PermitToWorkVM permitToWorkVM)
        {
            var ApproverEmail = "tochind29@gmail.com";
            if (!ModelState.IsValid)
            {
                return View(permitToWorkVM);
            }
             var res =  await _permitToWorkService.AddPermitToWorkAsync(permitToWorkVM);
           
            var baseUrl = $"https://localhost:7269/PermitToWorkForm/PermitToWorkDetails/{res.PermitID}";
            var link = $"{baseUrl}";
            var emailRequest = new EmailMessage(new string[] { ApproverEmail }, $"Permit To Work Request From {permitToWorkVM.Company}", $"use this link to view the request {link}");
            await _mailService.SendEmailAsync(emailRequest);
           
            return RedirectToAction(nameof(FormSubmitted));
        }

        public async Task<IActionResult> PermitToWorkDetails(int id)
        {
                var permDetail = await _permitToWorkService.GetApplicantByIdAsync(id);
                return View(permDetail);
          
        }

        public async Task<IActionResult> FormSubmitted()
        {
            
            return View();

        }

      

    }


}

