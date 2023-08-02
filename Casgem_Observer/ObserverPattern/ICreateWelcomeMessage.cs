using Casgem_Observer.Dal;

namespace Casgem_Observer.ObserverPattern
{
	public interface ICreateWelcomeMessage
	{
		void CreateNewUser(AppUser appUser);
	}
}