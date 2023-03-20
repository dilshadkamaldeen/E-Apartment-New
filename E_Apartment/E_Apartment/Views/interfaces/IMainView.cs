using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Views.interfaces
{
    internal interface IMainView
    {
        

        event EventHandler ShowBuildingView;
        event EventHandler CloseBuildingView;

        event EventHandler ShowParkingSpaceView;
        event EventHandler CloseParkingSpaceView;

      

        event EventHandler ShowTenantsView;
        event EventHandler ShowLeaseAgreementView;
        event EventHandler ShowReservationView;
        event EventHandler ShowPaymentView;


        event EventHandler CloseTenantsView;

        void SetLoginUser(string loginUser);
    }
}
