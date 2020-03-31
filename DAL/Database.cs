using System;
using Npgsql;
using Microsoft.AspNetCore.Mvc;
namespace core_auth.Database
{
    public class Database
    {
        public static void Connect()
        {

            var cs = "Host=localhost;Username=temp;Password=temp;Database=tempdb";
            //var c = Configuration.GetSection("DatabaseConfig")["PostgresSQL"]);
            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
        }
    }
}

