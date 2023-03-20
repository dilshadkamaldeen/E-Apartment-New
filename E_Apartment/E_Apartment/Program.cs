using E_Apartment._Repositories;
using E_Apartment.Models;
using E_Apartment.Presenter;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
            IMainView mainView= new Main();
            ILoginView loginView= new Login();
            
            new LoginPresenter(loginView, sqlConnectionString);
           // new MainPresenter(mainView, sqlConnectionString);
            Application.Run((Form)loginView);
          //  Application.Run(new Login());
        }
    }
}
