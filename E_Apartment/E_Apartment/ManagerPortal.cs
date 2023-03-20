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
using System.Web.Hosting;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace E_Apartment
{
    public partial class ManagerPortal : Form
    {
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
        private IEnumerable<LeaseExtensionModel> leaseExtensionList;
        private LeaseExtensionRepository leaseExtensionRepository;
        private BindingSource bindingSource;
        public ManagerPortal(string username)
        {
            InitializeComponent();
            lblUserName.Text = username;
            leaseExtensionRepository = new LeaseExtensionRepository(sqlConnectionString);
            bindingSource = new BindingSource();
            LoadGrid();
        }

        private void LoadGrid()
        {
            leaseExtensionList = leaseExtensionRepository.GetOnlyRequested();
            dataGridViewExtension.DataSource = bindingSource.DataSource = leaseExtensionList;

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Update("Approve", Convert.ToInt32(lblId.Text));

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Update("Reject", Convert.ToInt32(lblId.Text));
        }

        void Update(string status, int id)
        {
            var msg = string.Format("Are you sure to {0} the Request", status);
            var result = MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var message = "";
            if (result == DialogResult.Yes)
            {
                var model = new LeaseExtensionModel();

                model.ExtensionStatus = status;
                model.LeaseExtensionId = id; 
                try
                {
                    new Utility.ModelValidator().Validate(model);
                    leaseExtensionRepository.UpdateStatus(model);
                    message = "Extension Status Update Successfully";

                }
                catch (Exception ex)
                { 
                    message = ex.Message;
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show(message); 
            }
        }

        private void dataGridViewExtension_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var leaseModel = (LeaseExtensionModel)bindingSource.Current;
            lblId.Text = leaseModel.LeaseExtensionId.ToString();
        }
    }
}
