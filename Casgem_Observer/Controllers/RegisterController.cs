using Casgem_Observer.Dal;
using Casgem_Observer.Models;
using Casgem_Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_Observer.Controllers
{
	public class RegisterController : Controller
	{
		readonly UserManager<AppUser> _userManager;
		readonly ObserverObject _observerObject;

		public RegisterController(UserManager<AppUser> userManager, ObserverObject observerObject)
		{
			_userManager = userManager;
			_observerObject = observerObject;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(RegisterViewModel p)
		{
			var appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				City = p.City,
				Email = p.Email,
				District = p.District,
				UserName = p.UserName,

			};
			var result = await _userManager.CreateAsync(appUser,p.Password);
			if (result.Succeeded)
			{
				_observerObject.NotifyObserver(appUser);
				return View();
			}
			return View();
		}
	}
}
