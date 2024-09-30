using Demo.AppMaui.MVVM.ViewModels;

namespace Demo.AppMaui.MVVM.Views
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;          
        }       
    }

}
