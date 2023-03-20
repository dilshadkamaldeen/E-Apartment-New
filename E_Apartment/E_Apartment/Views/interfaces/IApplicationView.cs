using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IApplicationView
    {
         int ApplicationId { get; set; }
         int ApplicationBuildingId { get; set; }
         int ApplicationApartmentId { get; set; }
         string ApplicationApartmentStatus { get; set; }
         int ApplicationTenantId { get; set; }
         bool IsWaitingList { get; set; }
         DateTime ApplyDate { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


        //Events
        event EventHandler SearchEventApplication;
        event EventHandler AddNewEventApplication;
        event EventHandler DeleteEventApplication;
        event EventHandler UpdateEventApplication;
        event EventHandler CancelEventApplication;
        event EventHandler SaveEventApplication;

        //Methods

        //buildings methods
        void SetApplicatioListBindingSource(BindingSource buildingList);
        void Show(); //Optional
    }
}
