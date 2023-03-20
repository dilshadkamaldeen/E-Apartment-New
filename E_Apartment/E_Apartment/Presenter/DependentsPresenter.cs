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
    internal class DependentsPresenter
    {



        private IDependentsView view;
        private IDependentsRepository repository;
        private BindingSource dependentsBindingSource;
        private IEnumerable<DependentsModel> dependentsList;

        public DependentsPresenter(IDependentsView view, IDependentsRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.dependentsBindingSource = new BindingSource();


            //Subscribe event handler
            this.view.SearchEventDependents += SearchDependents;
            this.view.EditEventDependents += UpdateDependents;
            this.view.AddNewEventDependents += AddDependents;
            this.view.SaveEventDependents += SaveDependents;
            this.view.DeleteEventDependents += DeleteDependents;
            this.view.CancelEventDependents += ClearAllDependents;





            //Set  source //LoadAll 
            LoadAll();

            this.view.SetDependentsBindingSource(dependentsBindingSource);
            this.view.SetDependentsNamesIntoComboBox(dependentsBindingSource);

            //Show view
            this.view.Show();
        }

        private void ClearAllDependents(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadAll()
        {
            dependentsList = repository.GetAll();
            dependentsBindingSource.DataSource = dependentsList; //set data source

        }

        private void SearchDependents(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue) { dependentsList = repository.GetByValue(this.view.SearchValue); }
            else { dependentsList = repository.GetAll(); }

            dependentsBindingSource.DataSource = dependentsList;
        }

        private void DeleteDependents(object sender, EventArgs e)
        {
            try
            {
                var dependentssModel = (DependentsModel)dependentsBindingSource.Current;
                repository.Delete(dependentssModel.TenantId);
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

        private void SaveDependents(object sender, EventArgs e)
        {
            //create dependentssModel model instance
            var model = new DependentsModel
            {
                //pass data View --> to --> model
                DependentId = view.DependentId,
                TenantId = view.DependentTenantId,
                DependentName = view.DependentName,
                DependentRelationship = view.DependentRelationship,
                DependentGender = view.DependentGender,
                DependentStatus = view.DependentStatus


            };

            try
            {
                //Save
                //Validate the dependentssModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Update(model);
                    view.Message = "Dependents Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Dependents Added Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                CleanViewFields();
                // this.view.SetDependentsNamesIntoComboBox(dependentsBindingSource);


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

            view.DependentId = 0;
            view.DependentTenantId = 0;
            view.DependentName = "";
            view.DependentRelationship = "";
            view.DependentGender = "";
            view.DependentStatus = false;
            view.IsEdit = false;
        }

        private void AddDependents(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }

        private void UpdateDependents(object sender, EventArgs e)
        {
            var dependentssModel = (DependentsModel)dependentsBindingSource.Current;
            view.DependentId = dependentssModel.DependentId;
            view.DependentTenantId =  dependentssModel.TenantId;
            view.DependentName = dependentssModel.DependentName;
            view.DependentRelationship = dependentssModel.DependentRelationship;
            view.DependentGender = dependentssModel.DependentGender;
            view.DependentStatus = dependentssModel.DependentStatus;

            

            view.IsEdit = true;

        }

    }
}
