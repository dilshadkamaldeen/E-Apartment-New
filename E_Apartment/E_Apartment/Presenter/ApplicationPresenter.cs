using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class ApplicationPresenter
    {
        //Fileds
        private IApplicationView applicationView;
        private IApplicationRepository applicationRepository;
        private BindingSource applicationBindingSource;
        private IEnumerable<ApplicationModel> applicationList;

        public ApplicationPresenter(IApplicationView applicationView, IApplicationRepository applicationRepository)
        {
            this.applicationBindingSource = new BindingSource();
            this.applicationView = applicationView;
            this.applicationRepository = applicationRepository;

            //Subscribe event handler
            this.applicationView.SearchEventApplication += SearchApplication;
            this.applicationView.UpdateEventApplication += UpdateApplication;
            this.applicationView.AddNewEventApplication += AddApplication;
            this.applicationView.SaveEventApplication += SaveApplication;
            this.applicationView.DeleteEventApplication += DeleteApplication;
            this.applicationView.CancelEventApplication += ClearAllApplication;





            //Set application binding source //LoadAllApplication
            LoadingAllApplicationList();
            this.applicationView.SetApplicatioListBindingSource(applicationBindingSource);

            //Show view
            this.applicationView.Show();
        }

        private void ClearAllApplication(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadingAllApplicationList()
        {
            applicationList = applicationRepository.GetAll();
            applicationBindingSource.DataSource = applicationList; //set data source

        }

        private void SearchApplication(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.applicationView.SearchValue);
            if (!emptyValue) { applicationList = applicationRepository.GetByValue(this.applicationView.SearchValue); }
            else { applicationList = applicationRepository.GetAll(); }

            applicationBindingSource.DataSource = applicationList;
        }

        private void DeleteApplication(object sender, EventArgs e)
        {
            try
            {
                var application = (ApplicationModel)applicationBindingSource.Current;
                applicationRepository.Delete(application.ApplicationId);
                applicationView.IsSuccess = true;
                applicationView.Message = "Delete successfully";
                //Load all again
                LoadingAllApplicationList();
                applicationView.Show();
            }
            catch (Exception ex)
            {
                applicationView.IsSuccess = false;
                applicationView.Message = ex.Message;
            }
        }

        private void SaveApplication(object sender, EventArgs e)
        {
            //create application model instance
            //pass data View --> to --> model
            var model = new ApplicationModel
            {
                ApplicationApartmentId = applicationView.ApplicationApartmentId,
                ApplicationBuildingId = applicationView.ApplicationBuildingId,
                ApplicationApartmentStatus = applicationView.ApplicationApartmentStatus,
                IsWaitingList = applicationView.IsWaitingList,
                ApplicationTenantId = applicationView.ApplicationTenantId,
            };




            try
            {
                //Save
                //Validate the applicationModel
                new Utility.ModelValidator().Validate(model);
                if (applicationView.IsEdit)
                {
                    applicationRepository.Update(model);
                    applicationView.Message = "Application Edited Successfully";
                    applicationView.IsEdit = false;
                }
                else
                {
                    applicationRepository.Add(model);
                    applicationView.Message = "Application Added Successfully";
                }

                applicationView.IsSuccess = true;
                LoadingAllApplicationList();
                CleanViewFields();
                // this.applicationView.SetApplicationNamesIntoComboBox(applicationBindingSource);


            }
            catch (Exception ex)
            {
                applicationView.IsSuccess = false;
                applicationView.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }

        }

        private void CleanViewFields()
        {

            applicationView.ApplicationApartmentId = 0;
            applicationView.ApplicationBuildingId = 0;
            applicationView.ApplicationApartmentStatus = "";
            applicationView.IsWaitingList = false;
            applicationView.ApplicationTenantId = 0;
            applicationView.IsEdit = false;
        }

        private void AddApplication(object sender, EventArgs e)
        {
            applicationView.IsEdit = false;

        }

        private void UpdateApplication(object sender, EventArgs e)
        {
            var application = (ApplicationModel)applicationBindingSource.Current;
            applicationView.ApplicationId = application.ApplicationId;
            applicationView.ApplicationApartmentId = application.ApplicationApartmentId;
            applicationView.ApplicationBuildingId = application.ApplicationBuildingId;
            applicationView.ApplicationApartmentStatus = application.ApplicationApartmentStatus.ToString();
            applicationView.IsWaitingList = application.IsWaitingList;
            applicationView.ApplicationTenantId = application.ApplicationTenantId;
            applicationView.IsEdit = true;

        }

    }
}
