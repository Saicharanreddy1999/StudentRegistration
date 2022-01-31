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
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Details db)
        {
            


                db = new Details();
                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string sql = "insert into [dbo].[Student](Id,FirstName,LastName,Email,Gender,UniversityName,CollegeName,Course) values('18J41A0548','SAi','chat','xyz','m','abc','ded','dua')";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
           
               // sqlConn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error");
            }
                sqlConn.Close();
           
            


            return Content("Succesfully Added");
   
        }
    }
}