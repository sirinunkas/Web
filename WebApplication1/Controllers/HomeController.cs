using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            // เรียกค่าจาก DB มาเก็บไว้ที่ตัวแปร "a"
            TEST_SK dbcontext = new TEST_SK();

           // var dblist = dbcontext.Users.ToList();

        
            return View();
        }

        //[HttpPost]
        //public JsonResult setData(ParameterAccounts cc)
        //{
        //    var a = cc;
        //    return Json(new { status = true });
        //}

        [HttpGet]
        public JsonResult GetData()
        {

            TEST_SK dbcontext = new TEST_SK();
            var dblist = dbcontext.Users.ToList();

            TableTest data = new TableTest()
            {
                data = dblist
            };
            
            return Json(data, JsonRequestBehavior.AllowGet);


        }




        [HttpPost]
        public JsonResult InsertData(Parameteruser users)
        {

            TEST_SK dbcontext = new TEST_SK();
            var dbinsert = new Users();
          

            dbcontext.Users.Add(new Users
            {
                firstname = users.firstname,
                lastname = users.lastname,
                email = users.email,
                phone = users.phone,


            });

            dbcontext.SaveChanges();

      

            return Json(new { status = "Insert success !!" });
        }

        public JsonResult UpdateData(int id)
        {
            TEST_SK dbcontext = new TEST_SK();
            Users dbupdate = dbcontext.Users.FirstOrDefault(r => r.ID == id);

            dbupdate.ID = id;
            dbcontext.Users.Add(dbupdate);


            return Json(new { status = "Update success !!" });
        }

        [HttpPost]
        public JsonResult DeleteData(int id)
        {
            TEST_SK dbcontext = new TEST_SK();
            Users dbdelete = dbcontext.Users.FirstOrDefault(r => r.ID == id);
         
            dbcontext.Users.Remove(dbdelete);
            dbcontext.SaveChanges();

            return Json(new { status = "Delete success !!" });
        }





    }
}