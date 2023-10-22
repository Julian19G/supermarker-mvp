using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
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
                command.CommandText = "SELECT * FROM Categories ORDER BY Categories_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.IdProvider = (int)reader["Providers_ID"];
                        providersModel.NameProvider = reader["Categories_Name"].ToString();
                        providersModel.ObservationProvider = reader["Categories_Observation"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
