using Casgem_Observer.Dal;

namespace Casgem_Observer.ObserverPattern
{
	public class CreateDiscountCode : IObserver
	{
		readonly IServiceProvider _serviceProvider;
		Context c = new Context();

		public CreateDiscountCode(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public void CreateNewUser(AppUser appUser)
		{
			c.Discounts.Add(new Discount
			{
				DiscountCode="DERGIAGUSTOS",
				DiscountAmount=25,
				DiscountCodeStatus = true
			});
			c.SaveChanges();
		}
	}
}
