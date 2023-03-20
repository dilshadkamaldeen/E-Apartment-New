using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class LeasingAgreementPresenter
    {
        private ILeaseAgreementView view;
        private ILeasingAgreementRepository repository;
        private BindingSource leaseAgreementBindingSource;
        private BindingSource buildingBindingSource;
        private BindingSource apartmentBindingSource;
        private BindingSource tenantsBindingSource;
        private BindingSource reservationBindingSource;
        private IEnumerable<LeasingAgreementModel> leaseAgreementList;
        private IEnumerable<BuildingsModel> buildingsList;
        private IEnumerable<ApartmentModel> apartmentsList;
        private IEnumerable<ApartmentClassModel> apartmentClassList;
        private IEnumerable<TenantsModel> tenantsList;
        private IEnumerable<ReservationModel> reservationList;

        public LeasingAgreementPresenter(ILeaseAgreementView view, ILeasingAgreementRepository repository)
        {
            this.view = view;
            this.repository = repository;

            leaseAgreementBindingSource = new BindingSource();
            buildingBindingSource = new BindingSource();
            apartmentBindingSource = new BindingSource();
            tenantsBindingSource = new BindingSource();
            reservationBindingSource = new BindingSource();


            //Subscribe event handler
            this.view.SearchEventLeaseAgreement += SearchLeaseAgreement;
            this.view.UpdateEventLeaseAgreement += UpdateLeaseAgreement;
            this.view.AddNewEventLeaseAgreement += AddLeaseAgreement;
            this.view.SaveEventLeaseAgreement += SaveLeaseAgreement;
            this.view.DeleteEventLeaseAgreement += DeleteLeaseAgreement;
            this.view.CancelEventLeaseAgreement += ClearAllLeaseAgreement;
            this.view.buildingComboChange += buildingComboChange;
            this.view.apartmentComboChange += apartmentComboChange;
            this.view.leaseComboChange += leaseComboChange;



            LoadAll();

            this.view.SetLeaseBindingSource(leaseAgreementBindingSource);
            this.view.SetTenantsNamesIntoComboBox(tenantsBindingSource);
            this.view.SetApartmentNoIntoComboBox(apartmentBindingSource);
            this.view.SetBuildingsIntoComboBox(buildingBindingSource);
            this.view.SetReservationIntoComboBox(reservationBindingSource);

            //Show view
            this.view.Show();
        }

        private void leaseComboChange(object sender, EventArgs e)
        {
            
            var selectedReservation = repository.GetReservationById((int)this.view.reservationId);

            foreach(var item in selectedReservation)
            {
               var (tenants, apartment) = item; //Deconstract of ReservationModel

                //ApartmentClassModel
                this.view.apartmentClassName = apartment.apartmentClass.ClassName;
                this.view.apartmentClassId = apartment.apartmentClass.ClassNameId;
                this.view.apartmentAttachBathroom = apartment.apartmentClass.AttachBathroomCount.ToString();
                this.view.apartmentCommonBathroom = apartment.apartmentClass.CommonBathroomCount.ToString();
                this.view.apartmentBedroomCount = apartment.apartmentClass.BedroomCount.ToString();
                this.view.servantsRoomCount = apartment.apartmentClass.ServantsRoomCount.ToString();
                this.view.servantToiletCount = apartment.apartmentClass.ServantToiletCount.ToString();

                //Apartment Model
                this.view.apartmentLivingArea = apartment.LivingAreaSqft.ToString();
                this.view.apartmentDiningArea = apartment.DiningAreaSqft.ToString();
                this.view.apartmentKitchenArea = apartment.KitchenAreaSqft.ToString();
                this.view.apartmentStatus = apartment.Status.ToString();
                this.view.apartmentNo = apartment.ApartmentNo.ToString();
                this.view.apartmentMaxNoOcc = apartment.MaxNumberOccupied.ToString();
                this.view.apartmentRentPerMonth = apartment.ApartmentRentPerMonth.ToString();
                this.view.reservationFee = apartment.ReservationFee.ToString();
                this.view.apartmentId = apartment.ApartmentId;

                //Tenants Model
                this.view.tenantsId = tenants.TenantId.ToString();
                this.view.tenantsName = tenants.TenantName.ToString();

                //Building Model
                this.view.buildingId = apartment.buildingsModel.Id;
                this.view.buildingName = apartment.buildingsModel.BuildingName.ToString();
            }

        }

        private void apartmentComboChange(object sender, EventArgs e)
        {
            
            var selectedApartment = repository.GetApartmentById((int)this.view.apartmentId);
            // apartmentBindingSource.DataSource = apartmentsList;
            foreach(var item in selectedApartment){

                //ApartmentClassModel
                this.view.apartmentClassName = item.apartmentClass.ClassName;
                this.view.apartmentClassId = item.apartmentClass.ClassNameId;
                this.view.apartmentAttachBathroom = item.apartmentClass.AttachBathroomCount.ToString();
                this.view.apartmentCommonBathroom = item.apartmentClass.CommonBathroomCount.ToString();
                this.view.apartmentBedroomCount = item.apartmentClass.BedroomCount.ToString();
                this.view.servantsRoomCount = item.apartmentClass.ServantsRoomCount.ToString();
                this.view.servantToiletCount = item.apartmentClass.ServantToiletCount.ToString();

                //Apartment Model
                this.view.apartmentLivingArea = item.LivingAreaSqft.ToString();
                this.view.apartmentDiningArea = item.DiningAreaSqft.ToString();
                this.view.apartmentKitchenArea = item.KitchenAreaSqft.ToString();
                this.view.apartmentStatus = item.Status.ToString();
                this.view.apartmentNo = item.ApartmentNo.ToString();
                this.view.apartmentMaxNoOcc = item.MaxNumberOccupied.ToString();
                this.view.apartmentRentPerMonth = item.ApartmentRentPerMonth.ToString();
                this.view.reservationFee = item.ReservationFee.ToString();

            };
            
        
        }

        private void SearchLeaseAgreement(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateLeaseAgreement(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddLeaseAgreement(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveLeaseAgreement(object sender, EventArgs e)
        {
            //create  model instance
            var model = new LeasingAgreementModel
            {
                LeaseAgreementId = view.LeaseAgreementId,
                ReservationId = view.ReservationId,
                TenantId = view.TenantId,
                RefundableDeposit = view.RefundableDeposit,
                FirstMonthRent = view.FirstMonthRent,
                TotalAdvanceAmount = view.TotalAdvanceAmount,
                IsTotalAdvancePaid = view.IsTotalAdvancePaid,
                Term = view.Term,
                LeaseStartDate = view.LeaseStartDate,
                LeaseExpireDate = view.LeaseExpireDate,
                TotalDueAmount = view.TotalDueAmount,
                IsAllocateDefaultParking = view.IsAllocateDefaultParking,
                LeaseAgreementStatus = view.LeaseAgreementStatus,
            };

            //pass data View --> to --> model
            

           

            try
            {
                //Save
                //Validate the parkingSpaceModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Update(model);
                    view.Message = "Leasing Agreement Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Leasing Agreement Created Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                
                // this.view.SetParkingSpaceNamesIntoComboBox(parkingSpaceBindingSource);


            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanViewFields()
        {
            view.LeaseAgreementId = 0;
            view.ReservationId = 0;
            view.TenantId = 0;
            view.RefundableDeposit = 0;
            view.FirstMonthRent = 0;
            view.TotalAdvanceAmount = 0;
            view.IsTotalAdvancePaid = false;
            view.Term = "";
            view.LeaseStartDate = DateTime.UtcNow.Date;
            view.LeaseExpireDate = DateTime.UtcNow.Date;
            view.TotalDueAmount = 0;
            view.IsAllocateDefaultParking = false;
            view.LeaseAgreementStatus = false;
        }

        private void DeleteLeaseAgreement(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClearAllLeaseAgreement(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void buildingComboChange(object sender, EventArgs e)
        { 
            apartmentsList = repository.GetAllApartmentByBuildingId(this.view.buildingId);
            apartmentBindingSource.DataSource = apartmentsList;
        }

        private void LoadAll()
        {
            leaseAgreementList = repository.GetAll();
            leaseAgreementBindingSource.DataSource = leaseAgreementList; //set data source

            buildingsList = repository.GetAllBuildings();
            buildingBindingSource.DataSource = buildingsList;

            apartmentsList = repository.GetAllApartment();
            apartmentBindingSource.DataSource = apartmentsList;

            tenantsList = repository.GetAllTenants();
            tenantsBindingSource.DataSource = tenantsList;


            reservationList = repository.GetAllReservations();
            reservationBindingSource.DataSource = reservationList;

        }
    }
}
