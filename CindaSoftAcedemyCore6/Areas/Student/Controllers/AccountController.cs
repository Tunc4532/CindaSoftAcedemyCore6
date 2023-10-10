using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CindaSoftAcedemyCore6.Areas.Student.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CindaSoftAcedemyCore6.Areas.Student.Controllers
{
    [Area("Student")]
    [AllowAnonymous]

    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Payment(AccountViewModel model)
        {
            var valuesender = _accountService.TGetByID(model.SenderId);
            var valuereceiver = _accountService.TGetByID(model.ReceiverId);

            valuesender.Balance -= model.Amount;
            valuereceiver.Balance += model.Amount;

            List<Account> modifiedAccount = new List<Account>()
            {
                valuesender,
                valuereceiver
            };

            _accountService.TMultiUpdate(modifiedAccount);
            return View();
        }
    }
}
