using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Services
{
    public class VehiclesDAO : IDatabaseEdit
    {

        string connectionString = @"Data Source=DESKTOP-SH5LE6E;Initial Catalog=SampleProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<VehicleModel> GetAllVehicles()
        {

            List<VehicleModel> sqlList = new List<VehicleModel>();
            string sqlStatement = "SELECT * FROM dbo.Vehicles";
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        sqlList.Add(new VehicleModel { Id = (int)reader[0], VehicleBrand = (string)reader[1], ModelName = (string)reader[2], Price = (decimal)reader[3], Description = (string)reader[4] });
                    }
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }


            return sqlList;
        }


        public List<VehicleModel> SearchByBrand(string searchTerm)
        {

            List<VehicleModel> sqlList = new List<VehicleModel>();
            string sqlStatement = "SELECT * FROM dbo.Vehicles WHERE VehicleBrand LIKE @VehicleBrand";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.AddWithValue("@VehicleBrand", '%' + searchTerm + '%');

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sqlList.Add(new VehicleModel { Id = (int)reader[0], VehicleBrand = (string)reader[1], ModelName = (string)reader[2], Price = (decimal)reader[3], Description = (string)reader[4] });
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }

            return sqlList;
        }



        public VehicleModel GetVehicleById(int id)
        {
            VehicleModel vehicle = null;
            string sqlStatement = "SELECT * FROM dbo.Vehicles WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vehicle = new VehicleModel { Id = (int)reader[0], VehicleBrand = (string)reader[1], ModelName = (string)reader[2], Price = (decimal)reader[3], Description = (string)reader[4] };
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }


            return vehicle;
        }



        public int Insert(VehicleModel vehicle)
        {
            List<VehicleModel> sqlProducts = new List<VehicleModel>();
            string sqlStatement = "INSERT INTO dbo.Vehicles (VehicleBrand, ModelName, Price, Description) VALUES (@VehicleBrand, @ModelName, @Price, @Description)";
            int newId = -1;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);

                sqlCommand.Parameters.AddWithValue("@VehicleBrand", vehicle.VehicleBrand);
                sqlCommand.Parameters.AddWithValue("@ModelName", vehicle.ModelName);
                sqlCommand.Parameters.AddWithValue("@Price", vehicle.Price);
                sqlCommand.Parameters.AddWithValue("@Description", vehicle.Description);

                //poprzednia wersja przy ktorej nie dzialal POSTMAN - json
                //sqlCommand.Parameters.Add("@VehicleBrand", System.Data.SqlDbType.VarChar).Value = vehicle.VehicleBrand;
                //sqlCommand.Parameters.Add("@ModelName", System.Data.SqlDbType.VarChar).Value = vehicle.ModelName;
                //sqlCommand.Parameters.Add("@Price", System.Data.SqlDbType.VarChar).Value = vehicle.Price;
                //sqlCommand.Parameters.Add("@Description", System.Data.SqlDbType.VarChar).Value = vehicle.Description;

                try
                {
                    connection.Open();

                    newId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    //newId = sqlCommand.ExecuteNonQuery();   poprzednia wersja

                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            return newId;
        }



        public int Update(VehicleModel vehicle)
        {
            List<VehicleModel> sqlProducts = new List<VehicleModel>();
            string sqlStatement = "UPDATE dbo.Vehicles SET VehicleBrand = @VehicleBrand, ModelName = @ModelName, Price = @Price, Description = @Description WHERE Id = @Id";
            int newId = -1;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);

                sqlCommand.Parameters.AddWithValue("@Id", vehicle.Id);
                sqlCommand.Parameters.AddWithValue("@VehicleBrand", vehicle.VehicleBrand);
                sqlCommand.Parameters.AddWithValue("@ModelName", vehicle.ModelName);
                sqlCommand.Parameters.AddWithValue("@Price", vehicle.Price);
                sqlCommand.Parameters.AddWithValue("@Description", vehicle.Description);


                try
                {
                    connection.Open();
                    newId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            return newId;
        }



        public bool Delete(VehicleModel vehicle)
        {

            List<VehicleModel> sqlProducts = new List<VehicleModel>();
            string sqlStatement = "DELETE FROM dbo.Vehicles WHERE Id = @Id";
            int newId = -1;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);

                sqlCommand.Parameters.AddWithValue("@Id", vehicle.Id);

                try
                {
                    connection.Open();
                    newId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }

            return (newId > 0);
        }



        public List<VehicleModel> VehiclesProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
