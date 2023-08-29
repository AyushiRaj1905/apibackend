using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Mob_APP.Models;
using MySql.Data.MySqlClient;

namespace Mob_APP.AppCode
{
    public class DataAccess
    {

        public List<FetchConfData> FetchRoomData()

        {



            List<FetchConfData> lstFetchRoomData = new List<FetchConfData>();
            string myConnectionString = "Server= localhost; database=scheemabooking;uid=root;pWd=Ayushi@6299";


            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string strcommmandtext = "SELECT * FROM scheemabooking.booking table;";
                MySqlCommand comm = new MySqlCommand(strcommmandtext, conn);
                //   MySqlDataReader dataReader = comm.ExecuteReader();

                DataTable dat = new DataTable();

                dat.Load(comm.ExecuteReader());



                if (dat.Rows.Count > 0)



                {

                    for (int i = 0; i < dat.Rows.Count; i++)

                    {

                        FetchConfData objFetchRoomData = new FetchConfData();

                        objFetchRoomData.booking_date = Convert.ToString(dat.Rows[i]["Booking Date"]);

                        //objFetchRoomData = Convert.ToString(dat.Rows[i]["Booking Day"]);

                        objFetchRoomData.Booking_To = Convert.ToString(dat.Rows[i]["Booking To"]);

                        objFetchRoomData.Booking_Form = Convert.ToString(dat.Rows[i]["Booking From"]);

                        objFetchRoomData.Booking_Period = Convert.ToString(dat.Rows[i]["Booking Period"]);

                        objFetchRoomData.Booking_Purpose = Convert.ToString(dat.Rows[i]["Booking Purpose"]);

                        objFetchRoomData.Booking_Details = Convert.ToString(dat.Rows[i]["Booking Details"]);

                        objFetchRoomData.Participants_Count = Convert.ToString(dat.Rows[i]["Participants Count"]);
                        objFetchRoomData.Booking_Id = Convert.ToString(dat.Rows[i]["Booking_ID"]);





                        lstFetchRoomData.Add(objFetchRoomData);

                    }



                }

                return lstFetchRoomData;



            }
            catch (MySqlException ex)
            {
                //   MessageBox.Show(ex.Message);
            }










            return lstFetchRoomData;

        }



    }
}