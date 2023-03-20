using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Reports;
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

namespace E_Apartment.Views
{
    public partial class ReportView : Form
    {
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
        
        //Binding Source


        //Repo
        private BuildingRepository buildingsRepository;
        private ApartmentRepository apartmentsRepository;
        private TenantsRepository tenantsRepository;
        private LeasingAgreementRepository leasingAgreementRepository;

        //Models List
        private IEnumerable<BuildingsModel> buildingsList;
        private IEnumerable<ApartmentModel> apartmentsList;
        private IEnumerable<TenantsModel> tenantsList;
        private IEnumerable<LeasingAgreementModel> leasingAgreementList;
        public ReportView()
        {
            InitializeComponent();
            buildingsRepository = new BuildingRepository(sqlConnectionString);
            apartmentsRepository = new ApartmentRepository(sqlConnectionString);
            tenantsRepository = new TenantsRepository(sqlConnectionString);
            leasingAgreementRepository = new LeasingAgreementRepository(sqlConnectionString);

            LoadAllData();
        }

        private void LoadAllData()
        {
            buildingsList = buildingsRepository.GetAll();
            lblBuildingsCount.Text = buildingsList.Count().ToString();
            apartmentsList= apartmentsRepository.GetAll();
            lblApartmentsCount.Text = apartmentsList.Count().ToString();
            tenantsList= tenantsRepository.GetAll();
            lblTenantsCount.Text = tenantsList.Count().ToString();

            leasingAgreementList = leasingAgreementRepository.GetAll();
            lblTotalOccupied.Text = leasingAgreementList.Count().ToString();
        }

        private void btnPrintTenantsList_Click(object sender, EventArgs e)
        {
            RptAllTenants rptAllTenants = new RptAllTenants();
            rptAllTenants.SetDataSource(tenantsList);
            new CrystalReportViewer(rptAllTenants).Show();
        }

        private void btnPrintBuildingList_Click(object sender, EventArgs e)
        {
            RptAllBuildings rpt = new RptAllBuildings();
            rpt.SetDataSource(buildingsList);
            new CrystalReportViewer(rpt).Show();
        }
         
        private void btnPrintAllApartmentsList_Click(object sender, EventArgs e)
        {
            RptAllApartments rpt = new RptAllApartments();
            rpt.SetDataSource(apartmentsList);
            new CrystalReportViewer(rpt).Show();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintOccupiedList_Click(object sender, EventArgs e)
        {
            RptAllOccupiedApartments rpt = new RptAllOccupiedApartments();
            rpt.SetDataSource(leasingAgreementList);
            new CrystalReportViewer(rpt).Show();
        }
    }
}
