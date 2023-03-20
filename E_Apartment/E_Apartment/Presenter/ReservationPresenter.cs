using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class ReservationPresenter
    {
        //Fileds
        private IReservationView reservationView;
        private IReservationRepository reservationRepository;

        private BindingSource reservationBindingSource;
        private BindingSource buildingBindingSource;
        private BindingSource apartmentBindingSource;
        private BindingSource tenantsBindingSource;

        private IEnumerable<ReservationModel> reservationsList;
        private IEnumerable<BuildingsModel> buildingsList;
        private IEnumerable<ApartmentModel> apartmentsList;
        private IEnumerable<ApartmentClassModel> apartmentClassList;
        private IEnumerable<TenantsModel> tenantsList;

        public ReservationPresenter(IReservationView reservationView, IReservationRepository reservationRepository)
        {
            this.reservationBindingSource = new BindingSource();
            this.buildingBindingSource = new BindingSource();
            this.apartmentBindingSource = new BindingSource();
            this.tenantsBindingSource = new BindingSource();

            this.reservationView = reservationView;
            this.reservationRepository = reservationRepository;

            //Subscribe event handler
            this.reservationView.SearchEventReservation += SearchReservation;
            this.reservationView.UpdateEventReservation += UpdateReservation;
            this.reservationView.AddNewEventReservation += AddReservation;
            this.reservationView.SaveEventReservation +=  SaveReservation;
            this.reservationView.DeleteEventReservation += DeleteReservation;
            this.reservationView.CancelEventReservation += ClearAllReservation;

            this.reservationView.buildingComboChange += buildingComboChange;
            this.reservationView.apartmentComboChange += apartmentComboChange;
            


            //Set reservation binding source //LoadAllReservation
            LoadingAll();
            this.reservationView.SetReservationNamesIntoComboBox(reservationBindingSource);
            this.reservationView.SetReservationListBindingSource(reservationBindingSource);

            this.reservationView.SetTenantsNamesIntoComboBox(tenantsBindingSource);
            this.reservationView.SetApartmentNoIntoComboBox(apartmentBindingSource);
            this.reservationView.SetBuildingsIntoComboBox(buildingBindingSource);
            //Show reservationView
            this.reservationView.Show();
        }

         
        private void ClearAllReservation(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods

        private void apartmentComboChange(object sender, EventArgs e)
        {

            var selectedApartment = reservationRepository.GetApartmentById((int)this.reservationView.apartmentId);
            // apartmentBindingSource.DataSource = apartmentsList;
            foreach (var item in selectedApartment)
            {

                //ApartmentClassModel
                this.reservationView.apartmentClassName = item.apartmentClass.ClassName;
                this.reservationView.apartmentClassId = item.apartmentClass.ClassNameId;
                this.reservationView.apartmentAttachBathroom = item.apartmentClass.AttachBathroomCount.ToString();
                this.reservationView.apartmentCommonBathroom = item.apartmentClass.CommonBathroomCount.ToString();
                this.reservationView.apartmentBedroomCount = item.apartmentClass.BedroomCount.ToString();
                this.reservationView.servantsRoomCount = item.apartmentClass.ServantsRoomCount.ToString();
                this.reservationView.servantToiletCount = item.apartmentClass.ServantToiletCount.ToString();

                //Apartment Model
                this.reservationView.apartmentLivingArea = item.LivingAreaSqft.ToString();
                this.reservationView.apartmentDiningArea = item.DiningAreaSqft.ToString();
                this.reservationView.apartmentKitchenArea = item.KitchenAreaSqft.ToString();
                this.reservationView.apartmentStatus = item.Status.ToString();
                this.reservationView.apartmentNo = item.ApartmentNo.ToString();
                this.reservationView.apartmentMaxNoOcc = item.MaxNumberOccupied.ToString();
                this.reservationView.apartmentRentPerMonth = item.ApartmentRentPerMonth.ToString();
                this.reservationView.reservationFee = item.ReservationFee.ToString();

            };
        }

        private void buildingComboChange(object sender, EventArgs e)
        {

            apartmentsList = reservationRepository.GetAllApartmentByBuildingId(this.reservationView.buildingId);
            apartmentBindingSource.DataSource = apartmentsList;
        }
        private void LoadingAll()
        {
            reservationsList = reservationRepository.GetAll();
            reservationBindingSource.DataSource = reservationsList; //set data source


            buildingsList = reservationRepository.GetAllBuildings();
            buildingBindingSource.DataSource = buildingsList;

            apartmentsList = reservationRepository.GetAllApartment();
            apartmentBindingSource.DataSource = apartmentsList;

            tenantsList = reservationRepository.GetAllTenants();
            tenantsBindingSource.DataSource = tenantsList;
        }

        private void SearchReservation(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.reservationView.SearchValue);
            if (!emptyValue) { reservationsList = reservationRepository.GetByValue(this.reservationView.SearchValue); }
            else { reservationsList = reservationRepository.GetAll(); }

            reservationBindingSource.DataSource = reservationsList;
        }

        private void DeleteReservation(object sender, EventArgs e)
        {
            try
            {
                var reservation = (ReservationModel)reservationBindingSource.Current;
                reservationRepository.Delete(reservation.ReservationId);
                reservationView.IsSuccess = true;
                reservationView.Message = "Delete successfully";
                //Load all again
                LoadingAll();
                reservationView.Show();
            }
            catch (Exception ex)
            {
                reservationView.IsSuccess = false;
                reservationView.Message = ex.Message;
            }
        }

        private void SaveReservation(object sender, EventArgs e)
        {
            //create reservation model instance
            var model = new ReservationModel();

            //pass data View --> to --> model     
            model.ReservationId = Convert.ToInt32(reservationView.ReservationId);
            model.ReservationBuildingId = Convert.ToInt32(reservationView.ReservationBuildingId);
            model.ReservationApartmentId = Convert.ToInt32(reservationView.ReservationApartmentId);
            model.ReservationApartmentStatus = reservationView.ReservationApartmentStatus;
            model.ReservationFee =Convert.ToDecimal( reservationView.ReservationFee);
            model.IsReservationFeePaid = Convert.ToBoolean(reservationView.IsReservationFeePaid);
            model.ReservationTenantId = Convert.ToInt32(reservationView.ReservationTenantId);
           // model.IsWaitingList = Convert.ToBoolean(reservationView.IsWaitingList);

            try
            {
                //Save
                //Validate the reservationModel
                new Utility.ModelValidator().Validate(model);
                if(reservationView.IsEdit)
                {
                    reservationRepository.Update(model);
                    reservationView.Message = "Reservation Edited Successfully";
                    reservationView.IsEdit = false;
                }
                else
                {
                    reservationRepository.Add(model);
                    reservationView.Message = "Reservation Added Successfully";
                }

                reservationView.IsSuccess= true;
                LoadingAll();
                CleanViewFields();
               // this.reservationView.SetReservationNamesIntoComboBox(reservationBindingSource);


            }
            catch(Exception ex)
            {
                reservationView.IsSuccess = false;
                reservationView.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CleanViewFields()
        {
             
            reservationView.ReservationId = 0;
            reservationView.ReservationBuildingId = 0;
            reservationView.ReservationApartmentId ="0";
            reservationView.ReservationApartmentStatus = "";
            reservationView.ReservationFee = "0";
            reservationView.IsReservationFeePaid = false;
            reservationView.IsWaitingList = false;


            reservationView.IsEdit = false;
        }

        private void AddReservation(object sender, EventArgs e)
        {
            reservationView.IsEdit = false;

        }

        private void UpdateReservation(object sender, EventArgs e)
        {
            var reservation = (ReservationModel)reservationBindingSource.Current;
            reservationView.ReservationId = reservation.ReservationId;
            reservationView.ReservationBuildingId = reservation.ReservationBuildingId;
            reservationView.ReservationApartmentId = reservation.ReservationApartmentId.ToString();
            reservationView.ReservationApartmentStatus = reservation.ReservationApartmentStatus;
            reservationView.ReservationFee = reservation.ReservationFee.ToString();
            reservationView.IsEdit = true;

        }

    }
}
