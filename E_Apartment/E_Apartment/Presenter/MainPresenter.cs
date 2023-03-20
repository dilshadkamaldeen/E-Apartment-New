using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class MainPresenter

    {
        private IMainView mainView;
        
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString, string userType)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowBuildingView += ShowBuildingView;
            this.mainView.ShowParkingSpaceView += ShowParkingSpaceView;
            this.mainView.ShowTenantsView += ShowTenantsView;
            this.mainView.ShowLeaseAgreementView += ShowLeaseAgreementView;
            this.mainView.ShowReservationView += ShowReservationView;
            this.mainView.ShowPaymentView += ShowPaymentView;
            this.mainView.SetLoginUser(userType);

        }

        

        private void ShowPaymentView(object arg1, EventArgs arg2)
        {
            IPaymentView paymentView = PaymentsView.GetInstance((Form)mainView);
            IPaymentRepository paymentRepository = new PaymentRepository(sqlConnectionString);

            //Bind with Presenter
            new PaymentPresenter(paymentView, paymentRepository);

           
        } 
         private void ShowReservationView(object arg1, EventArgs arg2)
        {
            IReservationView reservationView = ReservationView.GetInstance((Form)mainView);
            IReservationRepository reservationRepository = new ReservationRepository(sqlConnectionString);

            //Bind with Presenter
            new ReservationPresenter(reservationView, reservationRepository);

            IApplicationView applicationView = ReservationView.GetInstance((Form)mainView);
            IApplicationRepository applicationRepository = new ApplicationRepository(sqlConnectionString);

            //Bind with Presenter
            new ApplicationPresenter(applicationView, applicationRepository);
        } 
        
        private void ShowLeaseAgreementView(object arg1, EventArgs arg2)
        {
            ILeaseAgreementView leaseView = LeaseAgreementView.GetInstance((Form)mainView);
            ILeasingAgreementRepository leaseRepository = new LeasingAgreementRepository(sqlConnectionString);

            //Bind with Presenter
            new LeasingAgreementPresenter(leaseView, leaseRepository);
        }

        private void ShowTenantsView(object sender, EventArgs e)
        {
            ITenantsView tenantsView = TenantsView.GetInstance((Form)mainView);
            ITenantsRepository tenantsRepository = new TenantsRepository(sqlConnectionString);

            //Bind with Presenter
            new TenantsPresenter(tenantsView, tenantsRepository);

            IDependentsView dependentsView = TenantsView.GetInstance((Form)mainView);
            IDependentsRepository dependentsRepository = new DependentsRepository(sqlConnectionString);

            //Bind with Presenter
            new DependentsPresenter(dependentsView, dependentsRepository);
        }

        private void ShowParkingSpaceView(object sender, EventArgs e)
        {
            IParkingSpaceView parkingSpaceView = ParkingSpaceView.GetInstance((Form)mainView);
            IParkingSpaceRepository buildingRepository = new ParkingSpaceRepository(sqlConnectionString);

            //Bind with Presenter
            new ParkingSpacePresenter(parkingSpaceView, buildingRepository);
        }

        private void ShowBuildingView(object sender, EventArgs e)
        {
             

            IBuildingView buildingView = BuildingView.GetInstance((Main)mainView);
            IApartmentClassView apartmentClassView = BuildingView.GetInstance((Main)mainView);
            IApartmentView apartmentView = BuildingView.GetInstance((Main)mainView);

            IBuildingRepository buildingRepository = new BuildingRepository(sqlConnectionString);
            IApartmentClassRepository apartmentClassRepository = new ApartmentClassRepository(sqlConnectionString);
            IApartmentRepository apartmentRepository = new ApartmentRepository(sqlConnectionString);

            new BuildingPresenter(buildingView, buildingRepository);
            new ApartmentClassPresenter(apartmentClassView, apartmentClassRepository);
            new ApartmentPresenter(apartmentView, apartmentRepository);

        }
    }
}
