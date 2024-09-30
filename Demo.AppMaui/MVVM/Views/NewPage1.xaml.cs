using Demo.AppMaui.MVVM.ViewModels;

namespace Demo.AppMaui.MVVM.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewPage1ViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}