using E_Apartment._Repositories;
using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
using E_Apartment.Views.interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace E_Apartment.Presenter
{
    internal class PaymentPresenter
    {
        private IPaymentView view;
        private IPaymentRepository repository;
        private BindingSource paymentBindingSource;
        private IEnumerable<PaymentModel> paymentList;


        public PaymentPresenter(IPaymentView view, IPaymentRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.paymentBindingSource = new BindingSource();
        


            //Subscribe event handler
            this.view.SearchEventPayment += SearchPayment;
            this.view.EditEventPayment += UpdatePayment;
            this.view.AddNewEventPayment += AddPayment;
            this.view.SaveEventPayment += SavePayment;
            this.view.DeleteEventPayment += DeletePayment;
            this.view.CancelEventPayment += ClearAllPayment;





            //Set  source //LoadAll 
            LoadAll();

            this.view.SetPaymentListBindingSource(paymentBindingSource);

            //Show view
            this.view.Show();
        }


        private void ClearAllPayment(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Methods
        private void LoadAll()
        {
            paymentList = repository.GetAll();
            paymentBindingSource.DataSource = paymentList; //set data source

        }

        private void SearchPayment(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue) { paymentList = repository.GetByValue(this.view.SearchValue); }
            else { paymentList = repository.GetAll(); }

            paymentBindingSource.DataSource = paymentList;
        }

        private void DeletePayment(object sender, EventArgs e)
        {
            try
            {
                var paymentModel = (PaymentModel)paymentBindingSource.Current;
                repository.Delete(paymentModel.PaymentId);
                view.IsSuccess = true;
                view.Message = "Delete successfully";
                //Load all again
                LoadAll();
                view.Show();
            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
            }
        }

        private void SavePayment(object sender, EventArgs e)
        {
            //create paymentModel model instance
            var model = new PaymentModel();

            //pass data View --> to --> model           

            model.PaymentId = view.PaymentId;
            model.PaymentType = view.PaymentType;
            model.PaidAmount = view.PaidAmount;
            model.PaidDate = view.PaidDate;
            model.IsReservationFeePayment = view.IsReservationFeePayment;
            model.ReservationId = view.ReservationId;
            model.IsDuePayment = view.IsDuePayment;
            model.LeaseAgreementId = view.LeaseAgreementId;

            try
            {
                //Save
                //Validate the paymentModelModel
                new Utility.ModelValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Update(model);
                    view.Message = "Payment Edited Successfully";
                    view.IsEdit = false;
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Payment Added Successfully";
                }

                view.IsSuccess = true;
                LoadAll();
                CleanViewFields();
                // this.view.SetPaymentNamesIntoComboBox(paymentBindingSource);


            }
            catch (Exception ex)
            {
                view.IsSuccess = false;
                view.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanViewFields()
        {
            view.PaymentId = 0;
            view.PaymentType = "";
            view.PaidAmount = 0;
            view.PaidDate = DateTime.UtcNow;
            view.IsReservationFeePayment = false;
            view.ReservationId = 0;
            view.IsDuePayment = false;
            view.LeaseAgreementId = 0;


            view.IsEdit = false;
        }

        private void AddPayment(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }

        private void UpdatePayment(object sender, EventArgs e)
        {
            var paymentModel = (PaymentModel)paymentBindingSource.Current;


            view.PaymentId = (int)paymentModel.PaymentId;
            view.PaymentType = (string)paymentModel.PaymentType;
            view.PaidAmount = (int)paymentModel.PaidAmount;
            view.PaidDate = (DateTime)paymentModel.PaidDate;
            view.IsReservationFeePayment = (bool)paymentModel.IsReservationFeePayment;
            view.ReservationId = (int)paymentModel.ReservationId;
            view.IsDuePayment = (bool)paymentModel.IsDuePayment;
            view.LeaseAgreementId = (int)paymentModel.LeaseAgreementId;


            view.IsEdit = true;

        }

    }
}