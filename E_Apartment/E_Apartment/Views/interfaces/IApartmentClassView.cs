using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views.interfaces
{
    internal interface IApartmentClassView
    {
        bool IsApartmentClassEdit { get; set; }
        int ClassNameId { get; set; }
        string ClassName { get; set; }
        bool IsBedroomAvailable { get; set; }
        int BedroomCount { get; set; }
        bool IsCommonBathroomAvailable { get; set; }
        int CommonBathroomCount { get; set; }
        bool IsAttachBathroomAvailalbe { get; set; }
        int AttachBathroomCount { get; set; }
        bool IsServantsRoomAvailable { get; set; }
        int ServantsRoomCount { get; set; }
        bool IsServantToiletAvailable { get; set; }
        int ServantToiletCount { get; set; }
        bool Status { get; set; }
        string Message { get; set; }
        bool IsSuccess { get; set; }

        //Events
        event EventHandler SearchEventApartmentClass;
        event EventHandler AddNewEventApartmentClass;
        event EventHandler DeleteEventApartmentClass;
        event EventHandler EditEventApartmentClass;
        event EventHandler CancelEventApartmentClass;
        event EventHandler SaveEventApartmentClass;

        //Methods
        //Apartment Class data load method
        void SetApartmentClassListBindingSource(BindingSource apartmentClassList);
        void SetApartmentClassNamesIntoComboBox(BindingSource bindingSource);
        

    }
}
