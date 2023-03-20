using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment._Repositories
{
    internal class LeaseExtensionRepository : BaseRepository, ILeaseExtensionRepository
    {
        public LeaseExtensionRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(LeaseExtensionModel leaseExModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_LEASE_EXTENSION
                                             values (@leaseAgreementId,
                                                    @TenantId,
                                                    @extensionMonths,
                                                    @extensionStatus,
                                                    @reservationId,
                                                    @isDuePayment,
                                                    @leaseAgreementId ) 
                  ";
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = leaseExModel.LeaseAgreementId;
                    cmd.Parameters.Add("@TenantId", SqlDbType.Int).Value = leaseExModel.TenantId;
                    cmd.Parameters.Add("@extensionMonths", SqlDbType.Int).Value = leaseExModel.ExtensionMonths;
                    cmd.Parameters.Add("@extensionStatus", SqlDbType.NVarChar).Value = leaseExModel.ExtensionStatus;

                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(LeaseExtensionModel leaseExModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_LEASE_EXTENSION
                                        set    leaseAgreementId = @leaseAgreementId,
                                               TenantId = @TenantId,
                                               extensionMonths = @extensionMonths,
                                               extensionStatus = @extensionStatus,  
                                               leaseAgreementId = @leaseAgreementId
                                        where  leaseExtensionId = @id 
";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseExModel.LeaseExtensionId.ToString();
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = leaseExModel.LeaseAgreementId;
                    cmd.Parameters.Add("@TenantId", SqlDbType.Int).Value = leaseExModel.TenantId;
                    cmd.Parameters.Add("@extensionMonths", SqlDbType.Int).Value = leaseExModel.ExtensionMonths;
                    cmd.Parameters.Add("@extensionStatus", SqlDbType.NVarChar).Value = leaseExModel.ExtensionStatus;
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
                    cmd.CommandText = @"delete from  TBL_LEASE_EXTENSION where leaseExtensionId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<LeaseExtensionModel> GetAll()
        {
            var paymentList = new List<LeaseExtensionModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_EXTENSION order by leaseExtensionId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leaseExModel = new LeaseExtensionModel();
                            leaseExModel.LeaseExtensionId = (int)reader[0];
                            leaseExModel.LeaseAgreementId = (int)reader["leaseAgreementId"];
                            leaseExModel.TenantId = (int)reader["TenantId"];
                            leaseExModel.ExtensionMonths = (int)reader["extensionMonths"];
                            leaseExModel.ExtensionStatus = (string)reader["extensionStatus"];


                            paymentList.Add(leaseExModel);
                        }
                    }

                }

            }
            return paymentList;
        }
        public IEnumerable<LeaseExtensionModel> GetByValue(string value)
        {
            var paymentList = new List<LeaseExtensionModel>();
            int leaseExtensionId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string leaseAgreementId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_EXTENSION where leaseExtensionId=@id   order by leaseExtensionId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseExtensionId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = leaseAgreementId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leaseExModel = new LeaseExtensionModel();
                            leaseExModel.LeaseExtensionId = (int)reader[0];
                            leaseExModel.LeaseAgreementId = (int)reader["leaseAgreementId"];
                            leaseExModel.TenantId = (int)reader["TenantId"];
                            leaseExModel.ExtensionMonths = (int)reader["extensionMonths"];
                            leaseExModel.ExtensionStatus = (string)reader["extensionStatus"];

                            paymentList.Add(leaseExModel);
                        }
                    }

                }

            }
            return paymentList;
        }
        public IEnumerable<LeaseExtensionModel> GetByTenantId(string value)
        {
            var paymentList = new List<LeaseExtensionModel>();
            int leaseExtensionId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string leaseAgreementId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_EXTENSION where TenantId=@id   order by leaseExtensionId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseExtensionId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = leaseAgreementId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leaseExModel = new LeaseExtensionModel();
                            leaseExModel.LeaseExtensionId = (int)reader[0];
                            leaseExModel.LeaseAgreementId = (int)reader["leaseAgreementId"];
                            leaseExModel.TenantId = (int)reader["TenantId"];
                            leaseExModel.ExtensionMonths = (int)reader["extensionMonths"];
                            leaseExModel.ExtensionStatus = (string)reader["extensionStatus"];

                            paymentList.Add(leaseExModel);
                        }
                    }

                }

            }
            return paymentList;
        }
        public IEnumerable<LeaseExtensionModel> GetOnlyRequested()
        {
            var paymentList = new List<LeaseExtensionModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_EXTENSION where extensionStatus='Request'  order by leaseExtensionId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leaseExModel = new LeaseExtensionModel();
                            leaseExModel.LeaseExtensionId = (int)reader[0];
                            leaseExModel.LeaseAgreementId = (int)reader["leaseAgreementId"];
                            leaseExModel.TenantId = (int)reader["TenantId"];
                            leaseExModel.ExtensionMonths = (int)reader["extensionMonths"];
                            leaseExModel.ExtensionStatus = (string)reader["extensionStatus"];


                            paymentList.Add(leaseExModel);
                        }
                    }

                }

            }
            return paymentList;
        }
        public void UpdateStatus(LeaseExtensionModel leaseExModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_LEASE_EXTENSION
                                        set     
                                               extensionStatus = @extensionStatus 
                                        where  leaseExtensionId = @id 
";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseExModel.LeaseExtensionId.ToString();
                    cmd.Parameters.Add("@extensionStatus", SqlDbType.NVarChar).Value = leaseExModel.ExtensionStatus;
                    cmd.ExecuteNonQuery();

                }

            }
        }


    }
}
