using System.ComponentModel;
using Xamarin.Forms;
using XamarinUITest.ViewModels;

namespace XamarinUITest.Views
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