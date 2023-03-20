using E_Apartment._Repositories;
using E_Apartment.Models;
using E_Apartment.Presenter;
using E_Apartment.Views.interfaces;
using E_Apartment.Views;
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
    public partial class Login : Form, ILoginView
    {
        private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["E_Apartment.Properties.Settings.SqlConnection"].ConnectionString;
        private IEnumerable<UserModel> usersList;
        private BindingSource bindingSource;
        private UserRepository repository;
        private bool IsSuccess;
        private bool IsEdit;
        private string Message;
        private string customerId;

        public string UserName { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string CustomerId { get => customerId; set => customerId = value; }

        public event EventHandler ShowMainView;

        public Login()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            repository = new UserRepository(sqlConnectionString);

            btnLogin.Click += delegate
            {
                var msg = string.Format("Welcome {0}", UserName);
                LoginUser();
                MessageBox.Show(msg);
                if (comboUserType.Text == "Admin")
                {
                    ShowMainView?.Invoke(this, EventArgs.Empty);

                    this.Dispose();

                }
                else if (comboUserType.Text == "Customer")
                {
                    var cus = new CustomerPortal(UserName, CustomerId);
                    cus.Show();
                }
                else
                {
                    var manager = new ManagerPortal(UserName);
                    manager.Show();
                }
               // this.Hide();

            };
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUser()
        {
            //create paymentModel model instance
            var model = new UserModel();

            //pass data View --> to --> model           

            model.UserName = txtUserName.Text;
            model.UserPassword = txtPassword.Text;
            model.UserType = comboUserType.Text;


            try
            {
                //Save
                //Validate the paymentModelModel
                new Utility.ModelValidator().Validate(model);

                usersList = repository.Login(model.UserName, model.UserPassword);

                if (usersList.Count() > 0)
                {
                    this.Message = "Login Successfully";

                    this.IsSuccess = true;

                    foreach (var i in usersList)
                    {
                        CustomerId = i.CustomerId.ToString();
                    }
                }
                else
                {
                    this.Message = "Login Failed, Please Re-Check your credential";

                    this.IsSuccess = false;
                }


                // SetUserNamesIntoComboBox(bindingSource);


            }
            catch (Exception ex)
            {
                this.IsSuccess = false;
                this.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }


    }
}
