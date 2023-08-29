
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using System.Web.Http;
using Mob_APP.AppCode;

namespace Mob_APP.Controllers
{


    public class QueryBookingController : ApiController
    {
        // GET: QueryBooking
        //public ActionResult Index()
        //{
        //    return View();
        //}





        [HttpGet]
        [Route("api/FetchRoomData")]
        public List<FetchConfData> FetchBooking()
        {


            List<FetchConfData> lstFectchRoomData = new List<FetchConfData>();
            try
            {


                DataAccess _da = new DataAccess();
                lstFectchRoomData = _da.FetchRoomData();

            }

            catch (Exception ex)

            {



            }

            return lstFectchRoomData;





        }







    }


}