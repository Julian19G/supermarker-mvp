﻿using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string  connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetAll()
        {
           var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PayModeModel = new PayModeModel();
                        PayModeModel.Id = (int)reader["Pay_Mode_Id"];
                        PayModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        PayModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(PayModeModel);
                    }
                }
            }
            return payModeList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value,out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;
            using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode
                                      WHERE Pay_Mode_Id=@id or Pay_Mode_Name LIKE @name+ '%'
                                      ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@id",SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name",SqlDbType.NVarChar).Value = payModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PayModeModel = new PayModeModel();
                        PayModeModel.Id = (int)reader["Pay_Mode_Id"];
                        PayModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        PayModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(PayModeModel);
                    }
                }
            }
            return payModeList;
        }
    }
}