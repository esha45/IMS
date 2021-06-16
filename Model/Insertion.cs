using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Transactions;

namespace IMS
{
    class Insertion
    {
        private static Int64 PurchaseInvoiceID;
        private static int pidcount;
        private static int salesCount,salesID;
        static int numberOfRows = 0;

        public static void insertUser(string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("User Added", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Category Added", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void insertProduct(string name, string barcode,int catID, DateTime? date = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", MainClass.con);
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
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Product Added", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void insertSupplier(string supplierName, string contactPerson, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
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
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMsg("Supplier Added", "Success", "Success");
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static Int64 insertPurchaseInvoice(DateTime date, int doneBy, int suppID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                PurchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return PurchaseInvoiceID;
        }

        public static int insertPurchaseInvoiceDetails(Int64 purchaseID, int prodID, int quantity, float totalPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
                cmd.Parameters.AddWithValue("@prodID", prodID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                MainClass.con.Open();
                pidcount = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return pidcount;
        }

        public static void insertStock(int proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public static void insertDeletedItem(Int64 pid, int proid, int quan, int userid, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemsPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@usrID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMsg(ex.Message, "Error...", "Error");
            }
        }

        public static void insertProductPrice(int prodID,float buyprice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prodID", prodID);
                cmd.Parameters.AddWithValue("@buyprice", buyprice);
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

        public static void insertSales(DataGridView gv,String proIDGV,String prodQuantityGV,int doneBy,DateTime date, float totalAmount, float totalDiscount, float amountGiven, float amountReturn, string paymentType,string PerUnitPriceGV,string DiscountGV)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@totalDiscount", totalDiscount);
                    cmd.Parameters.AddWithValue("@amountGiven", amountGiven);
                    cmd.Parameters.AddWithValue("@amountReturn", amountReturn);
                    if (paymentType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 0);
                    }
                    else if (paymentType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 1);
                    }
                    else if (paymentType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 2);
                    }
                    MainClass.con.Open();
                    salesCount = cmd.ExecuteNonQuery();
                    if (salesCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt32(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@prodID", Convert.ToInt32(row.Cells[proIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[prodQuantityGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellingPrice", Convert.ToSingle(row.Cells[PerUnitPriceGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[DiscountGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int productStock = Convert.ToInt32(Selection.getProductQuantityWithoutConn(Convert.ToInt32(row.Cells[proIDGV].Value.ToString())));
                            int currentQuanofProd = Convert.ToInt32(row.Cells[prodQuantityGV].Value.ToString());
                            int finalQuanofProd = productStock - currentQuanofProd;
                            Updation.updateStockWithoutconn(Convert.ToInt32(row.Cells[proIDGV].Value.ToString()), finalQuanofProd);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.showMsg("Sales Submitted Successfully", "Success", "Success");
                    sc.Complete();
                }
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static int insertRefund(int salesID, DateTime date, int doneBy, int prodID, Int16 quantity, float amount)
        {        
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRefund", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@prodID", prodID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@amount", amount);
                MainClass.con.Open(); 
                numberOfRows = cmd.ExecuteNonQuery();
                MainClass.con.Close(); 
            }
            catch (Exception ex)
            {               
                MainClass.con.Close();
                MainClass.showMsg(ex.Message, "Error", "Errror");
            }
            return numberOfRows;
        }
    }
}
