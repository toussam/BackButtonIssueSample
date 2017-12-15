using BackButtonIssueSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonIssueSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterPageMaster()
        {
            InitializeComponent();
            BindingContext = new MasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }
    }
}