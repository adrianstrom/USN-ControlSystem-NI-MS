using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace USN_DataLogging.DataTypes
{
    public class SqlHandler
    {
        private string _connectionString;
        public SqlHandler(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<string> GetSqlOpcItems()
        {
            var itemIds = new List<string>();
            using (var con = new SqlConnection(_connectionString))
            {
                var query = "SELECT ItemId FROM TAG";
                var cmd = new SqlCommand(query, con);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemId = reader["ItemId"].ToString();
                        itemIds.Add(itemId);
                    }
                    con.Close();
                }
            }
            return itemIds;
        }

        public void SaveTagMeasurement(TagMeasurement tagMeasurement)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SaveTagMeasurement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TagId", tagMeasurement.TagId));
                cmd.Parameters.Add(new SqlParameter("@Value", tagMeasurement.Value));
                cmd.Parameters.Add(new SqlParameter("@Quality", tagMeasurement.Quality.ToString()));
                cmd.Parameters.Add(new SqlParameter("@Unit", tagMeasurement.Unit));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //public void GetTriggeredAlarms()
        //{
        //    var itemIds = new List<string>();
        //    using (var con = new SqlConnection(_connectionString))
        //    {
        //        var query = "SELECT ItemId FROM TAG";
        //        var cmd = new SqlCommand(query, con);
        //        con.Open();
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var itemId = reader["ItemId"].ToString();
        //                itemIds.Add(itemId);
        //            }
        //            con.Close();
        //        }
        //    }
        //    return itemIds;
        //}


        //public void InsertAlarm()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(_connectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand("CreateBook", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
        //            cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
        //            cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
        //            cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
        //            cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void InsertMeasurementData()
        {

        }
    }
}
