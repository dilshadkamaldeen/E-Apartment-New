using E_Apartment._Repositories.Interfaces;
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
    internal class ReservationRepository : BaseRepository, IReservationRepository
    {
        public ReservationRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void Add(ReservationModel reservationModel)
        {
            int primaryKey;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_RESERVATION 
                                        values (@reservationBuildingId, @reservationApartmentId, @reservationApartmentStatus, 
                                                @reservationFee,@isReservationFeePaid,@reservationTenantId,@isWaitingList
                                                )
                                        SELECT SCOPE_IDENTITY()

";
                    cmd.Parameters.Add("@reservationBuildingId", SqlDbType.Int).Value = reservationModel.ReservationBuildingId;
                    cmd.Parameters.Add("@reservationApartmentId", SqlDbType.Int).Value = reservationModel.ReservationApartmentId;
                    cmd.Parameters.Add("@reservationApartmentStatus", SqlDbType.NVarChar).Value = reservationModel.ReservationApartmentStatus;
                    cmd.Parameters.Add("@reservationFee", SqlDbType.Decimal).Value = reservationModel.ReservationFee;
                    cmd.Parameters.Add("@isReservationFeePaid", SqlDbType.Bit).Value = reservationModel.IsReservationFeePaid;
                    cmd.Parameters.Add("@reservationTenantId", SqlDbType.Int).Value = reservationModel.ReservationTenantId;
                    cmd.Parameters.Add("@isWaitingList", SqlDbType.Bit).Value = reservationModel.IsWaitingList;

                    //Last inserted Row Id
                    primaryKey = Convert.ToInt32(cmd.ExecuteScalar());
                    // cmd.ExecuteNonQuery();
                    connection.Close();

                }

                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @" 
                                UPDATE TBL_APARTMENT 
                                    SET   status = @status                        
                                WHERE apartmentId=@id
";

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = reservationModel.ReservationApartmentId;
                    cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Reserved";

                    cmd.ExecuteNonQuery();
                    connection.Close();

                }


                if (reservationModel.IsReservationFeePaid)
                {
                    MessageBox.Show("Payments " + reservationModel.ReservationFee.ToString());
                    DateTime dateTime = DateTime.UtcNow.Date;
                    var paymentModel = new PaymentModel
                    {

                        PaymentType = "ReservationFee",
                        PaidAmount = reservationModel.ReservationFee,
                        PaidDate = dateTime,
                        IsReservationFeePayment = true,
                        ReservationId = primaryKey,
                        IsDuePayment = false,
                        LeaseAgreementId = 0,
                    };

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
                        var msg = string.Format("{0} Reservation Fee is Paid Successfully", paymentModel.PaidAmount);
                        MessageBox.Show(msg);
                        connection.Close();
                    }
                }

            }

        }
        public void Update(ReservationModel reservationModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update TBL_RESERVATION 
                                        set reservationBuildingId=@reservationBuildingId , reservationApartmentId= @reservationApartmentId, 
                                            reservationApartmentStatus=@reservationApartmentStatus,reservationFee=@reservationFee,isReservationFeePaid=@isReservationFeePaid,
                                            reservationTenantId=@reservationTenantId,isWaitingList=@isWaitingList 
                                        where reservationId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = reservationModel.ReservationId.ToString();
                    cmd.Parameters.Add("@reservationBuildingId", SqlDbType.Int).Value = reservationModel.ReservationBuildingId;
                    cmd.Parameters.Add("@reservationApartmentId", SqlDbType.Int).Value = reservationModel.ReservationApartmentId;
                    cmd.Parameters.Add("@reservationApartmentStatus", SqlDbType.NVarChar).Value = reservationModel.ReservationApartmentStatus;
                    cmd.Parameters.Add("@reservationFee", SqlDbType.Decimal).Value = reservationModel.ReservationFee;
                    cmd.Parameters.Add("@isReservationFeePaid", SqlDbType.Bit).Value = reservationModel.IsReservationFeePaid;
                    cmd.Parameters.Add("@reservationTenantId", SqlDbType.Int).Value = reservationModel.ReservationTenantId;
                    cmd.Parameters.Add("@isWaitingList", SqlDbType.Bit).Value = reservationModel.IsWaitingList;
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
                    cmd.CommandText = @"delete from  TBL_RESERVATION where reservationId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }
        public IEnumerable<ReservationModel> GetAll()
        {
            var reservationList = new List<ReservationModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_RESERVATION order by reservationId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservationModel = new ReservationModel();
                            reservationModel.ReservationId = (int)reader[0];
                            reservationModel.ReservationBuildingId = (int)reader["reservationBuildingId"];
                            reservationModel.ReservationApartmentId = (int)reader["reservationApartmentId"];
                            reservationModel.ReservationApartmentStatus = (string)reader["reservationApartmentStatus"];
                            reservationModel.ReservationFee = (decimal)reader["reservationFee"];
                            reservationModel.IsReservationFeePaid = (bool)reader["isReservationFeePaid"];
                            reservationModel.ReservationTenantId = (int)reader["reservationTenantId"];
                            reservationList.Add(reservationModel);
                        }
                    }

                }

            }
            return reservationList;
        }
        public IEnumerable<ReservationModel> GetByValue(string value)
        {
            var reservationList = new List<ReservationModel>();
            int reservationId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string reservationBuildingId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_RESERVATION where reservationId=@id   order by reservationId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = reservationBuildingId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservationModel = new ReservationModel();
                            reservationModel.ReservationId = (int)reader[0];
                            reservationModel.ReservationBuildingId = (int)reader["reservationBuildingId"];
                            reservationModel.ReservationApartmentId = (int)reader["reservationApartmentId"];
                            reservationModel.ReservationApartmentStatus = (string)reader["reservationApartmentStatus"];
                            reservationModel.ReservationFee = (decimal)reader["reservationFee"];
                            reservationModel.IsReservationFeePaid = (bool)reader["isReservationFeePaid"];
                            reservationModel.ReservationTenantId = (int)reader["reservationTenantId"];

                            reservationList.Add(reservationModel);
                        }
                    }

                }

            }
            return reservationList;
        }

        //Others
        public IEnumerable<ApartmentModel> GetAllApartment()
        {
            var apartments = new List<ApartmentModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APARTMENT order by apartmentId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var apartmentModel = new ApartmentModel
                            {
                                ApartmentId = Convert.ToInt32(reader["apartmentId"]),
                                ApartmentClassId = Convert.ToInt32(reader["apartmentClassId"]),
                                ApartmentBuildingId = Convert.ToInt32(reader["apartmentBuildingId"]),
                                ApartmentNo = Convert.ToInt32(reader["apartmentNo"]),
                                ApartmentRentPerMonth = Convert.ToDecimal(reader["apartmentRentPerMonth"]),
                                MaxNumberOccupied = Convert.ToInt32(reader["maxNumberOccupied"]),
                                IsLivingArea = Convert.ToBoolean(reader["isLivingArea"]),
                                LivingAreaSqft = Convert.ToDecimal(reader["livingAreaSqft"]),
                                IsDiningArea = Convert.ToBoolean(reader["isDiningArea"]),
                                DiningAreaSqft = Convert.ToDecimal(reader["diningAreaSqft"]),
                                IsKitchenArea = Convert.ToBoolean(reader["isKitchenArea"]),
                                KitchenAreaSqft = Convert.ToDecimal(reader["kitchenAreaSqft"]),
                                IsLaundryArea = Convert.ToBoolean(reader["isLaundryArea"]),
                                LaundryAreaSqft = Convert.ToDecimal(reader["laundryAreaSqft"]),
                                ReservationFee = Convert.ToDecimal(reader["reservationFee"]),
                                IsTelephoneService = Convert.ToBoolean(reader["isTelephoneService"]),
                                IsBroadbandInternet = Convert.ToBoolean(reader["isBroadbandInternet"]),
                                IsCableTv = Convert.ToBoolean(reader["isCableTv"]),
                                IsParkingArea = Convert.ToBoolean(reader["isParkingArea"]),
                                IsGymnasium = Convert.ToBoolean(reader["isGymnasium"]),
                                IsSwimingPool = Convert.ToBoolean(reader["isSwimingPool"]),
                                Status = reader["status"].ToString(),

                            };

                            apartments.Add(apartmentModel);
                        }
                    }

                }

            }
            return apartments;
        }
        public IEnumerable<ApartmentModel> GetAllApartmentByBuildingId(int buildingId)
        {
            var apartment = new List<ApartmentModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"select *, A.status as apartmentStatus , C.status as apartmentClassStatus
                                        from TBL_APARTMENT A 
                                        join TBL_BUILDINGS B on A.apartmentBuildingId = B.buildingId 
                                        join TBL_APPARTMENT_CLASS C on  C.classNameId = A.apartmentClassId

                                        where B.buildingId = @id order by apartmentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = buildingId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var buildingModel = new BuildingsModel
                            {
                                BuildingAddress = reader["buildingAddress"].ToString(),
                                Id = (int)reader["buildingId"],
                                BuildingName = (string)reader["buildingName"],
                                BuildingLocation = (string)reader["buildingLocation"]

                            };

                            var apartmentClassModel = new ApartmentClassModel
                            {
                                ClassNameId = (int)reader["classNameId"],
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
                                Status = Convert.ToBoolean(reader["apartmentClassStatus"])
                            };

                            var apartmentModel = new ApartmentModel
                            {
                                ApartmentId = Convert.ToInt32(reader["apartmentId"]),
                                ApartmentClassId = Convert.ToInt32(reader["apartmentClassId"]),
                                ApartmentBuildingId = Convert.ToInt32(reader["apartmentBuildingId"]),
                                ApartmentNo = Convert.ToInt32(reader["apartmentNo"]),
                                ApartmentRentPerMonth = Convert.ToDecimal(reader["apartmentRentPerMonth"]),
                                MaxNumberOccupied = Convert.ToInt32(reader["maxNumberOccupied"]),
                                IsLivingArea = Convert.ToBoolean(reader["isLivingArea"]),
                                LivingAreaSqft = Convert.ToDecimal(reader["livingAreaSqft"]),
                                IsDiningArea = Convert.ToBoolean(reader["isDiningArea"]),
                                DiningAreaSqft = Convert.ToDecimal(reader["diningAreaSqft"]),
                                IsKitchenArea = Convert.ToBoolean(reader["isKitchenArea"]),
                                KitchenAreaSqft = Convert.ToDecimal(reader["kitchenAreaSqft"]),
                                IsLaundryArea = Convert.ToBoolean(reader["isLaundryArea"]),
                                LaundryAreaSqft = Convert.ToDecimal(reader["laundryAreaSqft"]),
                                IsTelephoneService = Convert.ToBoolean(reader["isTelephoneService"]),
                                IsBroadbandInternet = Convert.ToBoolean(reader["isBroadbandInternet"]),
                                IsCableTv = Convert.ToBoolean(reader["isCableTv"]),
                                IsParkingArea = Convert.ToBoolean(reader["isParkingArea"]),
                                IsGymnasium = Convert.ToBoolean(reader["isGymnasium"]),
                                IsSwimingPool = Convert.ToBoolean(reader["isSwimingPool"]),
                                Status = reader["apartmentStatus"].ToString(),

                                //joining
                                apartmentClass = apartmentClassModel,
                                buildingsModel = buildingModel

                            };


                            apartment.Add(apartmentModel);
                        }
                    }

                }

            }
            return apartment;
        }
        public IEnumerable<ApartmentClassModel> GetAllApartmentClass()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BuildingsModel> GetAllBuildings()
        {
            var buildingList = new List<BuildingsModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_BUILDINGS order by buildingId desc";
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
        public IEnumerable<ApartmentModel> GetApartmentById(int apartmentId)
        {
            var apartmentModelList = new List<ApartmentModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"select *, A.status as apartmentStatus , C.status as apartmentClassStatus
                                        from TBL_APARTMENT A 
                                        join TBL_BUILDINGS B on A.apartmentBuildingId = B.buildingId 
                                        join TBL_APPARTMENT_CLASS C on  C.classNameId = A.apartmentClassId

                                        where A.apartmentId = @id order by apartmentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = apartmentId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var model = new ApartmentModel
                            {
                                ApartmentId = Convert.ToInt32(reader["apartmentId"]),
                                ApartmentClassId = Convert.ToInt32(reader["apartmentClassId"]),
                                ApartmentBuildingId = Convert.ToInt32(reader["apartmentBuildingId"]),
                                ApartmentNo = Convert.ToInt32(reader["apartmentNo"]),
                                ApartmentRentPerMonth = Convert.ToDecimal(reader["apartmentRentPerMonth"]),
                                MaxNumberOccupied = Convert.ToInt32(reader["maxNumberOccupied"]),
                                IsLivingArea = Convert.ToBoolean(reader["isLivingArea"]),
                                LivingAreaSqft = Convert.ToDecimal(reader["livingAreaSqft"]),
                                IsDiningArea = Convert.ToBoolean(reader["isDiningArea"]),
                                DiningAreaSqft = Convert.ToDecimal(reader["diningAreaSqft"]),
                                IsKitchenArea = Convert.ToBoolean(reader["isKitchenArea"]),
                                KitchenAreaSqft = Convert.ToDecimal(reader["kitchenAreaSqft"]),
                                ReservationFee = Convert.ToDecimal(reader["reservationFee"]),
                                IsLaundryArea = Convert.ToBoolean(reader["isLaundryArea"]),
                                LaundryAreaSqft = Convert.ToDecimal(reader["laundryAreaSqft"]),
                                IsTelephoneService = Convert.ToBoolean(reader["isTelephoneService"]),
                                IsBroadbandInternet = Convert.ToBoolean(reader["isBroadbandInternet"]),
                                IsCableTv = Convert.ToBoolean(reader["isCableTv"]),
                                IsParkingArea = Convert.ToBoolean(reader["isParkingArea"]),
                                IsGymnasium = Convert.ToBoolean(reader["isGymnasium"]),
                                IsSwimingPool = Convert.ToBoolean(reader["isSwimingPool"]),
                                Status = reader["apartmentStatus"].ToString(),

                                apartmentClass = new ApartmentClassModel
                                {
                                    ClassNameId = (int)reader["classNameId"],
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
                                    Status = Convert.ToBoolean(reader["apartmentClassStatus"])
                                },
                                buildingsModel = new BuildingsModel
                                {
                                    BuildingAddress = reader["buildingAddress"].ToString(),
                                    Id = (int)reader["buildingId"],
                                    BuildingName = (string)reader["buildingName"],
                                    BuildingLocation = (string)reader["buildingLocation"]

                                }


                            };

                            apartmentModelList.Add(model);

                        }
                    }

                }

            }

            return apartmentModelList;
        }
        public void AddApplication(ApplicationModel applicationModel)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"insert into TBL_APPLICATION values (@applicationBuildingId, @applicationApartmentId, @applicationApartmentStatus, @applicationTenantId , @isWaitingList)";
                    cmd.Parameters.Add("@applicationBuildingId", SqlDbType.Int).Value = applicationModel.ApplicationBuildingId;
                    cmd.Parameters.Add("@applicationApartmentId", SqlDbType.Int).Value = applicationModel.ApplicationApartmentId;
                    cmd.Parameters.Add("@applicationApartmentStatus", SqlDbType.NVarChar).Value = applicationModel.ApplicationApartmentStatus;
                    cmd.Parameters.Add("@applicationTenantId", SqlDbType.Int).Value = applicationModel.ApplicationTenantId;
                    cmd.Parameters.Add("@isWaitingList", SqlDbType.Bit).Value = applicationModel.IsWaitingList;
                    cmd.Parameters.Add("@applyDate", SqlDbType.DateTime).Value = new DateTime();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(applicationModel.ApplicationBuildingId.ToString());
                }

            }

        }
        public void Update(LeasingAgreementModel leasingAgreementModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TenantsModel> GetAllTenants()
        {
            var tenantsList = new List<TenantsModel>();
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
                            tenantsModel.TenantId = (int)reader[0];
                            tenantsModel.TenantName = (string)reader[1];
                            tenantsModel.TenantNIC = (string)reader[2];
                            tenantsModel.TenantContact = (string)reader[3];
                            tenantsModel.TenantAddress = Convert.ToString(reader["tenantAddress"]);
                            tenantsModel.TenantGender = (string)reader["tenantGender"];
                            tenantsModel.TenantStatus = (bool)reader["tenantStatus"];
                            tenantsList.Add(tenantsModel);
                        }
                    }

                }

            }
            return tenantsList;
        }
        public IEnumerable<ReservationModel> GetByTenantId(string value)
        {
            var reservationList = new List<ReservationModel>();
            int reservationId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string reservationBuildingId = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_RESERVATION where reservationTenantId=@id   order by reservationId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = reservationBuildingId;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservationModel = new ReservationModel();
                            reservationModel.ReservationId = (int)reader[0];
                            reservationModel.ReservationBuildingId = (int)reader["reservationBuildingId"];
                            reservationModel.ReservationApartmentId = (int)reader["reservationApartmentId"];
                            reservationModel.ReservationApartmentStatus = (string)reader["reservationApartmentStatus"];
                            reservationModel.ReservationFee = (decimal)reader["reservationFee"];
                            reservationModel.IsReservationFeePaid = (bool)reader["isReservationFeePaid"];
                            reservationModel.ReservationTenantId = (int)reader["reservationTenantId"];

                            reservationList.Add(reservationModel);
                        }
                    }

                }

            }
            return reservationList;
        }

    }
}
