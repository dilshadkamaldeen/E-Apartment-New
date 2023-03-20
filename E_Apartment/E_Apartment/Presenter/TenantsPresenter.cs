using CrystalDecisions.CrystalReports.Engine;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
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
    internal class TenantsPresenter
    {



        private ITenantsView view;
        private ITenantsRepository repository;
        private BindingSource tenantBindingSource;
        private IEnumerable<TenantsModel> tenantList;

        public TenantsPresenter(ITenantsView view, ITenantsRepository repository)
        {
            this.view = view;// TenantView windows form interface  connection code preseter
            this.repository = repository; //Database connection code preseter
            this.tenantBindingSource = new BindingSource();


            //Subscribe event handler
            this.view.SearchEventTenants += SearchTenants;
            this.view.EditEventTenants += UpdateTenants;
            this.view.AddNewEventTenants += AddTenants;
            this.view.SaveEventTenants += SaveTenants;
            this.view.DeleteEventTenants += DeleteTenants;
            this.view.CancelEventTenants += ClearAllTenants;
            this.view.RefreshEventTenants += RefreshMethod;




            //Set  source //LoadAll 
            LoadAll();

            this.view.SetBindingSource(tenantBindingSource);
            this.view.SetTenantsNamesIntoComboBox(tenantBindingSource);

            //Show view
            this.view.Show();
        } //end of the constructor

        private void RefreshMethod(object sender, EventArgs e)
        {
            
            CleanViewFields();
        }
        private void ClearAllTenants(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadAll()
        {
            tenantList = repository.GetAll();
            tenantBindingSource.DataSource = tenantList; //set data source

        }

        private void SearchTenants(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue) { tenantList = repository.GetByValue(this.view.SearchValue); }
            else { tenantList = repository.GetAll(); }

            tenantBindingSource.DataSource = tenantList;
        }

        private void DeleteTenants(object sender, EventArgs e)
        {
            try
            {
                var tenantsModel = (TenantsModel)tenantBindingSource.Current;
                repository.Delete(tenantsModel.TenantId);
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

        private void SaveTenants(object sender, EventArgs e)
        {
            MessageBox.Show(this.view.TenantFeedback);
            //create tenantsModel model instance
            var model = new TenantsModel
            {
                //pass data View --> to --> model
                TenantName = view.TenantName,
                TenantNIC = view.TenantNIC,
                TenantContact = view.TenantContact,
                TenantAddress = view.TenantAddress,
                TenantGender = view.TenantGender,
                TenantStatus = view.TenantStatus,

            };

            try
            {
                //Save
                //Validate the tenantsModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Update(model);
                    view.Message = "Tenants Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Tenants Added Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                CleanViewFields();
                // this.view.SetTenantsNamesIntoComboBox(tenantBindingSource);


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

            view.TenantName = "";
            view.TenantNIC = "";
            view.TenantContact = "";
            view.TenantAddress = "";
            view.TenantGender = "";
            view.IsEdit = false;
        }

        private void AddTenants(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }

        private void UpdateTenants(object sender, EventArgs e)
        {
            var tenantsModel = (TenantsModel)tenantBindingSource.Current;
            view.TenantName = tenantsModel.TenantName.ToString();
            view.TenantNIC = Convert.ToString(tenantsModel.TenantNIC);
            view.TenantContact = tenantsModel.TenantContact.ToString();
            view.TenantAddress = tenantsModel.TenantAddress;
            view.TenantGender = tenantsModel.TenantGender;
            view.TenantStatus = tenantsModel.TenantStatus;



            view.IsEdit = true;

        }

    }
}
