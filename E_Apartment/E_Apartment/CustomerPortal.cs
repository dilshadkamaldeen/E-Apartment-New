using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class CustomerPortal : Form
    {
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
        private IEnumerable<LeaseExtensionModel> leaseExtensionList;
        private IEnumerable<LeasingAgreementModel> occupiedList;
        private IEnumerable<ApplicationModel> applicationList;
        private IEnumerable<ReservationModel> reservationList;


        private ReservationRepository reservationRepository;
        private LeaseExtensionRepository leaseExtensionRepository;
        private LeasingAgreementRepository leaseRepository;
        private ApplicationRepository applicationRepository;

        private string message;
        private bool isSuccess;
        public CustomerPortal(string username, string customerid)
        {
            InitializeComponent();
            lblUserName.Text = username;
            lblTenantId.Text = customerid;

            reservationRepository = new ReservationRepository(sqlConnectionString);
            leaseExtensionRepository = new LeaseExtensionRepository(sqlConnectionString);
            leaseRepository = new LeasingAgreementRepository(sqlConnectionString);
            applicationRepository = new ApplicationRepository(sqlConnectionString);

            LoadGrid();
        }

        public string Message { get => message; private set => message = value; }
        public bool IsSuccess { get => isSuccess; private set => isSuccess = value; }
       
        private void SaveLeaseExtension()
        {
            var model = new LeaseExtensionModel();           
            model.ExtensionMonths = Convert.ToInt32(txtExtensionPeriods.Text);
            model.ExtensionStatus = comboStatus.Text;
            model.TenantId = Convert.ToInt32(txtTenantId.Text);
            model.LeaseAgreementId = Convert.ToInt32(txtLeaseAgreementId.Text);

            try
            {                
                new Utility.ModelValidator().Validate(model);
                leaseExtensionRepository.Add(model);
                this.Message = "Extension Request Sent Successfully";
                this.IsSuccess = true;
            }
            catch (Exception ex)
            {
                this.IsSuccess = false;
                this.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            SaveLeaseExtension();
            MessageBox.Show(Message);
            LoadGrid();
        }

        private void LoadGrid()
        {
            leaseExtensionList = leaseExtensionRepository.GetByTenantId(lblTenantId.Text);
            dataGridViewExtension.DataSource = leaseExtensionList;

            occupiedList = leaseRepository.GetByTenantId(lblTenantId.Text);
            dataGridViewOccupied.DataSource = occupiedList;

            reservationList = reservationRepository.GetByTenantId(lblTenantId.Text);
            dataGridViewReserve.DataSource = reservationList;

            applicationList = applicationRepository.GetByTenantId(lblTenantId.Text);
            dataGridViewApplication.DataSource = applicationList;
        }
    }
}
