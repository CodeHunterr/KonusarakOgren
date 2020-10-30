using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;
using System.IO;
using BusinessProject.Entities;
using System.Data;
using BusinessProject.Models;

namespace BusinessProject.Controllers
{
    public class UserController : Controller
    {
         
        string appPath = Directory.GetCurrentDirectory();
        SQLiteCommand command = new SQLiteCommand();
        User user = new User();



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModels userModel)
        {
            string sqliteDb = $"Data source={appPath}\\bin\\debug\\netcoreapp3.1\\Proje.db;Version=3;";
            using (var conn = new SQLiteConnection(sqliteDb))
            {
                
                conn.Open();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM users WHERE userName='" + userModel.user.userName + "' AND password= '" + userModel.user.password + "' AND statusId=1 ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);               
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                { 
                    
                    return RedirectToAction("GetCurrentData", "Data");
                }
                else
                {
                    return View(userModel);
                }              
                             

            }

        }
    }
}