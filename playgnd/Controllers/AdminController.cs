using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using playgnd.Models.DataBase;
using playgnd.Models.DataBase.TestDB;
using playgnd.Models.Test;

namespace playgnd.Controllers
{
    public class AdminController : Controller
    {
        [Route("admin/addtest")]
        [HttpPost]
        public async Task<string> TestControl([FromForm] AddPost post)
        {
            using (var db = new DbConnection())
            {
                await db.Connection.OpenAsync();
                var query = new TestDBWorker(db);
                await query.AddTest(post.subject, post.name, post.questionsInTest, post.questionsAll, post.resultOfQuestion, post.mixAnswers, post.mixQuestions, post.notAnsweredForbidden, post.json);
                return "added";
            }
        }
        [Route("admin/test/new")]
        public IActionResult ReturnSubjects(string subj)
        {
           return View("TestControl",subj);
        }
        [Route("admin/test/list")]
        public async Task<IActionResult> ReturnSubjList()
        {
            using (var db = new DbConnection())
            {
                await db.Connection.OpenAsync();
                var query = new TestDBWorker(db);
                List<string> subj = await query.GetSubjects();
                return View("TestSubjList",subj);
            }
        }
    }
}