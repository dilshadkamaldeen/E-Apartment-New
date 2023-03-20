using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class LoginPresenter
    {
        private ILoginView mainView;
        private readonly string sqlConnectionString;

        public LoginPresenter(ILoginView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowMainView += ShowMainView;

        }

        private void ShowMainView(object sender, EventArgs e)
        {


            Main view = new Main();
            new MainPresenter(view, sqlConnectionString, mainView.UserName);
            view.ShowDialog();

        }
    }
}
