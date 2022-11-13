using System;
using System.Collections.Generic;
using System.Text;
using AysBooks1.DataAccess.Repository.IRepository;
using AysBookStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;


namespace AysBooks1.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = "";

        public SP_Call(ApplicationDbContext db)
        {
            _db = db
           ConnectionString = db.Database.GetDbConnection() ConnectionString;

        }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Execute(string procedurename, DynamicParameters param = null);
        {
        using (SqlCoonnection sqlCon = new SqlConnection(ConnectionString))
        {
          sqlCon.Open();
            sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
        }
        }

    }
}
