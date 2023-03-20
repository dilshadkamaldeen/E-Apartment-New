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
    internal class ApartmentClassPresenter
    {
        //Fileds
        private IApartmentClassView view;
        private IApartmentClassRepository repository;

        private BindingSource apartmentClassBindingSource;
        private IEnumerable<ApartmentClassModel> apartmentClassList;

        public ApartmentClassPresenter(IApartmentClassView view, IApartmentClassRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.apartmentClassBindingSource = new BindingSource();

            //Presenter is a middle of system --> its like a broker/Joiner of backend & front-end
            //Subscribe event handler  (View ---> to ---> Db )
            this.view.AddNewEventApartmentClass += AddNewApartmentClass;
            this.view.EditEventApartmentClass += EditApartmentClass;
            this.view.DeleteEventApartmentClass += DeleteApartmentClass;
            this.view.CancelEventApartmentClass += CancelApartmentClass;
            this.view.SaveEventApartmentClass += SaveApartmentClass;

            //Load data
           

            //binding datasoruce into view
            LoadAllApartments();
            this.view.SetApartmentClassListBindingSource(apartmentClassBindingSource);
            this.view.SetApartmentClassNamesIntoComboBox(apartmentClassBindingSource);
        }

        private void LoadAllApartments()
        {
            apartmentClassList = repository.GetAll(); //assigning all apartment class details into List from DB;
            apartmentClassBindingSource.DataSource = apartmentClassList;

        }

        private void SaveApartmentClass(object sender, EventArgs e)
        {
            
            var model = new ApartmentClassModel
            {
                ClassNameId = view.ClassNameId,
                ClassName = view.ClassName.ToString(),
                IsBedroomAvailable = true, //Convert.ToBoolean(view.IsBedroomAvailable),
                BedroomCount = Convert.ToInt32(view.BedroomCount),

                IsCommonBathroomAvailable = Convert.ToBoolean(view.IsCommonBathroomAvailable),
                CommonBathroomCount = Convert.ToInt32(view.CommonBathroomCount),
                IsAttachBathroomAvailalbe = Convert.ToBoolean(view.IsAttachBathroomAvailalbe),
                AttachBathroomCount = Convert.ToInt32(view.AttachBathroomCount),
                IsServantsRoomAvailable = Convert.ToBoolean(view.IsServantsRoomAvailable),

                ServantsRoomCount = Convert.ToInt32(view.ServantsRoomCount),
                IsServantToiletAvailable = Convert.ToBoolean(view.IsServantToiletAvailable),
                ServantToiletCount = Convert.ToInt32(view.ServantToiletCount),
                Status = view.Status
            };



            try
            {
               // new Utility.ModelValidator().Validate(model);

                if (view.IsApartmentClassEdit)
                {
                    //Apply Edit function
                    repository.Update(model);
                    view.Message = "Apartment Class Edited Successfully";
                    view.IsApartmentClassEdit = false;
                    view.IsSuccess = true;
                }
                else
                {
                    //Add new 
                    repository.Add(model);
                    view.Message = "Apartment Class Added Successfully";
                    view.IsApartmentClassEdit = false;
                    view.IsSuccess = true;

                }

               
                LoadAllApartments();
                CleanViewFields();

            }
            catch(Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanViewFields()
        {

            view.ClassNameId =0;
            view.ClassName ="";
            view.IsBedroomAvailable =false;
            view.BedroomCount =0;

            view.IsCommonBathroomAvailable =false;
            view.CommonBathroomCount =0;
            view.IsAttachBathroomAvailalbe =false;
            view.AttachBathroomCount =0;
            view.IsServantsRoomAvailable =false;

            view.ServantsRoomCount =0;
            view.IsServantToiletAvailable =false;
            view.ServantToiletCount =0;
            view.Status =false;
        }

        private void CancelApartmentClass(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteApartmentClass(object sender, EventArgs e)
        {
            try
            {
                var apartment = (ApartmentClassModel)apartmentClassBindingSource.Current;
                repository.Delete(apartment.ClassNameId);
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

        private void EditApartmentClass(object sender, EventArgs e)
        {
            view.IsApartmentClassEdit = true;
            var apartmentClass = (ApartmentClassModel)apartmentClassBindingSource.Current;

            //assigning Data Model to View  <--- this way
            //Populating selected data into Front End

            view.ClassNameId = apartmentClass.ClassNameId;
            view.ClassName = apartmentClass.ClassName.ToString();
            view.IsBedroomAvailable = apartmentClass.IsBedroomAvailable;
            view.BedroomCount = apartmentClass.BedroomCount;

            view.IsCommonBathroomAvailable = apartmentClass.IsCommonBathroomAvailable;
            view.CommonBathroomCount = apartmentClass.CommonBathroomCount;
            view.IsAttachBathroomAvailalbe = apartmentClass.IsAttachBathroomAvailalbe;
            view.AttachBathroomCount = apartmentClass.AttachBathroomCount;
            view.IsServantsRoomAvailable = apartmentClass.IsServantsRoomAvailable;

            view.ServantsRoomCount = apartmentClass.ServantsRoomCount;

            view.IsServantToiletAvailable = apartmentClass.IsServantToiletAvailable;
            view.ServantToiletCount = apartmentClass.ServantToiletCount;
            view.Status = apartmentClass.Status;



        }

        private void AddNewApartmentClass(object sender, EventArgs e)
        {
            view.IsApartmentClassEdit = false;
        }
    }
}
