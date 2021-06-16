using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    class Selection
    {
        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        private static string[] productData = new string[6];
        private static object productStockCount = 0;
        private static ReportDocument rd;
        private static object[] productPriceDetails = new object[5];

        public static void showUsers(DataGridView gv, DataGridViewColumn UserIDGGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PasswordGV, DataGridViewColumn EmailGV, DataGridViewColumn PhoneNoGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_showUsers", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchUsers", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserIDGGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UserNameGV.DataPropertyName = dt.Columns["User Name"].ToString();
                PasswordGV.DataPropertyName = dt.Columns["Password"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                PhoneNoGV.DataPropertyName = dt.Columns["Phone"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void showCategories(DataGridView gv, DataGridViewColumn CategoryIDGGV, DataGridViewColumn CategoryNameGV, DataGridViewColumn StatusGV, String data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchCategories", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CategoryIDGGV.DataPropertyName = dt.Columns["ID"].ToString();
                CategoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void showProducts(DataGridView gv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn expDateGV,DataGridViewColumn prodBarcodeGV, DataGridViewColumn catNameGV, DataGridViewColumn catIDGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_showProducts", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchProducts", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                expDateGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                prodBarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static int userID
        {
            get;
            private set;
        }

        public static string name
        {
            get;
            private set;
        }

        public static bool getLoginDetails(string username, string passwrord)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLoginDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", passwrord);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        userID = Convert.ToInt32(dr["ID"].ToString());
                        name = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && passwrord != null)
                    {
                        if (user_name != username && pass_word == passwrord)
                        {
                            MainClass.showMsg("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != passwrord)
                        {
                            MainClass.showMsg("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != passwrord)
                        {
                            MainClass.showMsg("Invalid Username & Password", "Error", "Error");
                        }
                    }
                }

                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return checkLogin;
        }

        public static void showSupplier(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn suppNameGV, DataGridViewColumn contactPersonGV, DataGridViewColumn phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn ntnGV, DataGridViewColumn addressGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchSupplier", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                suppNameGV.DataPropertyName = dt.Columns["Supplier"].ToString();
                contactPersonGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                Phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static string[] getProductByBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString(); //Product ID
                        productData[1] = dr[1].ToString(); //Product Name
                        productData[2] = dr[2].ToString(); //Barcode
                        productData[3] = dr[3].ToString(); //Selling Price
                        productData[4] = dr[4].ToString(); //Discount
                        productData[5] = dr[5].ToString(); //Final Selling Price
                    }
                }
                else
                {                   
                    Array.Clear(productData, 0, productData.Length);
                    MainClass.showMsg("No Product Available", "Error", "Error");
                }
                MainClass.con.Close();
            }


            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return productData;
        }

        public static string[] getProductByBarcodePI(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcodePI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString(); //Product ID
                        productData[1] = dr[1].ToString(); //Product Name
                        productData[2] = dr[2].ToString(); //Barcode
                    }
                }
                else
                {
                    Array.Clear(productData, 0, productData.Length);
                    MainClass.showMsg("No Product Available", "Error", "Error");
                }
                MainClass.con.Close();
            }


            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return productData;
        }

        public static object getProductQuantity(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("proID", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return productStockCount;
        }

        public static object getProductQuantityWithoutConn(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("proID", proID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
            return productStockCount;
        }

        public static void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDgv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quanGV, DataGridViewColumn pupriceGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDgv.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                pupriceGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMsg("Unable to load Categories data", "Error", "Error");
            }
        }

        public static void showStockDetails(DataGridView gv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn QuantityGV, DataGridViewColumn BarcodeGV, DataGridViewColumn ExpiryGV, DataGridViewColumn BuyingPriceGV, DataGridViewColumn SellingPriceGV, DataGridViewColumn CategoryGV, DataGridViewColumn TotalAmountGV, DataGridViewColumn StatusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getALLStock", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                BarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                ExpiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                BuyingPriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                SellingPriceGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                CategoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                QuantityGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                TotalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMsg("Unable to load stock data", "Error", "Error");
            }
        }

        public static void showProductsWRTCategory(int catID, DataGridView gv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn buyingPriceGV, DataGridViewColumn ProfitMarginGV, DataGridViewColumn DiscountGV, DataGridViewColumn FinalSellingPriceGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                FinalSellingPriceGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                DiscountGV.DataPropertyName = dt.Columns["Discount"].ToString();
                ProfitMarginGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMsg("Unable to load products data", "Error", "Error");
            }
        }

        public static object[] checkProductPriceExistance(int prodID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductPriceExist", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prodID", prodID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productPriceDetails[0] = dr[0].ToString();
                        productPriceDetails[1] = dr[1].ToString();
                        productPriceDetails[2] = dr[2].ToString();
                        productPriceDetails[3] = dr[3].ToString();
                        productPriceDetails[4] = dr[4].ToString();
                    }
                }
                else
                {
                    Array.Clear(productPriceDetails, 0, productPriceDetails.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return productPriceDetails;
        }      

        public static void showReport(String reportName,ReportDocument rd,CrystalReportViewer crv,String proc,string parameter=null,object value=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                if(parameter!=null && value != null)
                {
                    cmd.Parameters.AddWithValue(parameter, value);
                }
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                rd.Load(Application.StartupPath + "\\Reports\\"+ reportName);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch(Exception e)
            {
                MainClass.showMsg(e.Message,"Error","Error");
            }
        }

        public static void showDailySales(DateTime date, DataGridView gv, DataGridViewColumn SalesIDGV, DataGridViewColumn UserGV, DataGridViewColumn TotalAmountGV, DataGridViewColumn TotalDiscountGV, DataGridViewColumn AmountGivenGV, DataGridViewColumn ReturnedAmountGV, DataGridViewColumn UserIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SalesIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                UserGV.DataPropertyName = dt.Columns["User"].ToString();
                TotalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                TotalDiscountGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                AmountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                ReturnedAmountGV.DataPropertyName = dt.Columns["Returned Amount"].ToString();
                UserIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }

        public static void showSalesReturn(int salesID,DataGridView gv, DataGridViewColumn SalesIDGV, DataGridViewColumn ProdIDGV, DataGridViewColumn BarcodeGV, DataGridViewColumn ProductNameGV, DataGridViewColumn QuantityGV, DataGridViewColumn TotalDiscountGV, DataGridViewColumn TotalAmountGV, DataGridViewColumn AmountGivenGV, DataGridViewColumn ReturnedAmountGV, DataGridViewColumn DateGV, DataGridViewColumn ProductPriceGV, DataGridViewColumn PerProductDiscountGV, DataGridViewColumn PerProductTotalGV, DataGridViewColumn UserNameGV, DataGridViewColumn PaymentTypeGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[st_getSalesReceiptWRTSalesID]", MainClass.con);                                                     
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SalesIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                ProdIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                BarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                ProductNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                QuantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                TotalDiscountGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                TotalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                AmountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                ReturnedAmountGV.DataPropertyName = dt.Columns["Amount Returned"].ToString();
                DateGV.DataPropertyName = dt.Columns["Date"].ToString();
                ProductPriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                PerProductDiscountGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                PerProductTotalGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                UserNameGV.DataPropertyName = dt.Columns["User"].ToString();
                PaymentTypeGV.DataPropertyName = dt.Columns["Payment Type"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }
        }
    }
}
