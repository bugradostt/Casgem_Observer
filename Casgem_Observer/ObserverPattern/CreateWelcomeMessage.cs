using Casgem_Observer.Dal;

namespace Casgem_Observer.ObserverPattern
{
	public class CreateWelcomeMessage : IObserver, ICreateWelcomeMessage
	{
		readonly IServiceProvider _serviceProvider;
		Context c = new Context();

		public CreateWelcomeMessage(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public void CreateNewUser(AppUser appUser)
		{
			c.WelcomeMessage.Add(new WelcomeMessage
			{
				NameSurname = appUser.Name + ' ' + appUser.Surname,
				Content = "Dergi bültenimize abone olduğunuz için teşekkür ederiz, hoşgeldiniz"
			});
			c.SaveChanges();
		}
	}
}
