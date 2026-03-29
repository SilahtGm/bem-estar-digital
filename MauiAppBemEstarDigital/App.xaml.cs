using MauiAppBemEstarDigital.Helpers;
using MauiAppBemEstarDigital.Models;
using Plugin.LocalNotification;
namespace MauiAppBemEstarDigital
{
    public partial class App : Application
    {

        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_saude.db3");

                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }
        }

        public static Usuario UsuarioLogado { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiAppBemEstarDigital.Views.LoginPage());
        }
    }
}
