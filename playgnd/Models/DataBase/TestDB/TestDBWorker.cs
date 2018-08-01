using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using playgnd.Models.Admin.Test;

namespace playgnd.Models.DataBase.TestDB
{
    public class TestDBWorker
    {
        public readonly DbConnection Db;
        public TestDBWorker(DbConnection db)
        {
            Db = db;
        }

        // add new test to database
        public async Task AddTest(string subject, string name,string questionsInTest, string questionsAll, string resultOfQuestion, string mixAnswers, string mixQuestions, string notAnsweredForbidden, string json)
        {
            try
            {
                var cmd = Db.Connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO `testDB`.`testsTable` (`subject`, `name`, `questionsInTest`, `questionsAll`, `resultOfQuestion`, `mixAnswers`, `mixQuestions`, `notAnsweredForbidden`, `json`) VALUES ('"+subject+"', '"+name+"', '"+questionsInTest+"', '"+questionsAll+"', '"+resultOfQuestion+"', '"+mixAnswers+"', '"+mixQuestions+"', '"+notAnsweredForbidden+"', '"+json+"');";
                await cmd.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("DbErorr");
            }
        }

        //return list of subjects
        public async Task<List<CourseModel>> GetSubjects()
        {
            List<CourseModel> ret = new List<CourseModel>();
             var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM testDB.coursesTable;";
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    var subj = new CourseModel()
                    {
                        Id = await reader.GetFieldValueAsync<Int32>(0),
                        Name = await reader.GetFieldValueAsync<String>(1),
                        Count = await reader.GetFieldValueAsync<Int32>(2),
                    };                    
                    ret.Add(subj);
                   
                }
                ret = ret.Distinct().ToList();
                return ret;
            }
        }
        public async Task<List<string>> GetTest(string id)
        {
            List<string> ret = new List<string>();
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM testDB.testsTable WHERE id = "+id+";";
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                string sub;
                while (await reader.ReadAsync())
                {
                    int isub = await reader.GetFieldValueAsync<Int32>(0);
                    ret.Add(isub.ToString()); sub = await reader.GetFieldValueAsync<string>(1);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(2);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(3);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(4);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(5);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(6);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(7);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(8);
                    ret.Add(sub); sub = await reader.GetFieldValueAsync<string>(9);
                    ret.Add(sub);
                }

                return ret;
            }
        }
        public async Task<List<string>> GetTestList()
        {
            List<string> ret = new List<string>();
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM testDB.testsTable;";
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                string sub;
                while (await reader.ReadAsync())
                {
                    Int32 isub = await reader.GetFieldValueAsync<Int32>(0);
                    sub = isub.ToString();
                    ret.Add(sub);
                }

                return ret;
            }
        }
    }
}
