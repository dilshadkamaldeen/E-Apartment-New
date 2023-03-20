using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using E_Apartment.Views;
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
    internal class LeasingAgreementRepository : BaseRepository, ILeasingAgreementRepository
    {
        public LeasingAgreementRepository(string connectionString)
        {

            this.connectionString = connectionString;
        }
        public void Add(LeasingAgreementModel leasingAgreementModel)
        {
            int primaryKey;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"

                                    INSERT INTO TBL_LEASE_AGREEMENT
                                               (reservationId
                                               ,tenantId
                                               ,refundableDeposit
                                               ,firstMonthRent
                                               ,totalAdvanceAmount
                                               ,isTotalAdvancePaid
                                               ,term
                                               ,leaseStartDate
                                               ,leaseExpireDate
                                               ,totalDueAmount
                                               ,isAllocateDefaultParking
                                               ,leaseAgreementStatus)
                                         VALUES
                                               (@reservationId  
                                               ,@tenantId   
                                               ,@refundableDeposit 
                                               ,@firstMonthRent 
                                               ,@totalAdvanceAmount 
                                               ,@isTotalAdvancePaid 
                                               ,@term 
                                               ,@leaseStartDate 
                                               ,@leaseExpireDate 
                                               ,@totalDueAmount 
                                               ,@isAllocateDefaultParking 
                                               ,@leaseAgreementStatus )
                                        SELECT SCOPE_IDENTITY()
";
                    cmd.Parameters.Add("@reservationId", SqlDbType.Int).Value = leasingAgreementModel.ReservationId;
                    cmd.Parameters.Add("@tenantId", SqlDbType.Int).Value = leasingAgreementModel.TenantId;
                    cmd.Parameters.Add("@refundableDeposit", SqlDbType.NVarChar).Value = leasingAgreementModel.RefundableDeposit;
                    cmd.Parameters.Add("@firstMonthRent", SqlDbType.Decimal).Value = leasingAgreementModel.FirstMonthRent;
                    cmd.Parameters.Add("@totalAdvanceAmount", SqlDbType.Decimal).Value = leasingAgreementModel.TotalAdvanceAmount;
                    cmd.Parameters.Add("@isTotalAdvancePaid", SqlDbType.Bit).Value = leasingAgreementModel.IsTotalAdvancePaid;
                    cmd.Parameters.Add("@term", SqlDbType.NVarChar).Value = leasingAgreementModel.Term;
                    cmd.Parameters.Add("@leaseStartDate", SqlDbType.DateTime).Value = leasingAgreementModel.LeaseStartDate;
                    cmd.Parameters.Add("@leaseExpireDate", SqlDbType.DateTime).Value = leasingAgreementModel.LeaseExpireDate;
                    cmd.Parameters.Add("@totalDueAmount", SqlDbType.Decimal).Value = leasingAgreementModel.TotalDueAmount;
                    cmd.Parameters.Add("@isAllocateDefaultParking", SqlDbType.Bit).Value = leasingAgreementModel.IsAllocateDefaultParking;
                    cmd.Parameters.Add("@leaseAgreementStatus", SqlDbType.Bit).Value = leasingAgreementModel.LeaseAgreementStatus;
                    //Last inserted Row Id
                    primaryKey = Convert.ToInt32(cmd.ExecuteScalar());
                    // cmd.ExecuteNonQuery();
                    connection.Close();

                }

                if (leasingAgreementModel.IsTotalAdvancePaid)
                {
                    var paymentModel = new PaymentModel();

                    paymentModel.PaymentType = "Advance";
                    paymentModel.PaidAmount = leasingAgreementModel.TotalAdvanceAmount;
                    paymentModel.PaidDate = DateTime.Now;
                    paymentModel.IsReservationFeePayment = false;
                    paymentModel.ReservationId = 0;
                    paymentModel.IsDuePayment = false;
                    paymentModel.LeaseAgreementId = primaryKey;

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
                        var msg = string.Format("Congratulation Your Lease ID is : {0}, Lease Agreement's Advance Payment Successfully Paided", primaryKey);
                        MessageBox.Show(msg, "Payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }





            }

        }
        public void Update(LeasingAgreementModel leasingAgreementModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"

                                    UPDATE  TBL_LEASE_AGREEMENT
                                       SET reservationId =@reservationId
                                          ,tenantId =@tenantId
                                          ,refundableDeposit =@refundableDeposit
                                          ,firstMonthRent =@firstMonthRent
                                          ,totalAdvanceAmount =@totalAdvanceAmount
                                          ,isTotalAdvancePaid =@isTotalAdvancePaid
                                          ,term =@term 
                                          ,leaseStartDate =@leaseStartDate
                                          ,leaseExpireDate =@leaseExpireDate
                                          ,totalDueAmount =@totalDueAmount
                                          ,isAllocateDefaultParking =@isAllocateDefaultParking
                                          ,leaseAgreementStatus =@leaseAgreementStatus
                                     WHERE leaseAgreementId=@id
)
 
";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leasingAgreementModel.LeaseAgreementId;
                    cmd.Parameters.Add("@reservationId", SqlDbType.Int).Value = leasingAgreementModel.ReservationId;
                    cmd.Parameters.Add("@tenantId", SqlDbType.Int).Value = leasingAgreementModel.TenantId;
                    cmd.Parameters.Add("@refundableDeposit", SqlDbType.NVarChar).Value = leasingAgreementModel.RefundableDeposit;
                    cmd.Parameters.Add("@firstMonthRent", SqlDbType.Decimal).Value = leasingAgreementModel.FirstMonthRent;
                    cmd.Parameters.Add("@totalAdvanceAmount", SqlDbType.Decimal).Value = leasingAgreementModel.TotalAdvanceAmount;
                    cmd.Parameters.Add("@isTotalAdvancePaid", SqlDbType.Bit).Value = leasingAgreementModel.IsTotalAdvancePaid;
                    cmd.Parameters.Add("@term", SqlDbType.NVarChar).Value = leasingAgreementModel.Term;
                    cmd.Parameters.Add("@leaseStartDate", SqlDbType.DateTime).Value = leasingAgreementModel.LeaseStartDate;
                    cmd.Parameters.Add("@leaseExpireDate", SqlDbType.DateTime).Value = leasingAgreementModel.LeaseExpireDate;
                    cmd.Parameters.Add("@totalDueAmount", SqlDbType.Decimal).Value = leasingAgreementModel.TotalDueAmount;
                    cmd.Parameters.Add("@isAllocateDefaultParking", SqlDbType.Bit).Value = leasingAgreementModel.IsAllocateDefaultParking;
                    cmd.Parameters.Add("@leaseAgreementStatus", SqlDbType.Bit).Value = leasingAgreementModel.LeaseAgreementStatus;
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<LeasingAgreementModel> GetAll()
        {
            var leaseAgreementList = new List<LeasingAgreementModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_AGREEMENT order by leaseAgreementId desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leasingModel = new LeasingAgreementModel
                            {
                                LeaseAgreementId = (int)reader["LeaseAgreementId"],
                                ReservationId = (int)reader["ReservationId"],
                                TenantId = (int)reader["TenantId"],
                                RefundableDeposit = (decimal)reader["RefundableDeposit"],
                                FirstMonthRent = (decimal)reader["FirstMonthRent"],
                                TotalAdvanceAmount = (decimal)reader["TotalAdvanceAmount"],
                                IsTotalAdvancePaid = (bool)reader["IsTotalAdvancePaid"],
                                Term = (string)reader["Term"],
                                LeaseStartDate = (DateTime)reader["LeaseStartDate"],
                                LeaseExpireDate = (DateTime)reader["LeaseExpireDate"],
                                TotalDueAmount = (decimal)reader["TotalDueAmount"],
                                IsAllocateDefaultParking = (bool)reader["IsAllocateDefaultParking"],
                                LeaseAgreementStatus = (bool)reader["LeaseAgreementStatus"],
                            };


                            leaseAgreementList.Add(leasingModel);
                        }
                    }

                }

            }
            return leaseAgreementList;
        }
        public IEnumerable<LeasingAgreementModel> GetByValue(string value)
        {

            var leaseAgreemntList = new List<LeasingAgreementModel>();
            int leaseAgreemntId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string leaseAgreemntName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_AGREEMENT where leaseAgreementId=@id  order by leaseAgreementId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseAgreemntId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leasingModel = new LeasingAgreementModel
                            {
                                LeaseAgreementId = (int)reader["LeaseAgreementId"],
                                ReservationId = (int)reader["ReservationId"],
                                TenantId = (int)reader["TenantId"],
                                RefundableDeposit = (decimal)reader["RefundableDeposit"],
                                FirstMonthRent = (decimal)reader["FirstMonthRent"],
                                TotalAdvanceAmount = (decimal)reader["TotalAdvanceAmount"],
                                IsTotalAdvancePaid = (bool)reader["IsTotalAdvancePaid"],
                                Term = (string)reader["Term"],
                                LeaseStartDate = (DateTime)reader["LeaseStartDate"],
                                LeaseExpireDate = (DateTime)reader["LeaseExpireDate"],
                                TotalDueAmount = (decimal)reader["TotalDueAmount"],
                                IsAllocateDefaultParking = (bool)reader["IsAllocateDefaultParking"],
                                LeaseAgreementStatus = (bool)reader["LeaseAgreementStatus"],
                            };
                            leaseAgreemntList.Add(leasingModel);
                        }
                    }

                }

            }
            return leaseAgreemntList;
        }
        public IEnumerable<LeasingAgreementModel> GetByTenantId(string value)
        {

            var leaseAgreemntList = new List<LeasingAgreementModel>();
            int leaseAgreemntId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string leaseAgreemntName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_LEASE_AGREEMENT where TenantId=@id  order by leaseAgreementId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseAgreemntId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var leasingModel = new LeasingAgreementModel
                            {
                                LeaseAgreementId = (int)reader["LeaseAgreementId"],
                                ReservationId = (int)reader["ReservationId"],
                                TenantId = (int)reader["TenantId"],
                                RefundableDeposit = (decimal)reader["RefundableDeposit"],
                                FirstMonthRent = (decimal)reader["FirstMonthRent"],
                                TotalAdvanceAmount = (decimal)reader["TotalAdvanceAmount"],
                                IsTotalAdvancePaid = (bool)reader["IsTotalAdvancePaid"],
                                Term = (string)reader["Term"],
                                LeaseStartDate = (DateTime)reader["LeaseStartDate"],
                                LeaseExpireDate = (DateTime)reader["LeaseExpireDate"],
                                TotalDueAmount = (decimal)reader["TotalDueAmount"],
                                IsAllocateDefaultParking = (bool)reader["IsAllocateDefaultParking"],
                                LeaseAgreementStatus = (bool)reader["LeaseAgreementStatus"],
                            };
                            leaseAgreemntList.Add(leasingModel);
                        }
                    }

                }

            }
            return leaseAgreemntList;
        }



        #region Other Mothods
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

        public IEnumerable<ApartmentModel> GetAllApartmentByBuildingId(int leaseAgreementId)
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
                                        join TBL_LEASE_AGREEMENT B on A.apartmentBuildingId = B.leaseAgreementId 
                                        join TBL_APPARTMENT_CLASS C on  C.classNameId = A.apartmentClassId

                                        where B.leaseAgreementId = @id order by apartmentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = leaseAgreementId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var buildingModel = new BuildingsModel
                            {
                                BuildingAddress = reader["buildingAddress"].ToString(),
                                Id = (int)reader["leaseAgreementId"],
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
                                        join TBL_LEASE_AGREEMENT B on A.apartmentBuildingId = B.leaseAgreementId 
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
                                    Id = (int)reader["leaseAgreementId"],
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

        public IEnumerable<ReservationModel> GetReservationById(int reservationId)
        {
            var reservationModelList = new List<ReservationModel>();

            if (reservationId <= 0)
            {
                return reservationModelList;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT *,
                                               A.status AS apartmentStatus,
                                               C.status AS apartmentClassStatus
                                        FROM TBL_APARTMENT A
                                        JOIN TBL_BUILDINGS B ON A.apartmentBuildingId = B.buildingId
                                        JOIN TBL_APPARTMENT_CLASS C ON C.classNameId = A.apartmentClassId
                                        JOIN TBL_RESERVATION R ON R.reservationApartmentId = A.apartmentId
                                        JOIN TBL_TENANTS T ON T.tenantId = R.reservationTenantId

                                        WHERE R.reservationId = @id  

";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = reservationId;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservationModel = new ReservationModel
                            {
                                ReservationId = (int)reader[0],
                                ReservationBuildingId = (int)reader["reservationBuildingId"],
                                ReservationApartmentId = (int)reader["reservationApartmentId"],
                                ReservationApartmentStatus = (string)reader["reservationApartmentStatus"],
                                ReservationFee = (decimal)reader["reservationFee"],
                                IsReservationFeePaid = (bool)reader["isReservationFeePaid"],
                                ReservationTenantId = (int)reader["reservationTenantId"],
                                Apartment = new ApartmentModel
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


                                },
                                Tenants = new TenantsModel
                                {
                                    TenantId = (int)reader["tenantId"],
                                    TenantName = (string)reader["tenantName"],
                                    TenantNIC = (string)reader["tenantNIC"],
                                    TenantContact = (string)reader["tenantContact"],
                                    TenantAddress = Convert.ToString(reader["tenantAddress"]),
                                    TenantGender = (string)reader["tenantGender"],
                                    TenantStatus = (bool)reader["tenantStatus"]
                                },
                            };



                            reservationModelList.Add(reservationModel);

                        }
                    }

                }

            }

            return reservationModelList;
        }

        public IEnumerable<ReservationModel> GetAllReservations()
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

        #endregion

    }
}
