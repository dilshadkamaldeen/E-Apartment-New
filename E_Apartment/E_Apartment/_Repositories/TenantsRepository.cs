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
    

    internal class TenantsRepository : BaseRepository, ITenantsRepository
    {
        public TenantsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public void Add(TenantsModel tenantsModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_TENANTS values (@tenantName, @tenantNIC, @tenantContact, @tenantAddress , @tenantGender, @tenantStatus)";
                    cmd.Parameters.Add("@tenantName", SqlDbType.NVarChar).Value = tenantsModel.TenantName;
                    cmd.Parameters.Add("@tenantNIC", SqlDbType.NVarChar).Value = tenantsModel.TenantNIC;
                    cmd.Parameters.Add("@tenantContact", SqlDbType.NVarChar).Value = tenantsModel.TenantContact;
                    cmd.Parameters.Add("@tenantAddress", SqlDbType.NVarChar).Value = tenantsModel.TenantAddress;
                    cmd.Parameters.Add("@tenantGender", SqlDbType.NVarChar).Value = tenantsModel.TenantGender;
                    cmd.Parameters.Add("@tenantStatus", SqlDbType.Bit).Value = true;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Update(TenantsModel tenantsModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_TENANTS set tenantName=@tenantName , tenantNIC= @tenantNIC, tenantContact=@tenantContact , tenantGender= @tenantGender where tenantId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = tenantsModel.TenantId;
                    cmd.Parameters.Add("@tenantName", SqlDbType.NVarChar).Value = tenantsModel.TenantName;
                    cmd.Parameters.Add("@tenantNIC", SqlDbType.NVarChar).Value = tenantsModel.TenantNIC;
                    cmd.Parameters.Add("@tenantContact", SqlDbType.NVarChar).Value = tenantsModel.TenantContact;
                    cmd.Parameters.Add("@tenantGender", SqlDbType.NVarChar).Value = tenantsModel.TenantGender;
                    cmd.Parameters.Add("@tenantStatus", SqlDbType.Bit).Value = tenantsModel.TenantStatus; 
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
                    cmd.CommandText = @"delete from  TBL_TENANTS where tenantId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<TenantsModel> GetAll()
        {
            var parkingList = new List<TenantsModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_TENANTS order by tenantId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tenantsModel = new TenantsModel();
                            tenantsModel.TenantId = (int)reader["tenantId"];
                            tenantsModel.TenantName = (string)reader["tenantName"];
                            tenantsModel.TenantNIC = (string)reader["tenantNIC"];
                            tenantsModel.TenantContact = (string)reader["tenantContact"];
                            tenantsModel.TenantAddress = Convert.ToString(reader["tenantAddress"]);
                            tenantsModel.TenantGender = (string)reader["tenantGender"];
                            tenantsModel.TenantStatus = (bool)reader["tenantStatus"];
                            parkingList.Add(tenantsModel);
                        }
                    }

                }

            }
            return parkingList;
        }
        public IEnumerable<TenantsModel> GetByValue(string value)
        {
            var parkingList = new List<TenantsModel>();
            int tenantId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string tenantName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_TENANTS where tenantId=@id or tenantName like @name +'%' order by tenantId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = tenantId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenantName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tenantsModel = new TenantsModel();
                            tenantsModel.TenantId = (int)reader[0];
                            tenantsModel.TenantName = (string)reader[1];
                            tenantsModel.TenantNIC = (string)reader[2];
                            tenantsModel.TenantContact = (string)reader[3];
                            tenantsModel.TenantAddress = Convert.ToString(reader["tenantAddress"]);
                            tenantsModel.TenantGender = (string)reader["tenantGender"];
                            tenantsModel.TenantStatus = (bool)reader["tenantStatus"];
                            parkingList.Add(tenantsModel);
                        }
                    }

                }

            }
            return parkingList;
        }


    }
}
