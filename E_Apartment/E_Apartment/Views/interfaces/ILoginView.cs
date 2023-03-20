using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Views.interfaces
{
    internal interface ILoginView
    {
        string UserName { get; set; }

        event EventHandler ShowMainView;
        void Show();

        void Close();
    }
}
