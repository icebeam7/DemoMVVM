using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DemoMVVM.ViewModels
{
	public partial class ProductSimpleViewModel : ObservableObject
	{
		[ObservableProperty]
		string name;

		[ObservableProperty]
		double price;

		[ObservableProperty]
		double discount;

		[ObservableProperty]
		double total;

		[RelayCommand]
		private void CalculateTotal()
		{
			Total = Price * (1 - Discount / 100);
		}
	}
}
