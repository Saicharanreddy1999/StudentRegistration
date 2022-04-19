using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistration.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Details db)
        {

            //db = new Details();

           
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            
          
            string sql = $"insert into [dbo].[Student](Id,FirstName,LastName,Email,Gender,UniversityName,CollegeName,Course) values('{db.Id}','{db.FirstName}','{db.LastName}','{db.Email}','{db.Gender}','{db.UniversityName}','{db.CollegeName}','{db.Course}')";
          
            SqlCommand cmd = new SqlCommand(sql, sqlConn);   
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Content("Succesfully Added");
           
                sqlConn.Close();
           
            


          
   
        }
    }
}