using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace E_Apartment._Repositories
{
    internal class ParkingSpaceRepository : BaseRepository, IParkingSpaceRepository
    {
        public ParkingSpaceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(ParkingSpaceModel parkingSpaceModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_PARKING_SPACE values (@parkingName, @parkingSize, @parkingType, @isReserved , @parkingStatus)";
                    cmd.Parameters.Add("@parkingName", SqlDbType.NVarChar).Value = parkingSpaceModel.ParkingName;
                    cmd.Parameters.Add("@parkingSize", SqlDbType.Int).Value = parkingSpaceModel.ParkingSize;
                    cmd.Parameters.Add("@parkingType", SqlDbType.NVarChar).Value = parkingSpaceModel.ParkingType;
                    cmd.Parameters.Add("@isReserved", SqlDbType.Bit).Value = false;
                    cmd.Parameters.Add("@parkingStatus", SqlDbType.Bit).Value = true;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(ParkingSpaceModel parkingSpaceModel)
        { 
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_PARKING_SPACE set parkingName=@parkingName , parkingSize= @parkingSize, parkingType=@parkingType , parkingStatus= @parkingStatus where parkingId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = parkingSpaceModel.ParkingId;
                    cmd.Parameters.Add("@parkingName", SqlDbType.NVarChar).Value = parkingSpaceModel.ParkingName;
                    cmd.Parameters.Add("@parkingSize", SqlDbType.Int).Value = parkingSpaceModel.ParkingSize;
                    cmd.Parameters.Add("@parkingType", SqlDbType.NVarChar).Value = parkingSpaceModel.ParkingType;
                    cmd.Parameters.Add("@parkingStatus", SqlDbType.Bit).Value = parkingSpaceModel.ParkingStatus;

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
                    cmd.CommandText = @"delete from  TBL_PARKING_SPACE where parkingId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<ParkingSpaceModel> GetAll()
        {
            var parkingList = new List<ParkingSpaceModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_PARKING_SPACE order by parkingId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var parkingSpaceModel = new ParkingSpaceModel();
                            parkingSpaceModel.ParkingId = (int)reader[0];
                            parkingSpaceModel.ParkingName = (string)reader[1];
                            parkingSpaceModel.ParkingSize = (int)reader[2];
                            parkingSpaceModel.ParkingType = (string)reader[3];
                            parkingSpaceModel.IsReserved = Convert.ToBoolean(reader["isReserved"]);
                            parkingSpaceModel.ParkingStatus = (bool)reader["parkingStatus"];
                            parkingList.Add(parkingSpaceModel);
                        }
                    }

                }

            }
            return parkingList;
        }
        public IEnumerable<ParkingSpaceModel> GetByValue(string value)
        {
            var parkingList = new List<ParkingSpaceModel>();
            int parkingId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string parkingName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_PARKING_SPACE where parkingId=@id or parkingName like @name +'%' order by parkingId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = parkingId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = parkingName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var parkingSpaceModel = new ParkingSpaceModel();
                            parkingSpaceModel.ParkingId = (int)reader[0];
                            parkingSpaceModel.ParkingName = (string)reader[1];
                            parkingSpaceModel.ParkingSize = (int)reader[2];
                            parkingSpaceModel.ParkingType = (string)reader[3];
                            parkingSpaceModel.IsReserved = Convert.ToBoolean(reader["isReserved"]);
                            parkingSpaceModel.ParkingStatus = (bool)reader["parkingStatus"];
                            parkingList.Add(parkingSpaceModel);
                        }
                    }

                }

            }
            return parkingList;
        }

        public void AddParkingReservation(ParkingSpaceDetailModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_PARKING_SPACE_DETAILS values (@parkingSpaceId, @leaseAgreementId, @reservedDate, @parkingSpaceDetailStatus)";
                    cmd.Parameters.Add("@parkingSpaceId", SqlDbType.Int).Value = model.ParkingSpaceId;
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = model.LeaseAgreementId;
                    cmd.Parameters.Add("@reservedDate", SqlDbType.DateTime).Value = model.ReservedDate;
                    cmd.Parameters.Add("@parkingSpaceDetailStatus", SqlDbType.Bit).Value = true;
                    cmd.ExecuteNonQuery();

                }

            }

        }

        public void UpdateParkingReservation(ParkingSpaceDetailModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_PARKING_SPACE_DETAILS set parkingSpaceId=@parkingSpaceId , leaseAgreementId= @leaseAgreementId, reservedDate=@reservedDate , 
                                                parkingSpaceDetailStatus= @parkingSpaceDetailStatus where parkingSpaceId=@id";
                    
                    cmd.Parameters.Add("@parkingSpaceId", SqlDbType.Int).Value = model.ParkingSpaceId;
                    cmd.Parameters.Add("@leaseAgreementId", SqlDbType.Int).Value = model.LeaseAgreementId;
                    cmd.Parameters.Add("@reservedDate", SqlDbType.DateTime).Value = model.ReservedDate;
                    cmd.Parameters.Add("@parkingSpaceDetailStatus", SqlDbType.Bit).Value = model.ParkingSpaceDetailStatus;

                    cmd.ExecuteNonQuery();

                }

            }

        }

        public IEnumerable<ParkingSpaceDetailModel> GetAllParkingSpaceDetails()
        {
            var parkingList = new List<ParkingSpaceDetailModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_PARKING_SPACE_DETAILS order by parkingSpaceId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var parkingSpaceModel = new ParkingSpaceDetailModel();
                            parkingSpaceModel.ParkingSpaceId = (int)reader["parkingSpaceId"];
                            parkingSpaceModel.LeaseAgreementId = (int)reader["leaseAgreementId"];
                            parkingSpaceModel.ReservedDate = (DateTime)reader["reservedDate"];
                            parkingSpaceModel.ParkingSpaceDetailStatus = (bool)reader["parkingSpaceDetailStatus"];
                           
                           
                            parkingList.Add(parkingSpaceModel);
                        }
                    }

                }

            }
            return parkingList;
        }
    }
}
