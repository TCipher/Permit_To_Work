using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly IEncryptDecryptService _encrypt;
        private readonly INotyfService _notfy;
        public PermitToWorkFormController(IPermitToWorkService permitToWorkService, IEmailService mailService, IEncryptDecryptService encrypt, INotyfService notyf)
        {
            _permitToWorkService = permitToWorkService;
            _mailService = mailService;
           _encrypt = encrypt;
            _notfy = notyf;
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

            var res = await _permitToWorkService.AddPermitToWorkAsync(permitToWorkVM);
            
            // Encrypt the ID using AES
            var encryptedID = _encrypt.EncryptID(res.PermitID);

            var baseUrl = $"https://localhost:7269/PermitToWorkForm/PermitToWorkDetails/{encryptedID}";
            var link = $"{baseUrl}";
            var emailRequest = new EmailMessage(new string[] { ApproverEmail }, $"Permit To Work Request From {permitToWorkVM.CompanyName}", $"Use this link to view the request: {link}");
            await _mailService.SendEmailAsync(emailRequest);
           
            return RedirectToAction(nameof(FormSubmitted));
        }

        public async Task<IActionResult> PermitToWorkDetails(string id)
        {
            byte[] decodedBytes;
            try
            {
                decodedBytes = Convert.FromBase64String(id);
            }
            catch (FormatException)
            {
                // Handle invalid Base64 string
                return BadRequest();
            }
            // Decrypt the ID using AES
            var decryptedID = _encrypt.DecryptID(id);

            if (!int.TryParse(decryptedID, out int permitID))
            {
                // Handle invalid ID
                return BadRequest();
            }

            var permDetail = await _permitToWorkService.GetApplicantByIdAsync(permitID);
            return View(permDetail);

           
        }

      
        public IActionResult FormSubmitted()
        {
            _notfy.Success("Your Request to work permit has been sent successfully to the next level Approval.", 10);
            return View();
        }
    }
}
