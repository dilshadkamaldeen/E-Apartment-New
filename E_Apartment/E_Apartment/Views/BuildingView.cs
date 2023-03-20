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
    public partial class BuildingView : Form, IBuildingView, IApartmentClassView, IApartmentView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private bool isApartmentClassEdit;
        private bool isApartmentEdit;


        //Constructor
        public BuildingView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            // buildingTabControl.TabPages.Remove(tabPage1);
        }

        /// <summary>
        /// delegate are used in C# to enable methods to be passed as arguments to other methods. This is useful when you want to specify a particular method to be executed when an event occurs, or when you want to pass a method as a parameter to another method.
        /// </summary>
        private void AssociateAndRaiseViewEvent()
        {
            btnBuildingSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchBuilding.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                { SearchEvent?.Invoke(this, EventArgs.Empty); }

            };

            //Add new 
            btnSaveBuilding.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };

            //Update  
            // btnUpdateBuilding.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            dataGridViewBuilding.CellClick += delegate
            {

                UpdateEvent?.Invoke(this, EventArgs.Empty);

                //disable add button
                btnSaveBuilding.Enabled = false;



            };

            //Delete 
            btnDeleteBuilding.Click += delegate
            {



                var result = MessageBox.Show("Are you sure to delete the Building", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }
            };

            //Save New Building Event
            btnSaveBuilding.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }

            };

            //Save New Building Event
            btnUpdateBuilding.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                    btnSaveBuilding.Enabled = true;

                }

            };

            //clear all
            btnClearBuilding.Click += delegate
            {

                CancelEvent?.Invoke(this, EventArgs.Empty);

            };


            //Apartment Class
            btnApartmentClassAdd.Click += delegate
            {



                SaveEventApartmentClass?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }


            };
            dataGridViewApartmentClass.CellClick += delegate
            {

                EditEventApartmentClass?.Invoke(this, EventArgs.Empty);

                //disable add button




            };
            btnApartmentClassUpdate.Click += delegate
            {
                SaveEventApartmentClass?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                    btnApartmentClassAdd.Enabled = true;

                }

            };
            btnDeleteApartmentClass.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Apartment Class", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventApartmentClass?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearApartmentClass.Click += delegate
            {

                CancelEventApartmentClass?.Invoke(this, EventArgs.Empty);

            };


            //Apartment 
            btnApartmentAdd.Click += delegate {

                AddNewEventApartment?.Invoke(this, EventArgs.Empty);
                buildingTabControl.SelectedIndex = buildingTabControl.SelectedIndex - 1;
            };
            btnApartmentSave.Click += delegate
            {



                SaveEventApartment?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }


            };
            dataGridViewApartment.CellClick += delegate
            {

                buildingTabControl.SelectedIndex = buildingTabControl.SelectedIndex - 1;


                EditEventApartment?.Invoke(this, EventArgs.Empty);

                //disable add button




            };
            btnApartmentUpdate.Click += delegate
            {
                SaveEventApartment?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                    btnApartmentAdd.Enabled = true;

                }

            };
            btnDeleteApartment.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Apartment ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventApartment?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearApartment.Click += delegate
            {

                CancelEventApartment?.Invoke(this, EventArgs.Empty);

            };


        }


        #region Building
        public int BuildingId { get => Convert.ToInt32(lblBuildingId.Text); set => lblBuildingId.Text = value.ToString(); }
        public string BuildingName { get => txtBuildingName.Text; set => txtBuildingName.Text = value; }
        public string BuildingLocation { get => txtBuildingLocation.Text; set => txtBuildingLocation.Text = value; }
        public string BuildingAddress { get => txtBuildingAddress.Text; set => txtBuildingAddress.Text = value; }
        public string SearchValue { get => txtSearchBuilding.Text; set => txtSearchBuilding.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccess { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SaveEvent;

        //Methods
        public void SetBuildingListBindingSource(BindingSource buildingList)
        {
            dataGridViewBuilding.DataSource = buildingList;
        }


        #endregion


        #region Apartment Class
        public bool IsApartmentClassEdit { get => isApartmentClassEdit; set => isApartmentClassEdit = value; }
        public int ClassNameId { get => Convert.ToInt32(lblApartmentClassId.Text); set => lblApartmentClassId.Text = value.ToString(); }
        public string ClassName { get => txtApartmentClassName.Text; set => txtApartmentClassName.Text = value; }
        public bool IsBedroomAvailable { get => checkBoxBedroom.Checked; set => checkBoxBedroom.Checked = value; }
        public int BedroomCount { get => Convert.ToInt32(txtApartmentClassBedroomCount.Text); set => txtApartmentClassBedroomCount.Text = value.ToString(); }
        public bool IsCommonBathroomAvailable { get => checkBoxCommonBathroom.Checked; set => checkBoxCommonBathroom.Checked = value; }
        public int CommonBathroomCount { get => Convert.ToInt32(txtApartmentClassBathroom.Text); set => txtApartmentClassBathroom.Text = value.ToString(); }
        public bool IsAttachBathroomAvailalbe { get => checkBoxAttachBathroom.Checked; set => checkBoxAttachBathroom.Checked = value; }
        public int AttachBathroomCount { get => Convert.ToInt32(txtApartmentClassAttachBathroomCount.Text); set => txtApartmentClassAttachBathroomCount.Text = value.ToString(); }
        public bool IsServantsRoomAvailable { get => checkBoxServantRoom.Checked; set => checkBoxServantRoom.Checked = value; }
        public int ServantsRoomCount { get => Convert.ToInt32(txtApartmentClassServantRoomCount.Text); set => txtApartmentClassServantRoomCount.Text = value.ToString(); }
        public bool IsServantToiletAvailable { get => checkBoxServantToilet.Checked; set => checkBoxServantToilet.Checked = value; }
        public int ServantToiletCount { get => Convert.ToInt32(txtApartmentClassServantToiletCount.Text); set => txtApartmentClassServantToiletCount.Text = value.ToString(); }
        public bool Status { get => checkBoxActive.Checked; set => checkBoxActive.Checked = value; }

        //Apartment Class Event
        public event EventHandler SearchEventApartmentClass;
        public event EventHandler AddNewEventApartmentClass;
        public event EventHandler DeleteEventApartmentClass;
        public event EventHandler EditEventApartmentClass;
        public event EventHandler CancelEventApartmentClass;
        public event EventHandler SaveEventApartmentClass;

        public void SetApartmentClassListBindingSource(BindingSource apartmentClassList)
        {
            dataGridViewApartmentClass.DataSource = apartmentClassList;
        }


        #endregion


        #region Apartment
        //Apartment Model
        public int ApartmentId { get => Convert.ToInt32(lblApartmentId.Text); set => lblApartmentId.Text = value.ToString(); }
        public int ApartmentClassId { get => Convert.ToInt32(comboApartmentClass.SelectedValue); set => comboApartmentClass.SelectedValue = value; }
        public int ApartmentBuildingId { get => Convert.ToInt32(comboApartmentBuildingName.SelectedValue); set => comboApartmentBuildingName.SelectedValue = value; }
        public int ApartmentNo { get => Convert.ToInt32(txtApartmentNo.Text); set => txtApartmentNo.Text = value.ToString(); }
        public decimal ApartmentRentPerMonth { get => Convert.ToDecimal(txtApartmentRentRate.Text); set => txtApartmentRentRate.Text = value.ToString(); }
        public int MaxNumberOccupied { get => Convert.ToInt32(txtApartmentMaxNumOccupaied.Text); set => txtApartmentMaxNumOccupaied.Text = value.ToString(); }
        public string ApartmentStatus { get => comboApartmentStatus.Text; set => comboApartmentStatus.Text = value; }
        public bool IsLivingArea { get => Convert.ToBoolean(checkBoxLiving.Checked); set => checkBoxLiving.Checked = value; }
        public decimal LivingAreaSqft { get => Convert.ToDecimal(txtLivingAreaSqft.Text); set => txtLivingAreaSqft.Text = value.ToString(); }
        public bool IsDiningArea { get => Convert.ToBoolean(checkBoxDining.Checked); set => checkBoxDining.Checked = value; }
        public decimal DiningAreaSqft { get => Convert.ToDecimal(txtDiningAreaSqft.Text); set => txtDiningAreaSqft.Text = value.ToString(); }
        public bool IsKitchenArea { get => Convert.ToBoolean(checkBoxKitchen.Checked); set => checkBoxKitchen.Checked = value; }
        public decimal KitchenAreaSqft { get => Convert.ToDecimal(txtKitchenAreaSqft.Text); set => txtKitchenAreaSqft.Text = value.ToString(); }
        public bool IsLaundryArea { get => Convert.ToBoolean(checkBoxLaundry.Checked); set => checkBoxLaundry.Checked = value; }
        public decimal LaundryAreaSqft { get => Convert.ToDecimal(txtLaundryAreaSqft.Text); set => txtLaundryAreaSqft.Text = value.ToString(); }
        public bool IsTelephoneService { get => Convert.ToBoolean(checkBoxTelephone.Checked); set => checkBoxTelephone.Checked = value; }
        public bool IsBroadbandInternet { get => Convert.ToBoolean(checkBoxBroadband.Checked); set => checkBoxBroadband.Checked = value; }
        public bool IsCableTv { get => Convert.ToBoolean(checkBoxCableTv.Checked); set => checkBoxCableTv.Checked = value; }
        public bool IsParkingArea { get => Convert.ToBoolean(checkBoxParkingArea.Checked); set => checkBoxParkingArea.Checked = value; }
        public bool IsGymnasium { get => Convert.ToBoolean(checkBoxgym.Checked); set => checkBoxgym.Checked = value; }
        public bool IsSwimingPool { get => Convert.ToBoolean(checkBoxSwimingPool.Checked); set => checkBoxSwimingPool.Checked = value; }
        public bool IsApartmentEdit { get => isApartmentEdit; set => isApartmentEdit = value; }
        public decimal ReservationFee { get => Convert.ToDecimal(txtReservationFee.Text); set => txtReservationFee.Text = value.ToString(); }

        //Apartment Events
        public event EventHandler SearchEventApartment;
        public event EventHandler AddNewEventApartment;
        public event EventHandler DeleteEventApartment;
        public event EventHandler EditEventApartment;
        public event EventHandler CancelEventApartment;
        public event EventHandler SaveEventApartment;

        public void SetBuildingNamesIntoComboBox(BindingSource buildingList)
        {

            comboApartmentBuildingName.DisplayMember = "BuildingName";
            comboApartmentBuildingName.ValueMember = "Id";
            comboApartmentBuildingName.DataSource = buildingList;

        }
        public void SetApartmentClassNamesIntoComboBox(BindingSource bindingSource)
        {
            comboApartmentClass.DataSource = bindingSource;
            comboApartmentClass.DisplayMember = "ClassName";
            comboApartmentClass.ValueMember = "ClassNameId";


        }
        public void SetApartmentListBindingSource(BindingSource apartmentList)
        {
            dataGridViewApartment.DataSource = apartmentList;
        }



        #endregion



        //Singleton pattern (Open a single form not multiple instance)
        private static BuildingView instance;
        public static BuildingView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BuildingView(); //creating new instance
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.Show();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveBuilding_Click(object sender, EventArgs e)
        {

        }
 
    }
}
