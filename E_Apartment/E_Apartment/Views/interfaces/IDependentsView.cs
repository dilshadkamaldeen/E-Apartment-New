using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IDependentsView
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }


         int DependentId { get; set; }
         int DependentTenantId { get; set; }
         string DependentName { get; set; }
         string DependentRelationship { get; set; }
         string DependentGender { get; set; }
         bool DependentStatus { get; set; }


        //Data fields


        //Events
        event EventHandler SearchEventDependents;
        event EventHandler AddNewEventDependents;
        event EventHandler DeleteEventDependents;
        event EventHandler EditEventDependents;
        event EventHandler CancelEventDependents;
        event EventHandler SaveEventDependents;
        event EventHandler UpdateEventDependents;

        //buildings methods
        void SetDependentsBindingSource(BindingSource bindingSource);
        void SetDependentsNamesIntoComboBox(BindingSource bindingSource);

        void Show(); //Optional

    }
}
