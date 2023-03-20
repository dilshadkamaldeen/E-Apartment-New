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
    

    internal class DependentsRepository : BaseRepository, IDependentsRepository
    {
        public DependentsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(DependentsModel dependentsModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_DEPENDENT 
                                                (tenantId ,dependentName ,dependentRelationship ,dependentGender ,dependentStatus) 
                                        values (@tanentId,@dependentName, @dependentRelationship, @dependentGender ,  @dependentStatus)";
                    cmd.Parameters.Add("@tanentId", SqlDbType.Int).Value = dependentsModel.TenantId;
                    cmd.Parameters.Add("@dependentName", SqlDbType.NVarChar).Value = dependentsModel.DependentName;
                    cmd.Parameters.Add("@dependentRelationship", SqlDbType.NVarChar).Value = dependentsModel.DependentRelationship; ;
                    cmd.Parameters.Add("@dependentGender", SqlDbType.NVarChar).Value = dependentsModel.DependentGender;                    
                    cmd.Parameters.Add("@dependentStatus", SqlDbType.Bit).Value = true;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(DependentsModel dependentsModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_DEPENDENT set tenantId=@tenantId, dependentName=@dependentName , dependentRelationship= @dependentRelationship, dependentGender=@dependentGender where dependentId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = dependentsModel.DependentId;
                    cmd.Parameters.Add("@tenantId", SqlDbType.Int).Value = dependentsModel.TenantId;
                    cmd.Parameters.Add("@dependentName", SqlDbType.NVarChar).Value = dependentsModel.DependentName;
                    cmd.Parameters.Add("@dependentRelationship", SqlDbType.NVarChar).Value = dependentsModel.DependentRelationship; ;
                    cmd.Parameters.Add("@dependentGender", SqlDbType.NVarChar).Value = dependentsModel.DependentGender;
                    cmd.Parameters.Add("@dependentStatus", SqlDbType.Bit).Value = dependentsModel.DependentStatus; 
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
                    cmd.CommandText = @"delete from  TBL_DEPENDENT where dependentId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<DependentsModel> GetAll()
        {
            var parkingList = new List<DependentsModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_DEPENDENT order by dependentId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dependentsModel = new DependentsModel();
                            dependentsModel.DependentId = (int)reader[0];
                            dependentsModel.TenantId = (int)reader["tenantId"];
                            dependentsModel.DependentName = (string)reader["dependentName"];
                            dependentsModel.DependentRelationship = (string)reader["dependentRelationship"];
                            dependentsModel.DependentGender = (string)reader["dependentGender"];                           
                            dependentsModel.DependentStatus = (bool)reader["dependentStatus"];
                            parkingList.Add(dependentsModel);
                        }
                    }

                }

            }
            return parkingList;
        }
        public IEnumerable<DependentsModel> GetByValue(string value)
        {
            var parkingList = new List<DependentsModel>();
            int dependentId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string dependentName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_DEPENDENT where dependentId=@id or dependentName like @name +'%' order by dependentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = dependentId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = dependentName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dependentsModel = new DependentsModel();
                            dependentsModel.DependentId = (int)reader[0];
                            dependentsModel.TenantId = (int)reader["tenantId"];
                            dependentsModel.DependentName = (string)reader["dependentName"];
                            dependentsModel.DependentRelationship = (string)reader["dependentRelationship"];
                            dependentsModel.DependentGender = (string)reader["dependentGender"];
                            dependentsModel.DependentStatus = (bool)reader["dependentStatus"];
                            parkingList.Add(dependentsModel);
                        }
                    }

                }

            }
            return parkingList;
        }


    }
}
