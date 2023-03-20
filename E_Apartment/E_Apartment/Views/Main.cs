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
    public partial class Main : Form, IMainView
    {
         
        public Main()
        {
            InitializeComponent();
            //Generate the events
            btnBuildingsManagement.Click += delegate { ShowBuildingView?.Invoke(this, EventArgs.Empty); }; //adding showBuildingView event to the button click
            btnParkingSpace.Click += delegate { ShowParkingSpaceView?.Invoke(this, EventArgs.Empty); };
            btnTanents.Click += delegate { ShowTenantsView?.Invoke(this, EventArgs.Empty); };
            btnLeasing.Click += delegate { ShowLeaseAgreementView?.Invoke(this, EventArgs.Empty); };
            btnReservation.Click += delegate { ShowReservationView?.Invoke(this, EventArgs.Empty); };
            btnPayments.Click += delegate { ShowPaymentView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowBuildingView;
        public event EventHandler CloseBuildingView;
        public event EventHandler ShowParkingSpaceView;
        public event EventHandler CloseParkingSpaceView;
        public event EventHandler ShowTenantsView;
        public event EventHandler CloseTenantsView;
        public event EventHandler ShowLeaseAgreementView;
        public event EventHandler ShowReservationView;
        public event EventHandler ShowPaymentView;

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void btnParkingSpace_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportView rptView = new ReportView();
            rptView.MdiParent = this;
            rptView.FormBorderStyle = FormBorderStyle.None;
            rptView.Dock = DockStyle.Fill;
            rptView.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usersview rptView = new Usersview();
            rptView.MdiParent = this;
            rptView.FormBorderStyle = FormBorderStyle.None;
            rptView.Dock = DockStyle.Fill;
            rptView.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().ShowDialog();
        }

        public void SetLoginUser(string loginUser)
        {
           comboUserType.Text = loginUser;
        }
    }
}
