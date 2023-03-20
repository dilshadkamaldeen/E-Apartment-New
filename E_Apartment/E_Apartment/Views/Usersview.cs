using E_Apartment._Repositories;
using E_Apartment.Models;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace E_Apartment.Views
{
    public partial class Usersview : Form,IUserView
    {
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
        private IEnumerable<UserModel> usersList;
        private BindingSource bindingSource;
        private UserRepository repository;
        private bool IsSuccess;
        private bool IsEdit;
        private string Message;

        public event EventHandler userRefresh;

        public Usersview()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            repository = new UserRepository(sqlConnectionString);
            LoadAll();
            btnRefresh.Click += delegate {

                txtUserName.Text = string.Empty;
                
            };
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            var user = new UserModel
            {
                UserName = txtUserName.Text,
                UserStatus = checkBoxUserStatus.Checked,
                UserType = comboUserRole.Text,
                UserPassword = txtUserPassword.Text,
                CustomerId = comboUserRole.Text == "Customer" ? Convert.ToInt32(txtTenantId.Text) : 0
            };
            SaveUser(user);
            if (IsSuccess) MessageBox.Show(Message);
            LoadAll();

        }

        private void LoadAll()
        {
            usersList = repository.GetAll();
            bindingSource.DataSource = usersList; //set data source
            dataGridViewUsers.DataSource = bindingSource;
        }

        private void SearchUser(string SearchValue)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(SearchValue);
            if (!emptyValue) { usersList = repository.GetByValue(SearchValue); }
            else { usersList = repository.GetAll(); }

            bindingSource.DataSource = usersList;
        }

        private void DeleteUser(int id)
        {
            try
            {

                repository.Delete(id);
                this.IsSuccess = true;
                this.Message = "Delete successfully";
                //Load all again
                LoadAll();

            }
            catch (Exception ex)
            {
                this.IsSuccess = false;
                this.Message = ex.Message;
            }
        }

        private void SaveUser(UserModel userModel)
        {
            //create paymentModel model instance
            var model = new UserModel();

            //pass data View --> to --> model           

            model.UserId = userModel.UserId;
            model.UserName = userModel.UserName;
            model.UserPassword = userModel.UserPassword;
            model.UserType = userModel.UserType;
            model.UserStatus = userModel.UserStatus;

            try
            {
                //Save
                //Validate the paymentModelModel
                new Utility.ModelValidator().Validate(model);
                if (this.IsEdit)
                {
                    repository.Update(model);
                    this.Message = "User Edited Successfully";
                    this.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    this.Message = "User Added Successfully";
                }

                this.IsSuccess = true;
                LoadAll();
                CleanViewFields();
                // SetUserNamesIntoComboBox(bindingSource);


            }
            catch (Exception ex)
            {
                this.IsSuccess = false;
                this.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanViewFields()
        {

            txtUserName.Text = string.Empty;
            this.IsEdit = false;
        }

        private void AddUser(object sender, EventArgs e)
        {
            this.IsEdit = false;

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var userModel = (UserModel)bindingSource.Current;
            lblUserId.Text = userModel.UserId.ToString();
            txtUserName.Text = userModel.UserName;
            txtUserPassword.Text = userModel.UserPassword;
            comboUserRole.Text = userModel.UserType;
            txtTenantId.Text = userModel.CustomerId.ToString();
            checkBoxUserStatus.Checked = userModel.UserStatus;
            txtTenantId.Enabled = userModel.UserType == "Customer" ? true : false;

            IsEdit = true;
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            var user = new UserModel
            {
                UserId = Convert.ToInt32(lblUserId.Text),
                UserName = txtUserName.Text,
                UserStatus = checkBoxUserStatus.Checked,
                UserType = comboUserRole.Text,
                UserPassword = txtUserPassword.Text,
                CustomerId = comboUserRole.Text == "Customer" ? Convert.ToInt32(txtTenantId.Text) : 0

            };
            SaveUser(user);
            if (IsSuccess) MessageBox.Show(Message);
            LoadAll();
        }

        private void comboUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenantId.Enabled = comboUserRole.Text == "Customer" ? true : false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
