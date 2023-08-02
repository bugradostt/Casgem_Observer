using Casgem_Observer.Dal;

namespace Casgem_Observer.ObserverPattern
{
	public interface IObserver
	{
		void CreateNewUser(AppUser appUser);
	}
}
