using DemoMVVM.ViewModels;

namespace DemoMVVM.Views;

public partial class ProductView : ContentPage
{
	ProductSimpleViewModel vm;

	public ProductView(ProductSimpleViewModel vm)
	{
		InitializeComponent();
		this.vm = vm;
		BindingContext = vm;
	}
}