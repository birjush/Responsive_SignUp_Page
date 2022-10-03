using ins_fetch_entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ins_fetch_entity.Controllers
{
    public class employeeController : Controller
    {
        DBEmployeeEntities context = new DBEmployeeEntities();

        [HttpGet]
        public ActionResult GetAllEmployees()
        {
            List<TBLEmployee> employees = context.TBLEmployees.ToList();
            return View("ShowEmp", employees);
        }

        public ActionResult InsertPage()
            {
                return View("insert");
            }

        [HttpPost]
        public ActionResult InsertData(TBLEmployee e)
        {
            context.TBLEmployees.Add(e);
            context.SaveChanges();
            return RedirectToAction("GetAllEmployees");
        }

        public ActionResult deleterecord(string delete)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BIRJU\source\repos\ins_fetch_entity\ins_fetch_entity\App_Data\DBEmployee.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework";
            SqlCommand command = new SqlCommand();
            string d = delete;
            command.CommandText = $"DELETE FROM TBLEmployee WHERE name='{d}'";
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            

            return RedirectToAction("GetALLEmployees");
        }
    }
}