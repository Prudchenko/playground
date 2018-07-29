using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using playgnd.Models.DataBase;
using playgnd.Models.DataBase.TestDB;

namespace playgnd.Controllers
{
    public class TestsController : Controller
    {
        [Route("/tests/live")]
        public async Task<IActionResult> Index(string id)
        {
            List<string> model = new List<string>();
            using (var db = new DbConnection())
            {
                await db.Connection.OpenAsync();
                var query = new TestDBWorker(db);
                model = await query.GetTest(id);
            }
            return View("DemoTest",model);
        }
        [Route("/tests/list")]
        public async Task<IActionResult> TestingList(string id)
        {
            List<string> model = new List<string>();
            using (var db = new DbConnection())
            {
                await db.Connection.OpenAsync();
                var query = new TestDBWorker(db);
                model = await query.GetTestList();
            }
            return View("TestList", model);
        }
        [Route("/tests/get")]
        public async Task<string> TestingGet(string id)
        {
            List<string> model = new List<string>();
            using (var db = new DbConnection())
            {
                await db.Connection.OpenAsync();
                var query = new TestDBWorker(db);
                model = await query.GetTest(id);
            }
            return model[9];
        }
    }
}