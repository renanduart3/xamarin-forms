using System.ComponentModel;
using Xamarin.Forms;
using xamarin_forms.ViewModels;

namespace xamarin_forms.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}