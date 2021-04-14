using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace homework003
{
    public class ConnectDB
    {
        #region 查詢無人機資料表的Method
        public static DataTable ReadDroneDetail()
        {
            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Destination;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@NumberCol", "2");

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}

                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion


        #region 新增無人機資料的Method
        public static void InsertIntoDroneDetail(int Sid, string DroneName, string Manufacturer, string WeightLoad, string Status, string StopReason, string Operator)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"INSERT INTO Drone_Destination
                                        (DroneDetail_ID, DroneName, Manufacturer, WeightLoad, Status, StopReason, operator)
                                    VALUES
                                        (@DroneDetail_ID, @DroneName, @Manufacturer, @WeightLoad, @Status, @StopReason, @operator)";

            //建立一個JS語法的字串,此字串內容為刷新本頁
            string js = "<script language=javascript>window.location.href=window.location.href;</script>";


            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@DroneDetail_ID", Sid);
                command.Parameters.AddWithValue("@DroneName", DroneName);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@WeightLoad", WeightLoad);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@StopReason", StopReason);
                command.Parameters.AddWithValue("@operator", Operator);


                try
                {
                    //開始連線
                    connection.Open();

                    //受影響的資料筆數(沒有使用)
                    int totalChangRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    //刷新頁面
                    HttpContext.Current.Response.Write(js);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
        #endregion


        #region 刪除無人機資料的Method
        public static void DelectDroneDetail(int ID)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"DELETE FROM Drone_Destination WHERE DroneDetail_ID = @ID";
            //DELETE FROM TestTable_1 WHERE ID


            //建立一個JS語法的字串,此字串內容為刷新本頁
            string js = "<script language=javascript>window.location.href=window.location.href;</script>";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@ID", ID);



                try
                {
                    //開始連線
                    connection.Open();

                    //受影響的資料筆數(沒有使用)
                    int totalChangRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("Total chang" + totalChangRows + " Rows.");
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    //刷新頁面
                    HttpContext.Current.Response.Write(js);
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex);
                    //Console.WriteLine(ex);
                }

            }
        }
        #endregion


        #region 修改無人機資料表的Method
        public static void UpDateDroneDetail(int Sid, string DroneName, string Manufacturer, string WeightLoad, string Status, string StopReason, string Operator)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";


            //使用的SQL語法
            string queryString = $@"UPDATE Drone_Destination SET DroneName=@DroneName, Manufacturer=@Manufacturer, WeightLoad=@WeightLoad, Status=@Status, StopReason=@StopReason, operator=@operator WHERE DroneDetail_ID=@DroneDetail_ID";


            //建立一個JS語法的字串,此字串內容為刷新本頁
            string js = "<script language=javascript>window.location.href=window.location.href;</script>";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@DroneDetail_ID", Sid);
                command.Parameters.AddWithValue("@DroneName", DroneName);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@WeightLoad", WeightLoad);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@StopReason", StopReason);
                command.Parameters.AddWithValue("@operator", Operator);


                try
                {
                    //開始連線
                    connection.Open();

                    //受影響的資料筆數(沒有使用)
                    int totalChangRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    //刷新頁面
                    HttpContext.Current.Response.Write(js);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
        #endregion


        #region 查詢單筆無人機資料表的Method
        public static DataTable ReadSingleDroneDetail(int ID)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Destination WHERE DroneDetail_ID=@ID;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}

                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion

    }
}