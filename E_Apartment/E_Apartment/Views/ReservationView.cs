using E_Apartment.Models;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views
{

    public partial class ReservationView : Form, IReservationView, IApplicationView
    {
        private bool isSuccess;
        private string message;
        private bool isEdit;

        #region Reservation
        public int ReservationId
        {
            get =>
                Convert.ToInt32(lblReservationId.Text);
            set =>
              lblReservationId.Text = value.ToString();
        }
        public DateTime ReservationDate
        {
            get =>
              throw new NotImplementedException();
            set =>
              throw new NotImplementedException();
        }
        public string ReservationFee
        {
            get =>
              txtReservationFees.Text;
            set =>
              txtReservationFees.Text = value;
        }
        public string IsReservationPaid
        {
            get =>
              checkBoxIsReservationPaid.Checked.ToString();
            set =>
              checkBoxIsReservationPaid.Checked = Convert.ToBoolean(value);
        }
        public string ReservationTenantId
        {
            get =>
              comboTenantsName.SelectedValue.ToString();
            set =>
              comboTenantsName.SelectedValue = value;
        }
        public string ReservationApartmentId
        {
            get =>
              comboApartmentNo.SelectedValue.ToString();
            set =>
              comboApartmentNo.SelectedValue = value;
        }
        public string ReservationStatus
        {
            get =>
             checkBoxReservationStatus.Checked.ToString();
            set =>
              checkBoxReservationStatus.Checked = Convert.ToBoolean(value);
        }
        public bool IsReservationFeePaid
        {
            get =>
              checkBoxIsReservationPaid.Checked;
            set =>
              checkBoxIsReservationPaid.Checked = value;
        }
        public string ReservationApartmentStatus
        {
            get =>
              apartmentStatus;
            set =>
              apartmentStatus = value;
        }
        public int ReservationBuildingId
        {
            get =>
              buildingId;
            set =>
              buildingId = value;
        }

        public string SearchValue
        {
            get =>
              throw new NotImplementedException();
            set =>
              throw new NotImplementedException();
        }
        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccess
        {
            get => isSuccess;
            set => isSuccess = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        #endregion


        //Others
        public int buildingId
        {
            get => Convert.ToInt32(comboBuildingName.SelectedValue == null || comboBuildingName.SelectedValue.GetType() == typeof(int) ? comboBuildingName.SelectedValue : 0);
            set => comboBuildingName.SelectedValue = value;
        }
        public int? apartmentId
        {
            get => Convert.ToInt32(comboApartmentNo.SelectedValue == null || comboApartmentNo.SelectedValue.GetType() == typeof(int) ? comboApartmentNo.SelectedValue : 0);
            set => comboApartmentNo.SelectedItem = value;
        }
        public int apartmentClassId
        {
            get;
            set;
        }
        public string apartmentClassName
        {
            get => lblApartmentClass.Text;
            set => lblApartmentClass.Text = value;
        }
        public string apartmentMaxNoOcc
        {
            get => lblMaxNumberOcc.Text;
            set => lblMaxNumberOcc.Text = value;
        }
        public string apartmentRentPerMonth
        {
            get => lblRentPerMonth.Text;
            set => lblRentPerMonth.Text = value;
        }
        public string apartmentDiningArea
        {
            get => lblDiningArea.Text;
            set => lblDiningArea.Text = value;
        }
        public string apartmentLivingArea
        {
            get => lblLivingArea.Text;
            set => lblLivingArea.Text = value;
        }
        public string apartmentKitchenArea
        {
            get => lblKitchenArea.Text;
            set => lblKitchenArea.Text = value;
        }
        public string apartmentBedroomCount
        {
            get => lblBedRoomCount.Text;
            set => lblBedRoomCount.Text = value;
        }
        public string apartmentCommonBathroom
        {
            get => lblCommonBathroom.Text;
            set => lblCommonBathroom.Text = value;
        }
        public string apartmentAttachBathroom
        {
            get => lblAttachBathroom.Text;
            set => lblAttachBathroom.Text = value;
        }
        public string servantsRoomCount
        {
            get => lblServentRoomCount.Text;
            set => lblServentRoomCount.Text = value;
        }
        public string servantToiletCount
        {
            get => lblServentToiletCount.Text;
            set => lblServentToiletCount.Text = value;
        }
        public string apartmentStatus
        {
            get => lblApartmentStatus.Text;
            set => lblApartmentStatus.Text = value;
        }
        public string apartmentNo
        {
            get => lblApartmentNo.Text;
            set => lblApartmentNo.Text = value;
        }
        public string reservationFee
        {
            get => txtReservationFees.Text;
            set => txtReservationFees.Text = value;
        }

        #region Application
        public bool IsWaitingList
        {
            get => checkBoxAppIsWaiting.Checked;
            set => checkBoxAppIsWaiting.Checked = value;
        }
        public int ApplicationId
        {
            get => Convert.ToInt32(lblApplicationId.Text);
            set => lblApplicationId.Text = value.ToString();
        }
        public int ApplicationBuildingId
        {
            get => Convert.ToInt32(txtAppBuildingId.Text);
            set => txtAppBuildingId.Text = value.ToString();
        }
        public int ApplicationApartmentId
        {
            get => Convert.ToInt32(txtAppApartmentId.Text);
            set => txtAppApartmentId.Text = value.ToString();
        }
        public string ApplicationApartmentStatus
        {
            get => txtAppApartmentStatus.Text;
            set => txtAppApartmentStatus.Text = value;
        }
        public int ApplicationTenantId
        {
            get => Convert.ToInt32(txtAppTenantId.Text);
            set => txtAppTenantId.Text = value.ToString();
        }
        public DateTime ApplyDate
        {
            get =>
              throw new NotImplementedException();
            set =>
              throw new NotImplementedException();
        }
        #endregion

        public ReservationView()
        {
            InitializeComponent();
            comboBuildingName.SelectedIndexChanged += delegate
            {

                buildingComboChange?.Invoke(this, EventArgs.Empty);

            };

            btnCheckAvailablity.Click += delegate
            {

                if (comboApartmentNo.SelectedItem != null)
                {
                    var msg1 = string.Format("Are you sure to check the Apartment No ({0}) Availabilty ?", comboApartmentNo.Text);
                    var result = MessageBox.Show(msg1, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        apartmentComboChange?.Invoke(this, EventArgs.Empty);

                        label12.Text = txtReservationFees.Text = reservationFee;
                        var msg = string.Format("Apartment No {0} is : {1}", apartmentNo, apartmentStatus);

                        if (apartmentStatus == "Vacant")
                        {

                            MessageBox.Show(msg, "Apartment Availabilty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnSaveReservation.Visible = btnUpdateReservation.Visible = true;
                        }
                        else
                        {

                            MessageBox.Show(msg, "Apartment Availabilty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            var msg3 = string.Format("Dear {1}, We are sorry for this inconvenience. Are you like to make an application form, It's free of charge and You will be on a waiting list?", comboApartmentNo.Text, comboTenantsName.Text);

                            var result2 = MessageBox.Show(msg3, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result2 == DialogResult.Yes)
                            {

                                txtReservationFees.Text = "0";

                                //Navigate to Application
                                //Create an Application for tenant automatically;

                                ApplicationApartmentId = (int)comboApartmentNo.SelectedValue;
                                ApplicationBuildingId = (int)comboBuildingName.SelectedValue;
                                ApplicationApartmentStatus = apartmentStatus;
                                IsWaitingList = true;
                                ApplicationTenantId = (int)comboTenantsName.SelectedValue;

                                AddNewEventApplication?.Invoke(this, EventArgs.Empty);

                                buildingTabControl.SelectedIndex = 2;
                            }
                            else
                            {

                            }

                        }

                    }

                }
                else
                {
                    var msg = string.Format("Selected Building - {0} doesn't have any apartments", comboBuildingName.Text);

                    MessageBox.Show(msg, "Apartment Availabilty", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            };


            btnSaveReservation.Click += delegate
            {
                SaveEventReservation?.Invoke(this, EventArgs.Empty);
                if (IsSuccess)
                {
                    MessageBox.Show(Message);
                }

            };


            //Application
            btnAddApplication.Click += delegate
            {

                SaveEventApplication?.Invoke(this, EventArgs.Empty);
                if (IsSuccess)
                {
                    MessageBox.Show(Message);
                }

            };
            dataGridViewApplication.CellClick += delegate
            {
                UpdateEventApplication?.Invoke(this, EventArgs.Empty);

            };

            btnApplicationUpdate.Click += delegate
            {
                SaveEventApplication?.Invoke(this, EventArgs.Empty);

                if (IsSuccess)
                {
                    MessageBox.Show(Message);
                }

            };
            btnDeleteApplication.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Application ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventApplication?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearApplication.Click += delegate
            {

                CancelEventApplication?.Invoke(this, EventArgs.Empty);

            };

        }

        public event EventHandler SearchEventReservation;
        public event EventHandler AddNewEventReservation;
        public event EventHandler DeleteEventReservation;
        public event EventHandler UpdateEventReservation;
        public event EventHandler CancelEventReservation;
        public event EventHandler SaveEventReservation;
        public event EventHandler buildingComboChange;
        public event EventHandler apartmentComboChange;
        public event EventHandler SaveEventApplicationReservation;
        public event EventHandler SearchEventApplication;
        public event EventHandler AddNewEventApplication;
        public event EventHandler DeleteEventApplication;
        public event EventHandler UpdateEventApplication;
        public event EventHandler CancelEventApplication;
        public event EventHandler SaveEventApplication;

        private void gunaLabel18_Click(object sender, EventArgs e) { }

        private void comboApartmentNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetReservationListBindingSource(BindingSource buildingList)
        {
            //throw new NotImplementedException();
            dataGridViewReservation.DataSource = buildingList;
        }

        public void SetReservationNamesIntoComboBox(BindingSource buildingList)
        {
            // throw new NotImplementedException();
        }
        public void SetApartmentNoIntoComboBox(BindingSource bindingSource)
        {
            comboApartmentNo.DataSource = bindingSource;
            comboApartmentNo.DisplayMember = "ApartmentNo";
            comboApartmentNo.ValueMember = "ApartmentId";

        }

        public void SetBuildingsIntoComboBox(BindingSource bindingSource)
        {
            comboBuildingName.DataSource = bindingSource;
            comboBuildingName.DisplayMember = "BuildingName";
            comboBuildingName.ValueMember = "Id";

        }

        public void SetTenantsNamesIntoComboBox(BindingSource bindingSource)
        {
            comboTenantsName.DataSource = bindingSource;
            comboTenantsName.DisplayMember = "TenantName";
            comboTenantsName.ValueMember = "TenantId";
        }

        private static ReservationView instance;
        public static ReservationView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReservationView(); //creating new instance
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

                instance.BringToFront(); //otherwise bring front
            }
            return instance;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetLeaseBindingSource(BindingSource bindingSource)
        {
            throw new NotImplementedException();
        }

        private void btnSaveBuilding_Click(object sender, EventArgs e)
        {

        }

        public void SetApplicatioListBindingSource(BindingSource buildingList)
        {
            // throw new NotImplementedException();
            dataGridViewApplication.DataSource = buildingList;
        }
    }
}