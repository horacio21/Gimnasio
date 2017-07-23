using GYM.Models;
using GYM.ViewModels;
using Sports.Models;
using System.Collections.ObjectModel;

namespace Sports.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { set; get; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        //private void LoadMenu()
        //{
        //    Menu = new ObservableCollection<MenuItemViewModel>();

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "predictions.png",
        //        PageName = "SelectTournamentPage",
        //        Title = "Predicciones",
        //    });

        //    //Menu.Add(new MenuItemViewModel
        //    //{
        //    //    Icon = "apuestas.png",
        //    //    PageName = "SelectBetPage",
        //    //    Title = "Apuestas",
        //    //});

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "groups.png",
        //        PageName = "GroupsPage",
        //        Title = "Grupos",
        //    });

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "tournaments.png",
        //        PageName = "SelectTournamentPage",
        //        Title = "Torneos",
        //    });

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "myresults.png",
        //        PageName = "ResultsPage",
        //        Title = "Mis Resultados",
        //    });

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "config.png",
        //        PageName = "ConfigPage",
        //        Title = "Configuración",
        //    });

        //    Menu.Add(new MenuItemViewModel
        //    {
        //        Icon = "logut.png",
        //        PageName = "LoginPage",
        //        Title = "Cerrar Sesión",
        //    });
        //}
        #endregion
    }
}
