using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartment._Repositories.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Apartment._Repositories
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //public void Add(UserModel userModel)
        //{
        //     //Define Scope
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        using (var cmd = new SqlCommand())
        //        {
        //            connection.Open();
        //            cmd.Connection = connection;
        //            cmd.CommandText = @"insert into TBL_USERS
        //                                     values (@userName,
        //                                            @userPassword,
        //                                            @userType, 
        //                                            @userStatus
        //                                             ) 
        //          ";
        //            cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userModel.UserName;
        //            cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = userModel.UserPassword;
        //            cmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = userModel.UserType;
        //            cmd.Parameters.Add("@userStatus", SqlDbType.Bit).Value = userModel.UserStatus;
        //            cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = userModel.CustomerId;
        //            cmd.ExecuteNonQuery();

        //        }

        //    }

        //}

        public void Add(UserModel userModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_USERS
                                             values (@userName,
                                                    @userPassword,
                                                    @userType, 
                                                    @userStatus,
                                                    @customerId
                                                     ) 
                  ";
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userModel.UserName;
                    cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = userModel.UserPassword;
                    cmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = userModel.UserType;
                    cmd.Parameters.Add("@userStatus", SqlDbType.Bit).Value = userModel.UserStatus;
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = userModel.CustomerId == null ? 0 : userModel.CustomerId;
                    cmd.ExecuteNonQuery();

                }

            }
        }




        public void Update(UserModel userModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_USERS
                                        set    userName = @userName,
                                               userPassword = @userPassword,
                                               userType = @userType,                                               
                                               userStatus = @userStatus
                                               
                                        where  userId = @id 
";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = userModel.UserId;
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userModel.UserName;
                    cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = userModel.UserPassword;
                    cmd.Parameters.Add("@userType", SqlDbType.NVarChar).Value = userModel.UserType;
                    cmd.Parameters.Add("@userStatus", SqlDbType.Bit).Value = userModel.UserStatus;
                   // cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = userModel.CustomerId;
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = userModel.CustomerId == null ? 0 : userModel.CustomerId;


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
                    cmd.CommandText = @"delete from  TBL_USERS where userId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_USERS order by userId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userModel = new UserModel();
                            userModel.UserId = (int)reader[0];
                            userModel.UserName = (string)reader["userName"];
                            userModel.UserPassword = (string)reader["userPassword"];
                            userModel.UserType = (string)reader["userType"];
                            userModel.UserStatus = (bool)reader["userStatus"];
                            userModel.CustomerId = (int)reader["customerId"];

                            userList.Add(userModel);
                        }
                    }

                }

            }
            return userList;
        }
        public IEnumerable<UserModel> GetByValue(string value)
        {
            var userList = new List<UserModel>();
            int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_USERS where userId=@id   order by userId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = userName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userModel = new UserModel();
                            userModel.UserId = (int)reader[0];
                            userModel.UserName = (string)reader["userName"];
                            userModel.UserPassword = (string)reader["userPassword"];
                            userModel.UserType = (string)reader["userType"];
                            userModel.UserStatus = (bool)reader["userStatus"];
                            userModel.CustomerId = (int)reader["customerId"];

                            userList.Add(userModel);
                        }
                    }

                }

            }
            return userList;
        }

        public IEnumerable<UserModel> Login(string userName, string password)
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_USERS where userName=@userName and userPassword=@userPassword ";
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
                    cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = password;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userModel = new UserModel();
                            userModel.UserId = (int)reader[0];
                            userModel.UserName = (string)reader["userName"];
                            userModel.UserPassword = (string)reader["userPassword"];
                            userModel.UserType = (string)reader["userType"];
                            userModel.UserStatus = (bool)reader["userStatus"];
                            userModel.CustomerId = (int)reader["customerId"];

                            userList.Add(userModel);
                        }
                    }

                }

            }
            return userList;
        }
    }
}