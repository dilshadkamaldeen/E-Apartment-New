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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Apartment.Presenter
{
    internal class ApartmentPresenter
    {
        //Fileds
        private IApartmentView view;
        private IApartmentRepository repository;
        private BindingSource apartmentBindingSource;
        private IEnumerable<ApartmentModel> apartmentList;

        public ApartmentPresenter(IApartmentView view, IApartmentRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.apartmentBindingSource = new BindingSource();

            //Subscribe event handler  (View ---> to ---> Db )
            this.view.AddNewEventApartment += AddNewApartment;
            this.view.EditEventApartment += EditApartment;
            this.view.DeleteEventApartment += DeleteApartment;
            this.view.CancelEventApartment += CancelApartment;
            this.view.SaveEventApartment += SaveApartment;


            LoadAllApartments();
            this.view.SetApartmentListBindingSource(apartmentBindingSource);
        }

        private void LoadAllApartments()
        {
            apartmentList = repository.GetAll(); //assigning all apartment class details into List from DB;
            apartmentBindingSource.DataSource = apartmentList;
        }

        private void SaveApartment(object sender, EventArgs e)
        {
            var model = new ApartmentModel
            {
                ApartmentId = view.ApartmentId,
                ApartmentClassId = view.ApartmentClassId,
                ApartmentBuildingId = view.ApartmentBuildingId,
                ApartmentNo = view.ApartmentNo,
                ApartmentRentPerMonth = view.ApartmentRentPerMonth,
                MaxNumberOccupied = view.MaxNumberOccupied,
                Status = view.ApartmentStatus,
                IsLivingArea = view.IsLivingArea,
                LivingAreaSqft = view.LivingAreaSqft,
                IsDiningArea = view.IsDiningArea,
                DiningAreaSqft = view.DiningAreaSqft,
                IsKitchenArea = view.IsKitchenArea,
                KitchenAreaSqft = view.KitchenAreaSqft,
                IsLaundryArea = view.IsLaundryArea,
                LaundryAreaSqft = view.LaundryAreaSqft,
                IsTelephoneService = view.IsTelephoneService,
                IsBroadbandInternet = view.IsBroadbandInternet,
                IsCableTv = view.IsCableTv,
                IsParkingArea = view.IsParkingArea,
                IsGymnasium = view.IsGymnasium,
                IsSwimingPool = view.IsSwimingPool,
                ReservationFee = view.ReservationFee,
            };



            try
            {
                // new Utility.ModelValidator().Validate(model);

                if (view.IsApartmentEdit)
                {
                    //Apply Edit function
                    repository.Update(model);
                    view.Message = "Apartment  Edited Successfully";
                    view.IsApartmentEdit = false;
                    view.IsSuccess = true;
                }
                else
                {
                    //Add new 
                    repository.Add(model);
                    view.Message = "Apartment  Added Successfully";
                    view.IsApartmentEdit = false;
                    view.IsSuccess = true;

                }


                LoadAllApartments();
                CleanViewFields();

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
            view.ApartmentId =0;
            view.ApartmentClassId =0;
            view.ApartmentBuildingId =0;
            view.ApartmentNo =0;
            view.ApartmentRentPerMonth =0;
            view.MaxNumberOccupied =0;
            view.IsLivingArea =false;
            view.LivingAreaSqft =0;
            view.IsDiningArea = false;
            view.DiningAreaSqft =0;
            view.IsKitchenArea = false;
            view.KitchenAreaSqft =0;
            view.IsLaundryArea = false;
            view.LaundryAreaSqft =0;
            view.IsTelephoneService = false;
            view.IsBroadbandInternet = false;
            view.IsCableTv = false;
            view.IsParkingArea = false;
            view.IsGymnasium = false;
            view.IsSwimingPool = false;
            view.ApartmentStatus = "Vacant";
            view.ReservationFee = 0;
        }

        private void CancelApartment(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteApartment(object sender, EventArgs e)
        {
            try
            {
                var apartment = (ApartmentModel)apartmentBindingSource.Current;
                repository.Delete(apartment.ApartmentId);
                view.IsSuccess = true;
                view.Message = "Delete successfully";
                //Load all again
                LoadAllApartments();

            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
            }
        }

        private void EditApartment(object sender, EventArgs e)
        {
            view.IsApartmentEdit = true;
            var apartment = (ApartmentModel)apartmentBindingSource.Current;


            view.ApartmentId = Convert.ToInt32(apartment.ApartmentId);
            view.ApartmentClassId = Convert.ToInt32(apartment.ApartmentClassId);
            view.ApartmentBuildingId = Convert.ToInt32(apartment.ApartmentBuildingId);
            view.ApartmentNo = Convert.ToInt32(apartment.ApartmentNo);
            view.ApartmentRentPerMonth = Convert.ToDecimal(apartment.ApartmentRentPerMonth);
            view.MaxNumberOccupied = Convert.ToInt32(apartment.MaxNumberOccupied);
            view.IsLivingArea = Convert.ToBoolean(apartment.IsLivingArea);
            view.LivingAreaSqft = Convert.ToDecimal(apartment.LivingAreaSqft);
            view.IsDiningArea = Convert.ToBoolean(apartment.IsDiningArea);
            view.DiningAreaSqft = Convert.ToDecimal(apartment.DiningAreaSqft);
            view.IsKitchenArea = Convert.ToBoolean(apartment.IsKitchenArea);
            view.KitchenAreaSqft = Convert.ToDecimal(apartment.KitchenAreaSqft);
            view.IsLaundryArea = Convert.ToBoolean(apartment.IsLaundryArea);
            view.LaundryAreaSqft = Convert.ToDecimal(apartment.LaundryAreaSqft);
            view.IsTelephoneService = Convert.ToBoolean(apartment.IsTelephoneService);
            view.IsBroadbandInternet = Convert.ToBoolean(apartment.IsBroadbandInternet);
            view.IsCableTv = Convert.ToBoolean(apartment.IsCableTv);
            view.IsParkingArea = Convert.ToBoolean(apartment.IsParkingArea);
            view.IsGymnasium = Convert.ToBoolean(apartment.IsGymnasium);
            view.IsSwimingPool = Convert.ToBoolean(apartment.IsSwimingPool);
            view.ReservationFee = Convert.ToDecimal(apartment.ReservationFee);
            view.ApartmentStatus = apartment.Status;

        }

        private void AddNewApartment(object sender, EventArgs e)
        {
            view.IsApartmentEdit = false;
        }
    }
}
