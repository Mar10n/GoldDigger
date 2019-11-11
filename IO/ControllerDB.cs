using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace IO
{
    /// <summary>
    /// Denne klasse indeholder metoder som Finder, Indsætter, Opdatere og sletter ting i DB.
    /// Af Martin
    /// </summary>
    public class ControllerDB : ClassDbCon
    {
        public ControllerDB(string con)
        {

        }

        //Finder alle Customers i DB.
        public List<Customer> GetAllCustomers()
        {
            List<Customer> listRes = new List<Customer>();
            string strSql = "SELECT * FROM Customer";

            DataTable DT = DbReturnDataTable(strSql);

            foreach (DataRow row in DT.Rows)
            {
                 Customer CC = new Customer();
                CC.Id = Convert.ToInt32(row["id"]);
                CC.Name = row["name"].ToString();
                CC.Address = row["address"].ToString();
                CC.ZipCity = row["zipCity"].ToString();
                CC.Country = row["country"].ToString();
                CC.Phone = row["phone"].ToString();
                CC.MailAdr = row["mail"].ToString();
                CC.MemberKey = row["memberKey"].ToString();
                CC.MemberDate = Convert.ToDateTime(row["memberDate"]);
                
                listRes.Add(CC);
            }
            return listRes;
        }

        public void InsertNewCustomer(Customer inCustomer)
        {
            int customerID = 0;
            string sqlStr = "INSERT INTO Customer (name, address, zipCity, country, phone, mail, memberKey, memberDate) " +
                "OUTPUT inserted.id" +
                "VALUES ( @name, @address, @zipCity, @country, @phone, @mail, @memberKey, @memberDate) ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlStr, con))
                {
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = inCustomer.Name;
                    cmd.Parameters.Add("@address", System.Data.SqlDbType.Int).Value = inCustomer.Address;
                    cmd.Parameters.Add("@zipCity", System.Data.SqlDbType.Int).Value = inCustomer.ZipCity;
                    cmd.Parameters.Add("@country", System.Data.SqlDbType.Int).Value = inCustomer.Country;
                    cmd.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = inCustomer.Phone;
                    cmd.Parameters.Add("@mail", System.Data.SqlDbType.Int).Value = inCustomer.MailAdr;
                    cmd.Parameters.Add("@memberKey", System.Data.SqlDbType.Int).Value = inCustomer.MemberKey;
                    cmd.Parameters.Add("@memberDate", System.Data.SqlDbType.Int).Value = inCustomer.MemberDate;

                    OpenDB();
                    customerID = cmd.ExecuteNonQuery();
                    CloseDB();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //Opdatere alle Customers i DB.
        public void UpdateCustomer(Customer inCustomer)
        {
            string strSqlCustomer = $"UPDATE Customer SET  = name '{inCustomer.Name}', " +
                                                             $"address = '{inCustomer.Address}', " +
                                                             $"zipCity = {inCustomer.ZipCity}, " +
                                                             $"country = {inCustomer.Country}, " +
                                                             $"phone = {inCustomer.Phone} " +
                                                             $"mail = {inCustomer.MailAdr} " +
                                                             $"memberKey = {inCustomer.MemberKey} " +
                                                             $"memberDate = {inCustomer.MemberDate} " +
                                                             $"WHERE id = {inCustomer.Id}";
            ExecuteNonQuery(strSqlCustomer);
        }

        //
        public void RemoveCustomer(Customer outCustomer)
        {
            int customerID = 0;
            string strSql = "DELETE * FROM Customer ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(strSql, con))
                {
                    cmd.Parameters.AddWithValue("@id", System.Data.SqlDbType.NVarChar).Value = outCustomer.Id;

                    OpenDB();
                    customerID = cmd.ExecuteNonQuery();
                    CloseDB();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}