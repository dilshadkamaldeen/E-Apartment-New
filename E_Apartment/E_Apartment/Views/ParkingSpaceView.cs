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

    public partial class ParkingSpaceView : Form, IParkingSpaceView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ParkingSpaceView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            btnRefresh.Click += delegate {

               RefreshEventParkingSpaceReservation?.Invoke(this, EventArgs.Empty);
            };

        }

        private static ParkingSpaceView instance;

        public event EventHandler SearchEventParkingSpace;
        public event EventHandler AddNewEventParkingSpace;
        public event EventHandler DeleteEventParkingSpace;
        public event EventHandler EditEventParkingSpace;
        public event EventHandler CancelEventParkingSpace;
        public event EventHandler SaveEventParkingSpace;
        public event EventHandler UpdateEventParkingSpace;
        public event EventHandler SaveEventParkingSpaceReservation;
        public event EventHandler RefreshEventParkingSpaceReservation;

        public static ParkingSpaceView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ParkingSpaceView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                }; //creating new instance

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

        public string SearchValue { get => txtSearchParkingSpace.Text; set => txtSearchParkingSpace.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccess { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }


        //Model Binding
        public int ParkingId { get => Convert.ToInt32(lblBuildingId.Text); set => txtSearchParkingSpace.Text = value.ToString(); }
        public string ParkingName { get => txtParkingSpaceName.Text; set => txtParkingSpaceName.Text = value; }
        public int ParkingSize { get => Convert.ToInt32(txtParkingSpaceSize.Text); set => txtParkingSpaceSize.Text = value.ToString(); }
        public string ParkingType { get => comboParkingSpaceType.Text; set => comboParkingSpaceType.Text = value; }
        public bool ParkingStatus { get => Convert.ToBoolean(checkBoxParkingSpaceStatus.Checked); set => checkBoxParkingSpaceStatus.Checked = value; }
        public bool IsReserved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        //Parking Space Detail Model properties
        public int ParkingSpaceId { get => Convert.ToInt32(txtReservationParkingSpaceId.Text); set => txtReservationParkingSpaceId.Text = value.ToString(); }
        public int LeaseAgreementId { get => Convert.ToInt32(txtReservationLeaseAgreementId.Text); set => txtReservationLeaseAgreementId.Text = value.ToString(); }
        public DateTime ReservedDate { get => txtReservationDate.Value; set => txtReservationDate.Value = value; }
        public bool ParkingSpaceDetailStatus { get => checkBoxParkingReservationStatus.Checked; set => checkBoxParkingReservationStatus.Checked = value; }
        public string ParkingSpaceFeedback { get => txtParkingFeedback.Text; set => txtParkingFeedback.Text = value; }

        //public Action<object, EventArgs> RefreshEventParkingSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        // public bool ParkingStatus { get => txtSearchParkingSpace.Text; set => txtSearchParkingSpace.Text = value; }

        public void SetBindingSource(BindingSource bindingSource)
        {
            dataGridViewParkingSpace.DataSource = bindingSource;
        }

        private void AssociateAndRaiseViewEvent()
        {
            btnParkingSpaceSearch.Click += delegate { SearchEventParkingSpace?.Invoke(this, EventArgs.Empty); };
            txtSearchParkingSpace.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                { SearchEventParkingSpace?.Invoke(this, EventArgs.Empty); }

            };



            btnSaveParkingSpace.Click += delegate
            {
                SaveEventParkingSpace?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }

            };

            btnSaveParkingReservation.Click += delegate
            {
                SaveEventParkingSpaceReservation?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }

            };
            dataGridViewParkingSpace.CellClick += delegate
            {

                EditEventParkingSpace?.Invoke(this, EventArgs.Empty);

            };

            btnUpdateParkingSpace.Click += delegate
            {
                SaveEventParkingSpace?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }

            };
            btnDeleteParkingSpace.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Parking Space ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventParkingSpace?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearParkingSpace.Click += delegate
            {

                CancelEventParkingSpace?.Invoke(this, EventArgs.Empty);

            };
        }

        public void SetParkingSpaceReservationBindingSource(BindingSource bindingSource)
        {
             dataGridViewParkingReservation.DataSource = bindingSource;
        }
    }
}
