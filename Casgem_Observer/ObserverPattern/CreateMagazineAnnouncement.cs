using Casgem_Observer.Dal;

namespace Casgem_Observer.ObserverPattern
{
	public class CreateMagazineAnnouncement : IObserver
	{
		readonly IServiceProvider _serviceProvider;
		Context c = new Context();

		public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public void CreateNewUser(AppUser appUser)
		{
			c.UserProcesses.Add(new UserProcess
			{
				NameSurname = appUser.Name + ' ' + appUser.Surname,
				Magazine = "Spor Dergisi",
				Content = "Spor Dergimizin ağustos 2023 sayısı bayimize geldi"
			}
				);
			c.SaveChanges();
		}
	}
}
