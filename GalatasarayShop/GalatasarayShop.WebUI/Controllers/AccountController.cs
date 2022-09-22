using GalatasarayShop.Business.Services;
using GalatasarayShop.Data.Dto;
using GalatasarayShop.Data.Entities;
using GalatasarayShop.WebUI.Extensions;
using GalatasarayShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GalatasarayShop.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService=userService;
        }

        [HttpGet]
        [Route("Hesabim")]
        public IActionResult Index()
        {

            var loggedUserId = User.GetUserId();





            var user = _userService.GetUserById(loggedUserId);

            var viewModel = new AccountViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                City=user.City
               
            };

            return View(viewModel);

           
        }

        [HttpPost]
        public IActionResult Update(AccountViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",formData);
            }

            var user = new UserDto
            {
                Id = formData.Id,
                FirstName = formData.FirstName,
                LastName = formData.LastName,
                Email = formData.Email,
                Address = formData.Address,
                City=formData.City,
                
            };

            _userService.UpdateUser(user);

          
            TempData["UpdateMessage"] = "Profil bilgileri güncellendi.";

            return RedirectToAction("Index");
        }
    }
}
