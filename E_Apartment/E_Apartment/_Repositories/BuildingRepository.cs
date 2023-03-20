using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartment._Repositories
{
    internal class BuildingRepository : BaseRepository, IBuildingRepository
    {
        public BuildingRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }


        public void Add(BuildingsModel buildingModel)
        {
            
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_BUILDINGS values (@buildingName, @buildingLocation, @buildingAddress)";
                    cmd.Parameters.Add("@buildingName", SqlDbType.NVarChar).Value = buildingModel.BuildingName;
                    cmd.Parameters.Add("@buildingLocation", SqlDbType.NVarChar).Value = buildingModel.BuildingLocation;
                    cmd.Parameters.Add("@buildingAddress", SqlDbType.NVarChar).Value = buildingModel.BuildingAddress;
                    cmd.ExecuteNonQuery();

                }

            }
            
        }
        public void Update(BuildingsModel buildingModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_BUILDINGS set buildingName=@buildingName , buildingLocation= @buildingLocation, buildingAddress=@buildingAddress where buildingId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = buildingModel.Id.ToString();
                    cmd.Parameters.Add("@buildingName", SqlDbType.NVarChar).Value = buildingModel.BuildingName;
                    cmd.Parameters.Add("@buildingLocation", SqlDbType.NVarChar).Value = buildingModel.BuildingLocation;
                    cmd.Parameters.Add("@buildingAddress", SqlDbType.NVarChar).Value = buildingModel.BuildingAddress;
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
                    cmd.CommandText = @"delete from  TBL_BUILDINGS where buildingId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                   
                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<BuildingsModel> GetAll()
        {
            var buildingList = new List<BuildingsModel>();
            using(var connection = new SqlConnection(connectionString))
            {
                using(var cmd =new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection= connection;
                    cmd.CommandText = @"Select * from TBL_BUILDINGS order by buildingId desc";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var buildingModel = new BuildingsModel();
                            buildingModel.Id = (int)reader[0];
                            buildingModel.BuildingName= (string)reader[1];
                            buildingModel.BuildingLocation= (string)reader[2];
                            buildingModel.BuildingAddress= (string)reader[3];
                            buildingList.Add(buildingModel);
                        }
                    }

                }

            }
            return buildingList;
        }
        public IEnumerable<BuildingsModel> GetByValue(string value)
        {
            var buildingList = new List<BuildingsModel>();
            int buildingId = int.TryParse(value, out _)? Convert.ToInt32(value) : 0;
            string buildingName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_BUILDINGS where buildingId=@id or buildingName like @name +'%' order by buildingId desc";
                    cmd.Parameters.Add("@id",SqlDbType.Int).Value = buildingId;
                    cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = buildingName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var buildingModel = new BuildingsModel();
                            buildingModel.Id = (int)reader[0];
                            buildingModel.BuildingName = (string)reader[1];
                            buildingModel.BuildingLocation = (string)reader[2];
                            buildingModel.BuildingAddress = (string)reader[3];
                            buildingList.Add(buildingModel);
                        }
                    }

                }

            }
            return buildingList;
        }

        public void insert(BuildingsModel buildingModel)
        {
            throw new NotImplementedException();
        }
    }
}
