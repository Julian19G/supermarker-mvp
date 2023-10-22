using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {
        public ProvidersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProvidersModel providersModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProvidersModel providersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providersList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Providers_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.IdProvider = (int)reader["Providers_ID"];
                        providersModel.NameProvider = reader["Providers_Name"].ToString();
                        providersModel.ObservationProvider = reader["Providers_Observation"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersList = new List<ProvidersModel>();
            int providersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers
                                      WHERE Providers_Id=@id or Providers_Name LIKE @name+ '%'
                                      ORDER By Providers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.IdProvider = (int)reader["Providers_Id"];
                        providersModel.NameProvider = reader["Providers_Name"].ToString();
                        providersModel.ObservationProvider = reader["Providers_Observation"].ToString();
                        providersModel.Add(providersModel);
                    }
                }
            }
            return providersList;
        }
    }
}
