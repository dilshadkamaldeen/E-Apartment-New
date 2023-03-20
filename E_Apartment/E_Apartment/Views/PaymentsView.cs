using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment.Views
{
    public partial class PaymentsView : Form, IPaymentView
    {

        private bool isReservationFeePayment;
        private int reservationId;
        private bool isDuePayment;
        private bool isSuccessful;
        private bool isEdit;
        private string message;


        public PaymentsView()
        {
            InitializeComponent();

            btnSaveBuilding.Click += delegate
            {
                SaveEventPayment?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }

            };
        }

        private static PaymentsView instance;
        public static PaymentsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PaymentsView(); //creating new instance
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.Show();
                instance.BringToFront();
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


        public int PaymentId { get => Convert.ToInt32(lblPaymentId.Text); set => lblPaymentId.Text = value.ToString(); }
        public string PaymentType { get => comboPaymentType.Text; set => comboPaymentType.Text = value; }
        public decimal PaidAmount { get => Convert.ToDecimal(txtPaymentAmount.Text); set => txtPaymentAmount.Text = value.ToString(); }
        public DateTime PaidDate { get => txtPaymentDate.Value; set => txtPaymentDate.Value = value; }
        public bool IsReservationFeePayment { get => isReservationFeePayment; set => isReservationFeePayment = value; }
        public int ReservationId { get => reservationId; set => reservationId = value; }
        public bool IsDuePayment { get => isDuePayment; set => isDuePayment = value; }
        public int LeaseAgreementId { get => string.IsNullOrWhiteSpace(txtLeaseAgreementId.Text) == true ? 0 : Convert.ToInt32(txtLeaseAgreementId.Text); set => txtLeaseAgreementId.Text = value.ToString(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccess { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEventPayment;
        public event EventHandler AddNewEventPayment;
        public event EventHandler DeleteEventPayment;
        public event EventHandler UpdateEventPayment;
        public event EventHandler CancelEventPayment;
        public event EventHandler SaveEventPayment;
        public event EventHandler EditEventPayment;

        public void SetPaymentListBindingSource(BindingSource paymentList)
        {
            dataGridViewPayments.DataSource = paymentList;
        }
    }
}
