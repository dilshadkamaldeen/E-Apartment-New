using E_Apartment.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartment.Models
{
    public class Dashboard :DbConnection
    {
        //Fields & Propoerties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumBuildings { get; private set; }
        public int NumParkingSpaces { get; private set; }
        public List<KeyValuePair<string, int>> TopBuildingsList { get; private set; }


        public Dashboard() { }

        //private methods
        private void GetNumBuildings()
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get total number of buildings
                    command.CommandText = @"select count(*) from TBL_BUILDINGS"; //return only 1row and 1 column
                    NumBuildings = (int)command.ExecuteScalar(); //ExecuteScalar is return 1st row and column

                    //Get total number of NumParkingSpaces
                    command.CommandText = @"select count(*) from TBL_PARKING_SPACE"; //return only 1row and 1 column
                    NumParkingSpaces = (int)command.ExecuteScalar(); //ExecuteScalar is return 1st row and column

                }
            }
        }

    }
}
