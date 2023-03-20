using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Presenter;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views
{
    public partial class LeaseAgreementView : Form, ILeaseAgreementView, IMainView
    {
        private string message;
        private bool isEdit;
        private bool isSuccess;
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;

        public LeaseAgreementView()
        {
            InitializeComponent();

           
           

            comboReservation.SelectedIndexChanged += delegate
            { 
                leaseComboChange?.Invoke(this, EventArgs.Empty);

                txtFirstMonthRent.Text = apartmentRentPerMonth;
                txtReservationFee.Text = reservationFee;
                txtReservationFee.Text = reservationFee;
                checkBoxIsReservationFeePaid.Checked = true;
               

            };

             

            btnSaveLeasing.Click += delegate
            {

                SaveEventLeaseAgreement?.Invoke(this, EventArgs.Empty);

                if (IsSuccess)
                {
                    MessageBox.Show(Message);
                    if (checkBoxAllocateDefaultParking.Checked)
                    {
                        IParkingSpaceView parkingSpaceView = new ParkingSpaceView();
                        IParkingSpaceRepository buildingRepository = new ParkingSpaceRepository(sqlConnectionString);

                        var result = MessageBox.Show("Are you want to reserve Parking Space ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            new ParkingSpacePresenter(parkingSpaceView, buildingRepository);
                            
                             
                            parkingSpaceView.LeaseAgreementId = LeaseAgreementId;
                            parkingSpaceView.ReservedDate = DateTime.UtcNow;
                            parkingSpaceView.ParkingSpaceDetailStatus = true;
                        }

                        //Bind with Presenter
                        
                    }
                         
                  
                }

            };

        }

        public void SetApartmentNoIntoComboBox(BindingSource bindingSource)
        {
            //comboApartmentNo.DataSource = bindingSource;
            //comboApartmentNo.DisplayMember = "ApartmentNo";
            //comboApartmentNo.ValueMember = "ApartmentId";

        }

        public void SetBuildingsIntoComboBox(BindingSource bindingSource)
        {
            //comboBuildingName.DataSource = bindingSource;
            //comboBuildingName.DisplayMember = "BuildingName";
            //comboBuildingName.ValueMember = "Id";


        }

        public void SetLeaseBindingSource(BindingSource bindingSource)
        {
            dataGridViewLeaseAgreement.DataSource = bindingSource;
        }

        public void SetTenantsNamesIntoComboBox(BindingSource bindingSource)
        {
            //comboTenantsName.DataSource = bindingSource;
            //comboTenantsName.DisplayMember = "TenantName";
            //comboTenantsName.ValueMember = "TenantId";
        }

        private static LeaseAgreementView instance;

        private ApartmentModel apartmentModelView;

        public int reservationId
        {
            get => Convert.ToInt32(comboReservation.SelectedValue == null || comboReservation.SelectedValue.GetType() == typeof(int) ? comboReservation.SelectedValue : 0);
            set => comboReservation.SelectedValue = value;
        }
       
        public int buildingId { get => Convert.ToInt32(lblBuildingId.Text); set => lblBuildingId.Text = value.ToString(); }
        public int? apartmentId { get => Convert.ToInt32(lblApartmentId.Text); set => lblApartmentId.Text = value.ToString(); }
        public int apartmentClassId { get; set; }
        public string apartmentClassName { get => lblApartmentClass.Text; set => lblApartmentClass.Text = value; }
        public string apartmentMaxNoOcc { get => lblMaxNumberOcc.Text; set => lblMaxNumberOcc.Text = value; }
        public string apartmentRentPerMonth { get => lblRentPerMonth.Text; set => lblRentPerMonth.Text = value; }
        public string apartmentDiningArea { get => lblDiningArea.Text; set => lblDiningArea.Text = value; }
        public string apartmentLivingArea { get => lblLivingArea.Text; set => lblLivingArea.Text = value; }
        public string apartmentKitchenArea { get => lblKitchenArea.Text; set => lblKitchenArea.Text = value; }
        public string apartmentBedroomCount { get => lblBedRoomCount.Text; set => lblBedRoomCount.Text = value; }
        public string apartmentCommonBathroom { get => lblCommonBathroom.Text; set => lblCommonBathroom.Text = value; }
        public string apartmentAttachBathroom { get => lblAttachBathroom.Text; set => lblAttachBathroom.Text = value; }
        public string servantsRoomCount { get => lblServentRoomCount.Text; set => lblServentRoomCount.Text = value; }
        public string servantToiletCount { get => lblServentToiletCount.Text; set => lblServentToiletCount.Text = value; }
        public string apartmentStatus { get => lblApartmentStatus.Text; set => lblApartmentStatus.Text = value; }
        public string apartmentNo { get => lblLeaseApartmentNo.Text; set => lblLeaseApartmentNo.Text = value; }
        public DateTime startDate { get => txtStartDate.Value; set => txtStartDate.Value = Convert.ToDateTime(value); }
        public DateTime endDate { get => txtEndDate.Value; set => txtEndDate.Value = Convert.ToDateTime(value); }
        public string reservationFee { get => txtReservationFee.Text; set => txtReservationFee.Text = value; }
        public string tenantsId { get => lblLeaseTenantId.Text; set => lblLeaseTenantId.Text = value; }
        public string tenantsName { get => lblLeaseTenantName.Text; set => lblLeaseTenantName.Text = value; }
        public string buildingName { get => lblBuildingName.Text; set => lblBuildingName.Text = value; }


        #region Lease Agreement Model
        public int LeaseAgreementId { get => Convert.ToInt32(lblLeaseAgreementId.Text); set => lblLeaseAgreementId.Text = value.ToString(); }
        public int ReservationId { get => reservationId; set => reservationId = value; }
        public int TenantId { get => Convert.ToInt32(tenantsId); set => tenantsId= value.ToString(); }
        public decimal RefundableDeposit { get => Convert.ToDecimal(txtAdvanceAmount.Text); set => txtAdvanceAmount.Text= value.ToString(); }
        public decimal FirstMonthRent { get => Convert.ToDecimal(txtFirstMonthRent.Text); set => txtFirstMonthRent.Text= value.ToString(); }
        public decimal TotalAdvanceAmount { get => Convert.ToDecimal(txtTotalAdvanceAmount.Text); set => txtTotalAdvanceAmount.Text = value.ToString(); }
        public bool IsTotalAdvancePaid { get =>  checkBoxIsAdvancePaid.Checked; set => checkBoxIsAdvancePaid.Checked = value; }
        public string Term { get => comboLeaseAgreementTerm.Text; set => comboLeaseAgreementTerm.Text = value; }
        public DateTime LeaseStartDate { get => txtStartDate.Value; set => txtStartDate.Value = value; }
        public DateTime LeaseExpireDate { get => txtEndDate.Value; set => txtEndDate.Value = value; }
        public decimal TotalDueAmount { get => Convert.ToDecimal(txtTotalDueAmount.Text); set => txtTotalDueAmount.Text = value.ToString(); }
        public bool IsAllocateDefaultParking { get =>  checkBoxAllocateDefaultParking.Checked; set => checkBoxAllocateDefaultParking.Checked = value; }
        public bool LeaseAgreementStatus { get =>  checkBoxLeaseAgreementStatus.Checked; set => checkBoxLeaseAgreementStatus.Checked = value; }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        public string Message { get => message; set => message = value; }

        #endregion

        //ApartmentModel SelectedApartment { get => apartmentModelView; set => apartmentModelView = value; }

        public event EventHandler SearchEventLeaseAgreement;
        public event EventHandler AddNewEventLeaseAgreement;
        public event EventHandler DeleteEventLeaseAgreement;
        public event EventHandler EditEventLeaseAgreement;
        public event EventHandler CancelEventLeaseAgreement;
        public event EventHandler SaveEventLeaseAgreement;
        public event EventHandler UpdateEventLeaseAgreement;
        public event EventHandler buildingComboChange;
        public event EventHandler apartmentComboChange;
        public event EventHandler leaseComboChange;
        public event EventHandler ShowBuildingView;
        public event EventHandler CloseBuildingView;
        public event EventHandler ShowParkingSpaceView;
        public event EventHandler CloseParkingSpaceView;
        public event EventHandler ShowTenantsView;
        public event EventHandler ShowLeaseAgreementView;
        public event EventHandler ShowReservationView;
        public event EventHandler CloseTenantsView;
        public event EventHandler ShowPaymentView;

        public static LeaseAgreementView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LeaseAgreementView(); //creating new instance
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;

            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }

                instance.BringToFront();  //otherwise bring front
            }
            return instance;
        }
         
        private void txtAdvanceAmount_TextChanged(object sender, EventArgs e)
        {
            txtTotalAdvanceAmount.Text = (Convert.ToDecimal(txtAdvanceAmount.Text) + Convert.ToDecimal(txtFirstMonthRent.Text)).ToString();
        }

        private void comboLeaseAgreementTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calculate total due
            CalculateTotalDueAndExpireDate();
        }

        private void txtStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalDueAndExpireDate();

        }

        void CalculateTotalDueAndExpireDate()
        {
            if (comboLeaseAgreementTerm.Text == "1 Year")
            {
                txtTotalDueAmount.Text = (Convert.ToDecimal(txtFirstMonthRent.Text) * 12).ToString();

                DateTime dateTimeObj = DateTime.Parse(txtStartDate.Value.ToString());
                DateTime futureDate = dateTimeObj.AddMonths(12).Subtract(TimeSpan.FromDays(1));
                txtEndDate.Value = futureDate;
            }
            else if (comboLeaseAgreementTerm.Text == "2 Year")
            {
                txtTotalDueAmount.Text = (Convert.ToDecimal(txtFirstMonthRent.Text) * 12 * 2).ToString();
                DateTime dateTimeObj = DateTime.Parse(txtStartDate.Value.ToString());
                DateTime futureDate = dateTimeObj.AddMonths(12 * 2).Subtract(TimeSpan.FromDays(1));
                txtEndDate.Value = futureDate;
            }
            else if (comboLeaseAgreementTerm.Text == "3 Year")
            {
                txtTotalDueAmount.Text = (Convert.ToDecimal(txtFirstMonthRent.Text) * 12 * 3).ToString();
                DateTime dateTimeObj = DateTime.Parse(txtStartDate.Value.ToString());
                DateTime futureDate = dateTimeObj.AddMonths(12 * 3).Subtract(TimeSpan.FromDays(1));
                txtEndDate.Value = futureDate;
            }
        }

        public void SetReservationIntoComboBox(BindingSource bindingSource)
        {
            comboReservation.DataSource = bindingSource;
            comboReservation.DisplayMember = "reservationId";
            comboReservation.ValueMember= "reservationId";

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetLoginUser(string loginUser)
        {
            throw new NotImplementedException();
        }
    }
}
