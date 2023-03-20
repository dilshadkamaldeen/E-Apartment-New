using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface ITenantsView
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }

        int DependentTenantId { get; set; }  
        string TenantName { get; set; }
        string TenantNIC { get; set; }
        string TenantContact { get; set; }
        string TenantAddress { get; set; }
        string TenantGender { get; set; }
        bool TenantStatus { get; set; }
        string TenantFeedback { get; set; }



        //Data fields


        //Events
        event EventHandler SearchEventTenants;
        event EventHandler AddNewEventTenants;
        event EventHandler DeleteEventTenants;
        event EventHandler EditEventTenants;
        event EventHandler CancelEventTenants;
        event EventHandler SaveEventTenants;
        event EventHandler UpdateEventTenants;
        event EventHandler RefreshEventTenants;

        //buildings methods
        void SetBindingSource(BindingSource bindingSource);
        void SetTenantsNamesIntoComboBox(BindingSource bindingSource);

        void Show(); //Optional

    }
}
