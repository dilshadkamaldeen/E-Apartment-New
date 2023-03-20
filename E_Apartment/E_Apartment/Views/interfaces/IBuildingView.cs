using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IBuildingView
    {
        int BuildingId { get; set; }
        string BuildingName { get; set; }
        string BuildingLocation { get; set; }
        string BuildingAddress { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler UpdateEvent;
        event EventHandler CancelEvent;
        event EventHandler SaveEvent;

        //Methods

        //buildings methods
        void SetBuildingListBindingSource(BindingSource buildingList);
        void Show(); //Optional


        //apartments methods
        void SetBuildingNamesIntoComboBox(BindingSource buildingList);


    }
}
