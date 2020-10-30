using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessProject.Entities;
using BusinessProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult ExamShow()
        {
            ExamModels examModel = new ExamModels();
            examModel.examList = GetExam();
            return View(examModel);
        }
      
        public IActionResult Del(int id)
        {
            ExamModels examModel = new ExamModels();
            string appPath = Directory.GetCurrentDirectory();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(sqliteDb);


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Exam WHERE titleId='" + id + "' ";
            command.ExecuteNonQuery();
            conn.Close();

            return RedirectToAction("ExamShow","Exam");
        }


        public IActionResult ExamDetails(int id)
        {
            ExamModels examModel = new ExamModels();
            examModel.examData = GetData(id);
            examModel.questionList = GetQuestion(id);
            return View(examModel);
        }

        #region
        private List<Exam> GetExam()
        {
            string appPath = Directory.GetCurrentDirectory();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(sqliteDb);


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "select * from Exam ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Exam exam = new Exam();
            List<Exam> examList = new List<Exam>();
            foreach (DataRow dataRow in dt.Rows)
            {
                exam = new Exam()
                {
                    id = Convert.ToInt32(dataRow["id"]),
                    titleId= Convert.ToInt32(dataRow["titleId"]),
                    examTitle = dataRow["examTitle"].ToString(),
                    creationDate = dataRow["creationDate"].ToString(),
                };

                examList.Add(exam);
            }
            conn.Close();

            return examList;
        }
        private Data GetData(int titleId)
        {
            string appPath = Directory.GetCurrentDirectory();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(sqliteDb);


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "select * from Data where id='" + titleId + "'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data data = new Data();

            foreach (DataRow dataRow in dt.Rows)
            {
                data = new Data()
                {
                    id = Convert.ToInt32(dataRow["id"]),                    
                    content = dataRow["content"].ToString(),
                    title = dataRow["title"].ToString(),
                    link= dataRow["link"].ToString()
                };


            }
            conn.Close();

            return data;
        }
        private List<Question1> GetQuestion(int titleId)
        {
            string appPath = Directory.GetCurrentDirectory();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(sqliteDb);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "select * from Question where dataId=" + titleId + " ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ExamModels dataModels = new ExamModels();
            List<Question1> questionList = new List<Question1>();

            foreach (DataRow dataRow in dt.Rows)
            {
                Question1 question1 = new Question1()
                {
                    id = Convert.ToInt32(dataRow["id"]),
                    question = dataRow["question"].ToString(),
                    aChoise = dataRow["aChoise"].ToString(),
                    bChoise = dataRow["bChoise"].ToString(),
                    cChoise = dataRow["cChoise"].ToString(),
                    dChoise = dataRow["dChoise"].ToString(),
                    trueAnswer1 = dataRow["trueAnswer"].ToString(),
                };
                questionList.Add(question1);


            }


            conn.Close();

            return questionList;
        }
        #endregion

    }
}