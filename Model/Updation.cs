using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Updation
    {
        public static void updateUser(int id,string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("User Updated", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void updateCategory(int id,string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Category Updated", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void updateProduct(int prodID,string name, string barcode,int catID, DateTime? date=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@barcode", barcode);               
                if (date == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", date);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@prodID", prodID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Product Updated", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void updateSupplier(int supID,string supplierName, string contactPerson, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@supplierName", supplierName);
                cmd.Parameters.AddWithValue("@contactPerson", contactPerson);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@sup_id", supID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Supplier Updated", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void updateStock(int proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }

        public static void updateStockWithoutconn(int proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }

        public static void updateProductPrice(int prodID, float buyingPrice, float sellingPrice = 0, float discount = 0, float profitPercentage = 0)
        {
            try
            {
                SqlCommand cmd;
                if (sellingPrice == 0 && discount == 0 && profitPercentage == 0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@buyprice", buyingPrice);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@buyprice", buyingPrice);
                    cmd.Parameters.AddWithValue("@sellprice", sellingPrice);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@profit_Percentage", profitPercentage);
                }
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void updateQuantityInSalesDetails(int salesID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateQuantityInSalesDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }
    }
}
