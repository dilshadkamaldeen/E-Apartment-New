using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class ParkingSpacePresenter
    {
        private IParkingSpaceView view;
        private IParkingSpaceRepository repository;
        private BindingSource parkingSpaceBindingSource;
        private IEnumerable<ParkingSpaceModel> parkingSpaceList;
        private BindingSource parkingSpaceReservationBindingSource;
        private IEnumerable<ParkingSpaceDetailModel> parkingSpaceDetailList;

        public ParkingSpacePresenter(IParkingSpaceView view, IParkingSpaceRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.parkingSpaceBindingSource = new BindingSource();
            this.parkingSpaceReservationBindingSource = new BindingSource();


            //Subscribe event handler
            this.view.SearchEventParkingSpace += SearchParkingSpace;
            this.view.EditEventParkingSpace += UpdateParkingSpace;
            this.view.AddNewEventParkingSpace += AddParkingSpace;
            this.view.SaveEventParkingSpace += SaveParkingSpace;
            this.view.SaveEventParkingSpaceReservation += ParkingSpaceReservation;
            this.view.DeleteEventParkingSpace += DeleteParkingSpace;
            this.view.CancelEventParkingSpace += ClearAllParkingSpace;
            this.view.RefreshEventParkingSpaceReservation += RefreshMethod;





            //Set  source //LoadAll 
            LoadAll();

            this.view.SetBindingSource(parkingSpaceBindingSource);
            this.view.SetParkingSpaceReservationBindingSource(parkingSpaceReservationBindingSource);

            //Show view
            this.view.Show();
        }

        private void RefreshMethod(object arg1, EventArgs arg2)
        {
            MessageBox.Show("Refreshed");
            CleanViewFields();
        }

        private void ParkingSpaceReservation(object sender, EventArgs e)
        {
            var model = new ParkingSpaceDetailModel
            {
                LeaseAgreementId=view.LeaseAgreementId,
                ReservedDate=DateTime.Now,
                ParkingSpaceId= view.ParkingSpaceId,
            };
             

            try
            {
                //Save
                //Validate the parkingSpaceModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.UpdateParkingReservation(model);
                    view.Message = "ParkingSpace Reservation Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.AddParkingReservation(model);
                    view.Message = "ParkingSpace Reserved Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                CleanViewFields();
                // this.view.SetParkingSpaceNamesIntoComboBox(parkingSpaceBindingSource);


            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAllParkingSpace(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadAll()
        {
            parkingSpaceList = repository.GetAll();
            parkingSpaceBindingSource.DataSource = parkingSpaceList; //set data source

            parkingSpaceDetailList = repository.GetAllParkingSpaceDetails();
            parkingSpaceReservationBindingSource.DataSource = parkingSpaceDetailList;

        }

        private void SearchParkingSpace(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue) { parkingSpaceList = repository.GetByValue(this.view.SearchValue); }
            else { parkingSpaceList = repository.GetAll(); }

            parkingSpaceBindingSource.DataSource = parkingSpaceList;
        }

        private void DeleteParkingSpace(object sender, EventArgs e)
        {
            try
            {
                var parkingSpaceModel = (ParkingSpaceModel)parkingSpaceBindingSource.Current;
                repository.Delete(parkingSpaceModel.ParkingId);
                view.IsSuccess = true;
                view.Message = "Delete successfully";
                //Load all again
                LoadAll();
                view.Show();
            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
            }
        }

        private void SaveParkingSpace(object sender, EventArgs e)
        {
            MessageBox.Show(this.view.ParkingSpaceFeedback);
            //create parkingSpaceModel model instance
            var model = new ParkingSpaceModel();

            //pass data View --> to --> model
            model.ParkingName = view.ParkingName;
            model.ParkingSize = view.ParkingSize;
            model.ParkingType = view.ParkingType;
            model.ParkingStatus = view.ParkingStatus;
            model.ParkingFeedback = view.ParkingSpaceFeedback;


            try
            {
                //Save
                //Validate the parkingSpaceModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Update(model);
                    view.Message = "ParkingSpace Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    view.Message = "ParkingSpace Added Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                CleanViewFields();
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
            view.ParkingSpaceId=0;
            view.LeaseAgreementId=0;
            view.ParkingName = "";
            view.ParkingSize = 0;
            view.ParkingType = "";
            view.ParkingStatus = false;
            view.IsEdit = false;
        }

        private void AddParkingSpace(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }

        private void UpdateParkingSpace(object sender, EventArgs e)
        {
            var parkingSpaceModel = (ParkingSpaceModel)parkingSpaceBindingSource.Current;
            view.ParkingName = parkingSpaceModel.ParkingName.ToString();
            view.ParkingSize = Convert.ToInt32(parkingSpaceModel.ParkingSize);
            view.ParkingType = parkingSpaceModel.ParkingType.ToString();
            view.ParkingStatus = parkingSpaceModel.ParkingStatus;
            view.IsEdit = true;

        }

    }
}