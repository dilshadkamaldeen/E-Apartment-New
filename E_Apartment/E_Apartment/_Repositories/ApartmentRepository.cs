using E_Apartment._Repositories.Interfaces;
using E_Apartment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace E_Apartment._Repositories
{
    internal class ApartmentRepository : BaseRepository, IApartmentRepository
    {
        public ApartmentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ApartmentModel apartmentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    //cmd.CommandText = @"
                    //    insert into TBL_APARTMENT values (
                    //    @apartmentClassId,
                    //    @apartmentBuildingId,
                    //    @apartmentNo,
                    //    @apartmentRentPerMonth,
                    //    @maxNumberOccupied,
                    //    @isLivingArea,
                    //    @livingAreaSqft,
                    //    @isDiningArea,
                    //    @diningAreaSqft,
                    //    @isKitchenArea,
                    //    @kitchenAreaSqft,
                    //    @isLaundryArea,
                    //    @laundryAreaSqft,
                    //    @isTelephoneService,
                    //    @isBroadbandInternet,
                    //    @isCableTv,
                    //    @isParkingArea,
                    //    @isGymnasium,
                    //    @isSwimingPool,
                    //    @reservationFee,
                    //    @status
                    //    )
                    //    ";

                    cmd.CommandText = @"
                        insert into TBL_APARTMENT (
                            apartmentClassId,
                            apartmentBuildingId,
                            apartmentNo,
                            apartmentRentPerMonth,
                            maxNumberOccupied,
                            isLivingArea,
                            livingAreaSqft,
                            isDiningArea,
                            diningAreaSqft,
                            isKitchenArea,
                            kitchenAreaSqft,
                            isLaundryArea,
                            laundryAreaSqft,
                            isTelephoneService,
                            isBroadbandInternet,
                            isCableTv,
                            isParkingArea,
                            isGymnasium,
                            isSwimingPool,
                            reservationFee,
                            status ) 

                    values (
                        @apartmentClassId,
                        @apartmentBuildingId,
                        @apartmentNo,
                        @apartmentRentPerMonth,
                        @maxNumberOccupied,
                        @isLivingArea,
                        @livingAreaSqft,
                        @isDiningArea,
                        @diningAreaSqft,
                        @isKitchenArea,
                        @kitchenAreaSqft,
                        @isLaundryArea,
                        @laundryAreaSqft,
                        @isTelephoneService,
                        @isBroadbandInternet,
                        @isCableTv,
                        @isParkingArea,
                        @isGymnasium,
                        @isSwimingPool,
                        @reservationFee,
                        @status
                        )
                        ";

                    cmd.Parameters.Add("@apartmentClassId", SqlDbType.Int).Value = apartmentModel.ApartmentClassId;
                    cmd.Parameters.Add("@apartmentBuildingId", SqlDbType.Int).Value = apartmentModel.ApartmentBuildingId;
                    cmd.Parameters.Add("@apartmentNo", SqlDbType.Int).Value = apartmentModel.ApartmentNo;
                    cmd.Parameters.Add("@apartmentRentPerMonth", SqlDbType.Decimal).Value = apartmentModel.ApartmentRentPerMonth;
                    cmd.Parameters.Add("@maxNumberOccupied", SqlDbType.Int).Value = apartmentModel.MaxNumberOccupied;
                    cmd.Parameters.Add("@isLivingArea", SqlDbType.Bit).Value = apartmentModel.IsLivingArea;
                    cmd.Parameters.Add("@livingAreaSqft", SqlDbType.Decimal).Value = apartmentModel.LivingAreaSqft;
                    cmd.Parameters.Add("@isDiningArea", SqlDbType.Bit).Value = apartmentModel.IsDiningArea;
                    cmd.Parameters.Add("@diningAreaSqft", SqlDbType.Decimal).Value = apartmentModel.DiningAreaSqft;
                    cmd.Parameters.Add("@isKitchenArea", SqlDbType.Bit).Value = apartmentModel.IsKitchenArea;
                    cmd.Parameters.Add("@kitchenAreaSqft", SqlDbType.Decimal).Value = apartmentModel.KitchenAreaSqft;
                    cmd.Parameters.Add("@isLaundryArea", SqlDbType.Bit).Value = apartmentModel.IsLaundryArea;
                    cmd.Parameters.Add("@laundryAreaSqft", SqlDbType.Decimal).Value = apartmentModel.LaundryAreaSqft;
                    cmd.Parameters.Add("@isTelephoneService", SqlDbType.Bit).Value = apartmentModel.IsTelephoneService;
                    cmd.Parameters.Add("@isBroadbandInternet", SqlDbType.Bit).Value = apartmentModel.IsBroadbandInternet;
                    cmd.Parameters.Add("@isCableTv", SqlDbType.Bit).Value = apartmentModel.IsCableTv;
                    cmd.Parameters.Add("@isParkingArea", SqlDbType.Bit).Value = apartmentModel.IsParkingArea;
                    cmd.Parameters.Add("@isGymnasium", SqlDbType.Bit).Value = apartmentModel.IsGymnasium;
                    cmd.Parameters.Add("@isSwimingPool", SqlDbType.Bit).Value = apartmentModel.IsSwimingPool;
                    cmd.Parameters.Add("@reservationFee", SqlDbType.Decimal).Value = apartmentModel.ReservationFee;

                    cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = apartmentModel.Status;


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
                    cmd.CommandText = @"delete from  TBL_APARTMENT where apartmentId=@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
        }

        public IEnumerable<ApartmentModel> GetAll()
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
                                IsTelephoneService = Convert.ToBoolean(reader["isTelephoneService"]),
                                IsBroadbandInternet = Convert.ToBoolean(reader["isBroadbandInternet"]),
                                IsCableTv = Convert.ToBoolean(reader["isCableTv"]),
                                IsParkingArea = Convert.ToBoolean(reader["isParkingArea"]),
                                IsGymnasium = Convert.ToBoolean(reader["isGymnasium"]),
                                IsSwimingPool = Convert.ToBoolean(reader["isSwimingPool"]),
                                ReservationFee = Convert.ToDecimal(reader["reservationFee"]),

                                Status = reader["status"].ToString(),

                            };

                            apartments.Add(apartmentModel);
                        }
                    }

                }

            }
            return apartments;
        }

        public IEnumerable<ApartmentModel> GetByValue(string value)
        {
            var apartment = new List<ApartmentModel>();
            int apartmentId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string apartmentName = (string)value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"Select * from TBL_APARTMENT where apartmentId=@id or apartmentNo like @name +'%' order by apartmentId desc";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = apartmentId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = apartmentName;
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
                                IsTelephoneService = Convert.ToBoolean(reader["isTelephoneService"]),
                                IsBroadbandInternet = Convert.ToBoolean(reader["isBroadbandInternet"]),
                                IsCableTv = Convert.ToBoolean(reader["isCableTv"]),
                                IsParkingArea = Convert.ToBoolean(reader["isParkingArea"]),
                                IsGymnasium = Convert.ToBoolean(reader["isGymnasium"]),
                                IsSwimingPool = Convert.ToBoolean(reader["isSwimingPool"]),
                                ReservationFee = Convert.ToDecimal(reader["reservationFee"]),
                                Status = reader["status"].ToString(),

                            };


                            apartment.Add(apartmentModel);
                        }
                    }

                }

            }
            return apartment;
        }

        public void Update(ApartmentModel apartmentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                MessageBox.Show(apartmentModel.Status);
                using (var cmd = new SqlCommand())
                {

                    connection.Open();
                    cmd.Connection = connection;


                    cmd.CommandText = @"
                    UPDATE TBL_APARTMENT 
                    SET 
                        apartmentClassId = @apartmentClassId,
                        apartmentBuildingId = @apartmentBuildingId,
                        apartmentNo = @apartmentNo,
                        apartmentRentPerMonth = @apartmentRentPerMonth,
                        maxNumberOccupied = @maxNumberOccupied,
                        isLivingArea = @isLivingArea,
                        livingAreaSqft = @livingAreaSqft,
                        isDiningArea = @isDiningArea,
                        diningAreaSqft = @diningAreaSqft,
                        isKitchenArea = @isKitchenArea,
                        kitchenAreaSqft = @kitchenAreaSqft,
                        isLaundryArea = @isLaundryArea,
                        laundryAreaSqft = @laundryAreaSqft,
                        isTelephoneService = @isTelephoneService,
                        isBroadbandInternet = @isBroadbandInternet,
                        isCableTv = @isCableTv,
                        isParkingArea = @isParkingArea,
                        isGymnasium = @isGymnasium,
                        isSwimingPool = @isSwimingPool,
                        reservationFee = @reservationFee,
                        status = @status
                        
                    WHERE apartmentId=@id
                        ";

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = apartmentModel.ApartmentId;
                    cmd.Parameters.Add("@apartmentClassId", SqlDbType.Int).Value = apartmentModel.ApartmentClassId;
                    cmd.Parameters.Add("@apartmentBuildingId", SqlDbType.Int).Value = apartmentModel.ApartmentBuildingId;
                    cmd.Parameters.Add("@apartmentNo", SqlDbType.Int).Value = apartmentModel.ApartmentNo;
                    cmd.Parameters.Add("@apartmentRentPerMonth", SqlDbType.Decimal).Value = apartmentModel.ApartmentRentPerMonth;
                    cmd.Parameters.Add("@maxNumberOccupied", SqlDbType.Int).Value = apartmentModel.MaxNumberOccupied;
                    cmd.Parameters.Add("@isLivingArea", SqlDbType.Bit).Value = apartmentModel.IsLivingArea;
                    cmd.Parameters.Add("@livingAreaSqft", SqlDbType.Decimal).Value = apartmentModel.LivingAreaSqft;
                    cmd.Parameters.Add("@isDiningArea", SqlDbType.Bit).Value = apartmentModel.IsDiningArea;
                    cmd.Parameters.Add("@diningAreaSqft", SqlDbType.Decimal).Value = apartmentModel.DiningAreaSqft;
                    cmd.Parameters.Add("@isKitchenArea", SqlDbType.Bit).Value = apartmentModel.IsKitchenArea;
                    cmd.Parameters.Add("@kitchenAreaSqft", SqlDbType.Decimal).Value = apartmentModel.KitchenAreaSqft;
                    cmd.Parameters.Add("@isLaundryArea", SqlDbType.Bit).Value = apartmentModel.IsLaundryArea;
                    cmd.Parameters.Add("@laundryAreaSqft", SqlDbType.Decimal).Value = apartmentModel.LaundryAreaSqft;
                    cmd.Parameters.Add("@isTelephoneService", SqlDbType.Bit).Value = apartmentModel.IsTelephoneService;
                    cmd.Parameters.Add("@isBroadbandInternet", SqlDbType.Bit).Value = apartmentModel.IsBroadbandInternet;
                    cmd.Parameters.Add("@isCableTv", SqlDbType.Bit).Value = apartmentModel.IsCableTv;
                    cmd.Parameters.Add("@isParkingArea", SqlDbType.Bit).Value = apartmentModel.IsParkingArea;
                    cmd.Parameters.Add("@isGymnasium", SqlDbType.Bit).Value = apartmentModel.IsGymnasium;
                    cmd.Parameters.Add("@isSwimingPool", SqlDbType.Bit).Value = apartmentModel.IsSwimingPool;
                    cmd.Parameters.Add("@reservationFee", SqlDbType.Decimal).Value = apartmentModel.ReservationFee;

                    cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = apartmentModel.Status;


                    cmd.ExecuteNonQuery();

                }

            }
        }
    }
}
