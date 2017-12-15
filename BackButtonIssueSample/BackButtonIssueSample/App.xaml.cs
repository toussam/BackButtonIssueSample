using BackButtonIssueSample.Views;
using Xamarin.Forms;

namespace BackButtonIssueSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Does work
            //MainPage = new NavigationPage(new MainPage());

            // Doesn't work
            MainPage = new MasterPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
