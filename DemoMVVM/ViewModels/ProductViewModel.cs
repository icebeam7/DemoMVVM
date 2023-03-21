using System.Windows.Input;

namespace DemoMVVM.ViewModels
{
	public class ProductViewModel : BaseViewModel
	{
		private string name;

		public string Name
		{
			get { return name; }
			set {
				if (name != value)
				{
					name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		private double price;

		public double Price
		{
			get { return price; }
			set {
				if (price != value)
				{
					price = value;
					OnPropertyChanged("Price");
				}

			}
		}

		private double discount;

		public double Discount
		{
			get { return discount; }
			set { 
				if (discount != value)
				{
					discount = value;
					OnPropertyChanged("Discount");
				}
			}
		}

		private double total;

		public double Total
		{
			get { return total; }
			set {
				if (total != value)
				{
					total = value;
					OnPropertyChanged("Total");
				}
			}
		}

        public ICommand CalculateTotalCommand { get; set; }

		private void CalculateTotal()
		{
			Total = Price * (1 - Discount / 100);
		}

		public ProductViewModel()
		{
			CalculateTotalCommand = new Command(CalculateTotal);
		}
    }
}
