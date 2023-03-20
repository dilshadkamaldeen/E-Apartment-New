using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartment._Repositories.Interfaces;

namespace E_Apartment._Repositories
{
    internal class PaymentRepository : BaseRepository, IPaymentRepository
    {
        public PaymentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PaymentModel paymentModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_PAYMENTS
                                             values (@paymentType,
                                                    @paidAmount,
                                                    @paidDate,
                                                    @isReservationFeePayment,
                                                    @reservationId,
                                                    @isDuePayment,
                                                    @leaseAgreementId ) 
                  ";
                  cmd.Parameters.Add("@paymentType", SqlDbType.NVarChar).Value = paymentModel.PaymentType;
                    cmd.Parameters.Add("@paidAmount", SqlDbType.Decimal).Value = paymentModel.PaidAmount;
                    cmd.Parameters.Add("@paidDate", SqlDbType.DateTime).Value = paymentModel.PaidDate;
                    cmd.Parameters.Add("@isReservationFeePayment", SqlDbType.Bit).Value = paymentModel.IsReservationFeePayment;
                    cmd.Parameters.Add("@reservationId", SqlDbType.Int).Value = paymentModel.ReservationId;
                    cmd.Parameters.Add("@isDuePayment", SqlDbType.Bit).Value = paymentModel.IsDuePayment;
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = paymentModel.LeaseAgreementId;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(PaymentModel paymentModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_PAYMENTS
                                        set    paymentType = @paymentType,
                                               paidAmount = @paidAmount,
                                               paidDate = @paidDate,
                                               isReservationFeePayment = @isReservationFeePayment,
                                               reservationId = @reservationId,
                                               isDuePayment = @isDuePayment,
                                               leaseAgreementId = @leaseAgreementId
                                        where  paymentId = @id 
";
                  cmd.Parameters.Add("@id", SqlDbType.Int).Value = paymentModel.PaymentId.ToString();
                    cmd.Parameters.Add("@paymentType", SqlDbType.NVarChar).Value = paymentModel.PaymentType;
                    cmd.Parameters.Add("@paidAmount", SqlDbType.Decimal).Value = paymentModel.PaidAmount;
                    cmd.Parameters.Add("@paidDate", SqlDbType.DateTime).Value = paymentModel.PaidDate;
                    cmd.Parameters.Add("@isReservationFeePayment", SqlDbType.Bit).Value = paymentModel.IsReservationFeePayment;
                    cmd.Parameters.Add("@reservationId", SqlDbType.Int).Value = paymentModel.ReservationId;
                    cmd.Parameters.Add("@isDuePayment", SqlDbType.Bit).Value = paymentModel.IsDuePayment;
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = paymentModel.LeaseAgreementId;
                    cmd.ExecuteNonQuery();

                }

            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"delete from  TBL_PAYMENTS where paymentId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<PaymentModel> GetAll()
        {
            var paymentList = new List<PaymentModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_PAYMENTS order by paymentId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var paymentModel = new PaymentModel();
                            paymentModel.PaymentId = (int)reader[0];
                            paymentModel.PaymentType = (string)reader["paymentType"];
                            paymentModel.PaidAmount = (decimal)reader["paidAmount"];
                            paymentModel.PaidDate = (DateTime)reader["paidDate"];
                            paymentModel.IsReservationFeePayment = (bool)reader["isReservationFeePayment"];
                            paymentModel.ReservationId = (int)reader["reservationId"];
                            paymentModel.IsDuePayment = (bool)reader["isDuePayment"];
                            paymentModel.LeaseAgreementId = (int)reader["leaseAgreementId"];

                            paymentList.Add(paymentModel);
                        }
                    }

                }

            }
            return paymentList;
        }
        public IEnumerable<PaymentModel> GetByValue(string value)
        {
            var paymentList = new List<PaymentModel>();
            int paymentId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string paymentType = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_PAYMENTS where paymentId=@id   order by paymentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = paymentId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = paymentType;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var paymentModel = new PaymentModel();
                            paymentModel.PaymentId = (int)reader[0];
                            paymentModel.PaymentType = (string)reader["paymentType"];
                            paymentModel.PaidAmount = (int)reader["paidAmount"];
                            paymentModel.PaidDate = (DateTime)reader["paidDate"];
                            paymentModel.IsReservationFeePayment = (bool)reader["isReservationFeePayment"];
                            paymentModel.ReservationId = (int)reader["reservationId"];
                            paymentModel.IsDuePayment = (bool)reader["isDuePayment"];
                            paymentModel.LeaseAgreementId = (int)reader["leaseAgreementId"];

                            paymentList.Add(paymentModel);
                        }
                    }

                }

            }
            return paymentList;
        }

    }
}