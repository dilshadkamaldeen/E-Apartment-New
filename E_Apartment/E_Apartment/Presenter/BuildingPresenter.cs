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
    internal class BuildingPresenter
    {
        //Fileds
        private IBuildingView buildingView;
        private IBuildingRepository buildingRepository;
        private BindingSource buildingBindingSource;
        private IEnumerable<BuildingsModel> buildingsList;

        public BuildingPresenter(IBuildingView buildingView, IBuildingRepository buildingRepository)
        {
            this.buildingBindingSource = new BindingSource();
            this.buildingView = buildingView;
            this.buildingRepository = buildingRepository;

            //Subscribe event handler
            this.buildingView.SearchEvent += SearchBuilding;
            this.buildingView.UpdateEvent += UpdateBuilding;
            this.buildingView.AddNewEvent += AddBuilding;
            this.buildingView.SaveEvent +=  SaveBuilding;
            this.buildingView.DeleteEvent += DeleteBuilding;
            this.buildingView.CancelEvent += ClearAllBuilding;





            //Set building binding source //LoadAllBuildings
            LoadingAllBuildingList();
            this.buildingView.SetBuildingNamesIntoComboBox(buildingBindingSource);
            this.buildingView.SetBuildingListBindingSource(buildingBindingSource);

            //Show view
            this.buildingView.Show();
        }

        private void ClearAllBuilding(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadingAllBuildingList()
        {
            buildingsList = buildingRepository.GetAll();
            buildingBindingSource.DataSource = buildingsList; //set data source
           
        }

        private void SearchBuilding(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.buildingView.SearchValue);
            if (!emptyValue) { buildingsList = buildingRepository.GetByValue(this.buildingView.SearchValue); }
            else { buildingsList = buildingRepository.GetAll(); }

            buildingBindingSource.DataSource = buildingsList;
        }

        private void DeleteBuilding(object sender, EventArgs e)
        {
            try
            {
                var building = (BuildingsModel)buildingBindingSource.Current;
                buildingRepository.Delete(building.Id);
                buildingView.IsSuccess = true;
                buildingView.Message = "Delete successfully";
                //Load all again
                LoadingAllBuildingList();
                buildingView.Show();
            }
            catch (Exception ex)
            {
                buildingView.IsSuccess = false;
                buildingView.Message = ex.Message;
            }
        }

        private void SaveBuilding(object sender, EventArgs e)
        {
            //create building model instance
            var model = new BuildingsModel();

            //pass data View --> to --> model
            model.BuildingName = buildingView.BuildingName;
            model.BuildingLocation = buildingView.BuildingLocation;
            model.BuildingAddress = buildingView.BuildingAddress;
            model.Id = buildingView.BuildingId;

            try
            {
                //Save
                //Validate the buildingModel
                new Utility.ModelValidator().Validate(model);
                if(buildingView.IsEdit)
                {
                    buildingRepository.Update(model);
                    buildingView.Message = "Building Edited Successfully";
                    buildingView.IsEdit = false;
                }
                else
                {
                    buildingRepository.Add(model);
                    buildingView.Message = "Building Added Successfully";
                }

                buildingView.IsSuccess= true;
                LoadingAllBuildingList();
                CleanViewFields();
               // this.buildingView.SetBuildingNamesIntoComboBox(buildingBindingSource);


            }
            catch(Exception ex)
            {
                buildingView.IsSuccess = false;
                buildingView.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CleanViewFields()
        {
            
            buildingView.BuildingName = "";
            buildingView.BuildingLocation = "";
            buildingView.BuildingAddress = "";
            buildingView.IsEdit = false;
        }

        private void AddBuilding(object sender, EventArgs e)
        {
            buildingView.IsEdit = false;

        }

        private void UpdateBuilding(object sender, EventArgs e)
        {
            var building = (BuildingsModel)buildingBindingSource.Current;
            buildingView.BuildingName = building.BuildingName.ToString();
            buildingView.BuildingLocation = building.BuildingLocation.ToString();
            buildingView.BuildingAddress = building.BuildingAddress.ToString();
            buildingView.BuildingId = building.Id;
            buildingView.IsEdit = true;

        }

    }
}
