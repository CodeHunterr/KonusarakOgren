using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessProject.Entities;
using BusinessProject.Models;
using BusinessProject.Controllers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace BusinessProject.Controllers
{
    public class DataController : Controller
    {

        public IActionResult GetCurrentData()
        {
            string appPath = Directory.GetCurrentDirectory();
            var firstId = 0;
            DataModels dataModel = new DataModels();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(sqliteDb))
            {
                SQLiteCommand command = new SQLiteCommand();
                SQLiteCommand command2 = new SQLiteCommand();
                SQLiteCommand command3 = new SQLiteCommand();


                conn.Open();
                Uri Url = new Uri("https://www.wired.com/");
                WebClient client = new WebClient();
                string html = client.DownloadString(Url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("//h2");
                HtmlNodeCollection links = dokuman.DocumentNode.SelectNodes("//a");
                List<string> titleList = new List<string>();
                List<string> linkList = new List<string>();
                command.Connection = conn;
                for (int i = 0; i < 5; i++)
                {
                    titleList.Add(titles[i].InnerText);
                }
                for (int j = 34; j < 53; j += 4)
                {
                    linkList.Add(links[j].Attributes["href"].Value);
                }
                for (int i = 0; i < 5; i++)
                {

                    command.CommandText = "Insert Into Data (link,title) Values ('" + linkList[i] + "','" + titleList[i] + "' )";
                    command.ExecuteNonQuery();
                }
                
                command2.Connection = conn;
                command2.CommandText = "select * from Data order by id desc limit 0,5";
                SQLiteDataAdapter da = new SQLiteDataAdapter(command2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                firstId = Convert.ToInt32(dt.Rows[0]["id"]);

                foreach (DataRow dataRow in dt.Rows)
                {
                    Data data = new Data()
                    {
                        id = Convert.ToInt32(dataRow["id"]),
                        link = dataRow["link"].ToString(),
                        title = dataRow["title"].ToString()

                    };

                    string adress = data.link;
                    Uri Url2 = new Uri("https://www.wired.com" + adress + "");
                    WebClient client2 = new WebClient();
                    string html2 = client.DownloadString(Url2);
                    HtmlAgilityPack.HtmlDocument dokuman2 = new HtmlAgilityPack.HtmlDocument();
                    dokuman2.LoadHtml(html2);
                    HtmlNodeCollection p2 = dokuman2.DocumentNode.SelectNodes("//p");
                    string fullcontent = " ";
                    foreach (var item in p2)
                    {
                        string content = item.InnerText;
                        fullcontent +=   "\n"+content+"";

                    }
                    command3.Connection = conn;
                    fullcontent= fullcontent.Replace("'", "");
                    command3.CommandText = "Update Data set content='" + fullcontent + "' Where id=" + data.id + "";
                    command3.ExecuteNonQuery();
                }

                conn.Close();
            }

            dataModel = new DataModels()
            {
                titleSelectList = GetTitleSelectList(),                
                content = GetContent(firstId)
            };


            return View(dataModel);
        }

        [HttpPost]
        public IActionResult GetCurrentData(DataModels dataModel)
        {
            string appPath = Directory.GetCurrentDirectory();

         
            
            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(sqliteDb))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = "Insert Into Question (dataId,question,aChoise,bChoise,cChoise,dChoise,trueAnswer) Values (" + dataModel.title.id + ",'" + dataModel.question1.question + "' ,'" + dataModel.question1.aChoise + "','" + dataModel.question1.bChoise + "','" + dataModel.question1.cChoise + "','" + dataModel.question1.dChoise + "'," + dataModel.question1.trueAnswer1 + ")";
                command.ExecuteNonQuery();
                command.CommandText = "Insert Into Question (dataId,question,aChoise,bChoise,cChoise,dChoise,trueAnswer) Values (" + dataModel.title.id + ",'" + dataModel.question2.question + "' ,'" + dataModel.question2.aChoise + "','" + dataModel.question2.bChoise + "','" + dataModel.question2.cChoise + "','" + dataModel.question2.dChoise + "'," + dataModel.question2.trueAnswer2 + ")";
                command.ExecuteNonQuery();
                command.CommandText = "Insert Into Question (dataId,question,aChoise,bChoise,cChoise,dChoise,trueAnswer) Values (" + dataModel.title.id + ",'" + dataModel.question3.question + "' ,'" + dataModel.question3.aChoise + "','" + dataModel.question3.bChoise + "','" + dataModel.question3.cChoise + "','" + dataModel.question3.dChoise + "'," + dataModel.question3.trueAnswer3 + ")";
                command.ExecuteNonQuery();
                command.CommandText = "Insert Into Question (dataId,question,aChoise,bChoise,cChoise,dChoise,trueAnswer) Values (" + dataModel.title.id + ",'" + dataModel.question4.question + "' ,'" + dataModel.question4.aChoise + "','" + dataModel.question4.bChoise + "','" + dataModel.question4.cChoise + "','" + dataModel.question4.dChoise + "'," + dataModel.question4.trueAnswer4 + ")";
                command.ExecuteNonQuery();
                Data examTitle = GetExamData(dataModel.title.id);
                command.CommandText = "Insert Into Exam (titleId,examTitle,creationDate) Values (" + examTitle.id + ",'" + examTitle.title + "',datetime('now', 'localtime'))";
                command.ExecuteNonQuery();
                conn.Close();

            }
  
            return RedirectToAction("ExamShow", "Exam");
        }

        [HttpPost]
        public IActionResult GetDescription(int titleId)
        {                                                                                  
            DataModels dataModel = new DataModels()
            {
                titleSelectList = GetTitleSelectList(),
                content = GetContent(titleId)
            };
           
            return View("GetCurrentData",dataModel);
        }

        #region Methods

        private List<SelectListItem> GetTitleSelectList()
        {
            string appPath = Directory.GetCurrentDirectory();

            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(sqliteDb);
            List<SelectListItem> titleList = new List<SelectListItem>();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "select * from Data order by id desc limit 0,5";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Data> list = new List<Data>();

            foreach (DataRow dataRow in dt.Rows)
            {
                Data titles = new Data()
                {
                    id = Convert.ToInt32(dataRow["id"]),
                    title = dataRow["title"].ToString(),
                    content = dataRow["content"].ToString()
                };
                list.Add(titles);

            }
            conn.Close();
            titleList = list.Select(x => new SelectListItem() { Value = x.id.ToString(), Text = x.title }).ToList();
            return titleList;
        }


        private Data GetContent(int titleId) 
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
            command.CommandText = "select * from Data where id=" + titleId + "";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data content = new Data();

            foreach (DataRow dataRow in dt.Rows)
            {
                content = new Data()
                {
                    id = Convert.ToInt32(dataRow["id"]),
                    content = dataRow["content"].ToString(),
                };
            }
            conn.Close();

            return content;
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
            DataModels dataModels = new DataModels();
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

        private Data GetExamData(int titleId)
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
            command.CommandText = "select title,id from Data where id=" + titleId + " ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data data = new Data()
            {
                id = Convert.ToInt32(dt.Rows[0]["id"]),
                title = dt.Rows[0]["title"].ToString(),

            };


            conn.Close();

            return data;
        }


        #endregion

    }
}