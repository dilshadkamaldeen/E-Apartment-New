using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment._Repositories
{
    internal class ApartmentClassRepository : BaseRepository, IApartmentClassRepository
    {
        

        public ApartmentClassRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ApartmentClassModel apartmentClassModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_APPARTMENT_CLASS (className, isBedroomAvailable, bedroomCount,
                                        isCommonBathroomAvailable, commonBathroomCount, isAttachBathroomAvailalbe, attachBathroomCount,isServantsRoomAvailable,servantRoomCount,
                                        isServantToiletAvailable, servantToiletCount, status)  values (@className, @isBedroomAvailable, @bedroomCount,
                                        @isCommonBathroomAvailable, @commonBathroomCount, @isAttachBathroomAvailalbe, @attachBathroomCount,@isServantsRoomAvailable,@servantRoomCount,
                                        @isServantToiletAvailable, @servantToiletCount, @status)";

                    cmd.Parameters.Add("@className", SqlDbType.NVarChar).Value = apartmentClassModel.ClassName;
                    cmd.Parameters.Add("@isBedroomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsBedroomAvailable;
                    cmd.Parameters.Add("@bedroomCount", SqlDbType.Int).Value = apartmentClassModel.BedroomCount;
                    cmd.Parameters.Add("@isCommonBathroomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsCommonBathroomAvailable;
                    cmd.Parameters.Add("@commonBathroomCount", SqlDbType.Int).Value = apartmentClassModel.CommonBathroomCount;
                    cmd.Parameters.Add("@isAttachBathroomAvailalbe", SqlDbType.Bit).Value = apartmentClassModel.IsAttachBathroomAvailalbe;
                    cmd.Parameters.Add("@attachBathroomCount", SqlDbType.Int).Value = apartmentClassModel.AttachBathroomCount;
                    cmd.Parameters.Add("@isServantsRoomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsServantsRoomAvailable;
                    cmd.Parameters.Add("@servantRoomCount", SqlDbType.Int).Value = apartmentClassModel.ServantsRoomCount;
                    cmd.Parameters.Add("@isServantToiletAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsServantToiletAvailable;
                    cmd.Parameters.Add("@servantToiletCount", SqlDbType.Int).Value = apartmentClassModel.ServantToiletCount;
                    cmd.Parameters.Add("@status", SqlDbType.Bit).Value = apartmentClassModel.Status;


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
                    cmd.CommandText = @"delete from  TBL_APPARTMENT_CLASS where classNameId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }

        public IEnumerable<ApartmentClassModel> GetAll()
        {
            var apartmentClass = new List<ApartmentClassModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APPARTMENT_CLASS order by classNameId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var apartmentClassModel = new ApartmentClassModel
                            {
                                ClassNameId = (int)reader[0],
                                ClassName = reader["className"].ToString(),
                                IsBedroomAvailable = Convert.ToBoolean(reader["isBedroomAvailable"]),
                                BedroomCount = Convert.ToInt32(reader["bedroomCount"].ToString()),
                                IsCommonBathroomAvailable = Convert.ToBoolean(reader["isCommonBathroomAvailable"]),
                                CommonBathroomCount = (int)reader["commonBathroomCount"],
                                IsAttachBathroomAvailalbe = Convert.ToBoolean(reader["isAttachBathroomAvailalbe"]),
                                AttachBathroomCount = (int)reader["attachBathroomCount"],
                                IsServantsRoomAvailable = Convert.ToBoolean(reader["isServantsRoomAvailable"]),
                                ServantsRoomCount = (int)reader["servantRoomCount"],
                                IsServantToiletAvailable = Convert.ToBoolean(reader["isServantToiletAvailable"]),
                                ServantToiletCount = (int)reader["servantToiletCount"],
                                Status = Convert.ToBoolean(reader["status"])
                            };

                            apartmentClass.Add(apartmentClassModel);
                        }
                    }

                }

            }
            return apartmentClass;
        }

        public IEnumerable<ApartmentClassModel> GetByValue(string value)
        {
            var apartmentClass = new List<ApartmentClassModel>();
            int apartmentClassId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string apartmentClassName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APPARTMENT_CLASS where classNameId=@id or className like @name +'%' order by classNameId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = apartmentClassId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = apartmentClassName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var apartmentClassModel = new ApartmentClassModel();

                            apartmentClassModel.ClassNameId = (int)reader[0];
                            apartmentClassModel.ClassName = reader[1].ToString();
                            apartmentClassModel.IsBedroomAvailable = (bool)reader[1];
                            apartmentClassModel.BedroomCount = (int)reader[1];
                            apartmentClassModel.IsCommonBathroomAvailable = (bool)reader[1];
                            apartmentClassModel.CommonBathroomCount = (int)reader[1];
                            apartmentClassModel.IsAttachBathroomAvailalbe = (bool)reader[1];
                            apartmentClassModel.AttachBathroomCount = (int)reader[1];
                            apartmentClassModel.IsServantsRoomAvailable = (bool)reader[1];
                            apartmentClassModel.ServantsRoomCount = (int)reader[1];
                            apartmentClassModel.IsServantToiletAvailable = (bool)reader[1];
                            apartmentClassModel.ServantToiletCount = (int)reader[1];
                            apartmentClassModel.Status = (bool)reader[1];

                            apartmentClass.Add(apartmentClassModel);
                        }
                    }

                }

            }
            return apartmentClass;
        }

        public void Update(ApartmentClassModel apartmentClassModel)
        {
             

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_APPARTMENT_CLASS set className=@className, isBedroomAvailable=@isBedroomAvailable, bedroomCount=@bedroomCount,
                                       isCommonBathroomAvailable= @isCommonBathroomAvailable, commonBathroomCount=@commonBathroomCount, isAttachBathroomAvailalbe=@isAttachBathroomAvailalbe, 
                                       attachBathroomCount= @attachBathroomCount,isServantsRoomAvailable=@isServantsRoomAvailable,servantRoomCount=@servantRoomCount,
                                        isServantToiletAvailable=@isServantToiletAvailable,servantToiletCount= @servantToiletCount, status=@status 
                                        where classNameId=@id";

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = apartmentClassModel.ClassNameId;
                    cmd.Parameters.Add("@className", SqlDbType.NVarChar).Value = apartmentClassModel.ClassName;
                    cmd.Parameters.Add("@isBedroomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsBedroomAvailable;
                    cmd.Parameters.Add("@bedroomCount", SqlDbType.Int).Value = apartmentClassModel.BedroomCount;
                    cmd.Parameters.Add("@isCommonBathroomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsCommonBathroomAvailable;
                    cmd.Parameters.Add("@commonBathroomCount", SqlDbType.Int).Value = apartmentClassModel.CommonBathroomCount;
                    cmd.Parameters.Add("@isAttachBathroomAvailalbe", SqlDbType.Bit).Value = apartmentClassModel.IsAttachBathroomAvailalbe;
                    cmd.Parameters.Add("@attachBathroomCount", SqlDbType.Int).Value = apartmentClassModel.AttachBathroomCount;
                    cmd.Parameters.Add("@isServantsRoomAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsServantsRoomAvailable;
                    cmd.Parameters.Add("@servantRoomCount", SqlDbType.Int).Value = apartmentClassModel.ServantsRoomCount;
                    cmd.Parameters.Add("@isServantToiletAvailable", SqlDbType.Bit).Value = apartmentClassModel.IsServantToiletAvailable;
                    cmd.Parameters.Add("@servantToiletCount", SqlDbType.Int).Value = apartmentClassModel.ServantToiletCount;
                    cmd.Parameters.Add("@status", SqlDbType.Bit).Value = apartmentClassModel.Status;


                    cmd.ExecuteNonQuery();

                }

            }
        }
    }
}
