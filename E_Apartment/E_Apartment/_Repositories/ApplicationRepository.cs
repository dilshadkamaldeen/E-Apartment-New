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
    internal class ApplicationRepository : BaseRepository, IApplicationRepository
    {
        public ApplicationRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(ApplicationModel applicationModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_APPLICATION values (@applicationBuildingId, @applicationApartmentId, @applicationApartmentStatus, @applicationTenantId , @isWaitingList, @applyDate)";
                    cmd.Parameters.Add("@applicationBuildingId", SqlDbType.NVarChar).Value = applicationModel.ApplicationBuildingId;
                    cmd.Parameters.Add("@applicationApartmentId", SqlDbType.Int).Value = applicationModel.ApplicationApartmentId;
                    cmd.Parameters.Add("@applicationApartmentStatus", SqlDbType.NVarChar).Value = applicationModel.ApplicationApartmentStatus;
                    cmd.Parameters.Add("@applicationTenantId", SqlDbType.Int).Value = applicationModel.ApplicationTenantId;
                    cmd.Parameters.Add("@isWaitingList", SqlDbType.Bit).Value = applicationModel.IsWaitingList;
                    DateTime dateTime = DateTime.UtcNow.Date;
                    cmd.Parameters.Add("@applyDate", SqlDbType.DateTime).Value = dateTime;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(ApplicationModel applicationModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_APPLICATION set applicationBuildingId=@applicationBuildingId , applicationApartmentId= @applicationApartmentId, applicationApartmentStatus=@applicationApartmentStatus , isWaitingList= @isWaitingList where applicationId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = applicationModel.ApplicationId;
                    cmd.Parameters.Add("@applicationBuildingId", SqlDbType.NVarChar).Value = applicationModel.ApplicationBuildingId;
                    cmd.Parameters.Add("@applicationApartmentId", SqlDbType.Int).Value = applicationModel.ApplicationApartmentId;
                    cmd.Parameters.Add("@applicationApartmentStatus", SqlDbType.NVarChar).Value = applicationModel.ApplicationApartmentStatus;
                    cmd.Parameters.Add("@applicationTenantId", SqlDbType.Int).Value = applicationModel.ApplicationTenantId;
                    cmd.Parameters.Add("@isWaitingList", SqlDbType.Bit).Value = applicationModel.IsWaitingList;
                    //cmd.Parameters.Add("@applyDate", SqlDbType.DateTime).Value = new DateTime();
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
                    cmd.CommandText = @"delete from  TBL_APPLICATION where applicationId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<ApplicationModel> GetAll()
        {
            var parkingList = new List<ApplicationModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APPLICATION order by applicationId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var applicationModel = new ApplicationModel();
                            applicationModel.ApplicationId = (int)reader[0];
                            applicationModel.ApplicationBuildingId = (int)reader["applicationBuildingId"];
                            applicationModel.ApplicationApartmentId = (int)reader["applicationApartmentId"];
                            applicationModel.ApplicationApartmentStatus = (string)reader["applicationApartmentStatus"];
                            applicationModel.ApplicationTenantId = Convert.ToInt32(reader["applicationTenantId"]);
                            applicationModel.IsWaitingList = (bool)reader["isWaitingList"];
                            applicationModel.ApplyDate = (DateTime)reader["applyDate"];


                            parkingList.Add(applicationModel);
                        }
                    }

                }

            }
            return parkingList;
        }
        public IEnumerable<ApplicationModel> GetByValue(string value)
        {
            var parkingList = new List<ApplicationModel>();
            int applicationId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string applicationBuildingId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APPLICATION where applicationId=@id order by applicationId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = applicationId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = applicationBuildingId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var applicationModel = new ApplicationModel();
                            applicationModel.ApplicationId = (int)reader[0];
                            applicationModel.ApplicationBuildingId = (int)reader["applicationBuildingId"];
                            applicationModel.ApplicationApartmentId = (int)reader["applicationApartmentId"];
                            applicationModel.ApplicationApartmentStatus = (string)reader["applicationApartmentStatus"];
                            applicationModel.ApplicationTenantId = Convert.ToInt32(reader["applicationTenantId"]);
                            applicationModel.IsWaitingList = (bool)reader["isWaitingList"];
                            applicationModel.ApplyDate = (DateTime)reader["applyDate"];
                            parkingList.Add(applicationModel);
                        }
                    }

                }

            }
            return parkingList;
        }

        public IEnumerable<ApplicationModel> GetByTenantId(string value)
        {
            var parkingList = new List<ApplicationModel>();
            int applicationId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string applicationBuildingId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APPLICATION where applicationTenantId=@id order by applicationId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = applicationId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = applicationBuildingId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var applicationModel = new ApplicationModel();
                            applicationModel.ApplicationId = (int)reader[0];
                            applicationModel.ApplicationBuildingId = (int)reader["applicationBuildingId"];
                            applicationModel.ApplicationApartmentId = (int)reader["applicationApartmentId"];
                            applicationModel.ApplicationApartmentStatus = (string)reader["applicationApartmentStatus"];
                            applicationModel.ApplicationTenantId = Convert.ToInt32(reader["applicationTenantId"]);
                            applicationModel.IsWaitingList = (bool)reader["isWaitingList"];
                            applicationModel.ApplyDate = (DateTime)reader["applyDate"];
                            parkingList.Add(applicationModel);
                        }
                    }

                }

            }
            return parkingList;
        }


    }
}
