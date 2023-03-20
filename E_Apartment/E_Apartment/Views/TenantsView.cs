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
    public partial class TenantsView : Form, ITenantsView, IDependentsView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private static TenantsView instance;

        public TenantsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            btnRefresh.Click += delegate {
                
                RefreshEventTenants?.Invoke(this, EventArgs.Empty); 
            };


        }

        public static TenantsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TenantsView
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

        public string SearchValue { get => txtSearchTenant.Text; set => txtSearchTenant.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccess { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        //Binding Data from view to Model
        public int TenantId { get => Convert.ToInt32(lblTenantId.Text); set => lblTenantId.Text = value.ToString(); }

        public string TenantName { get => txtTenantName.Text; set => txtTenantName.Text = value; }
        public string TenantNIC { get => txtTenantNic.Text; set => txtTenantNic.Text = value; }
        public string TenantContact { get => txtTenantContact.Text; set => txtTenantContact.Text = value; }
        public string TenantAddress { get => txtTenantAddress.Text; set => txtTenantAddress.Text = value; }
        public string TenantGender { get => comboTenantGender.Text; set => comboTenantGender.Text = value; }
        public bool TenantStatus { get => checkBoxTenantStatus.Checked; set => checkBoxTenantStatus.Checked = value; }
        public string TenantFeedback { get => txtTenantFeedback.Text; set => txtTenantFeedback.Text = value; }

        #region Dependents
        public int DependentId { get => Convert.ToInt32(lblDependentId.Text); set => lblDependentId.Text = value.ToString(); }
        public int DependentTenantId { get => Convert.ToInt32(comboChiefTenant.SelectedValue); set => comboChiefTenant.SelectedValue = value; }
        public string DependentName { get => txtDependentName.Text; set => txtDependentName.Text = value; }
        public string DependentRelationship { get => comboBoxDependentRelationShip.Text; set => comboBoxDependentRelationShip.Text = value; }
        public string DependentGender { get => comboBoxDependentGender.Text; set => comboBoxDependentGender.Text = value; }
        public bool DependentStatus { get => checkBoxDependentStatus.Checked; set => checkBoxDependentStatus.Checked = value; }
       

        #endregion

        // = valueModel Events


        public event EventHandler SearchEventTenants;
        public event EventHandler AddNewEventTenants;
        public event EventHandler DeleteEventTenants;
        public event EventHandler EditEventTenants;
        public event EventHandler CancelEventTenants;
        public event EventHandler SaveEventTenants;
        public event EventHandler UpdateEventTenants;
        public event EventHandler SearchEventDependents;
        public event EventHandler AddNewEventDependents;
        public event EventHandler DeleteEventDependents;
        public event EventHandler EditEventDependents;
        public event EventHandler CancelEventDependents;
        public event EventHandler SaveEventDependents;
        public event EventHandler UpdateEventDependents;
        public event EventHandler RefreshEventTenants;

        public void SetBindingSource(BindingSource bindingSource)
        {
            dataGridViewTenants.DataSource = bindingSource;
        }

        private void AssociateAndRaiseViewEvent()
        {
            // btnTenantsSearch.Click += delegate { SearchEventTenants?.Invoke(this, EventArgs.Empty); };
            txtSearchTenant.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                { SearchEventTenants?.Invoke(this, EventArgs.Empty); }

            };
            btnSaveTenants.Click += delegate
            {



                SaveEventTenants?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }


            };
            dataGridViewTenants.CellClick += delegate
            {




                EditEventTenants?.Invoke(this, EventArgs.Empty);

                //disable add button




            };
            btnUpdateTenants.Click += delegate
            {
                SaveEventTenants?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                    btnSaveTenants.Enabled = true;

                }

            };
            btnDeleteTenants.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Tenant ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventTenants?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearTenants.Click += delegate
            {

                CancelEventTenants?.Invoke(this, EventArgs.Empty);

            };

            //Dependents
            txtSearchDependent.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                { SearchEventDependents?.Invoke(this, EventArgs.Empty); }

            };
            btnSaveDependents.Click += delegate
            {



                SaveEventDependents?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                }


            };
            dataGridViewDependent.CellClick += delegate
            {

                EditEventDependents?.Invoke(this, EventArgs.Empty);

                //disable add button




            };
            btnUpdateDependents.Click += delegate
            {
                SaveEventDependents?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    MessageBox.Show(Message);
                    btnSaveDependents.Enabled = true;

                }

            };
            btnDeleteDependent.Click += delegate
            {

                var result = MessageBox.Show("Are you sure to delete the Dependent ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEventDependents?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            btnClearDependent.Click += delegate
            {

                CancelEventDependents?.Invoke(this, EventArgs.Empty);

            };

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void SetTenantsNamesIntoComboBox(BindingSource bindingSource)
        {
            comboChiefTenant.DataSource = bindingSource;
            comboChiefTenant.DisplayMember = "TenantName";
            comboChiefTenant.ValueMember = "TenantId";
        }

        public void SetDependentsNamesIntoComboBox(BindingSource bindingSource)
        {
            //throw new NotImplementedException();
        }

        public void SetDependentsBindingSource(BindingSource bindingSource)
        {
            dataGridViewDependent.DataSource = bindingSource;
        }

        private void txtTanentFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
