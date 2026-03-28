namespace MauiAppBemEstarDigital
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiAppBemEstarDigital.Views.LoginPage());
        }
    }
}
