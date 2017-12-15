using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonIssueSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation?.PushAsync(new SecondPage());
        }
    }
}