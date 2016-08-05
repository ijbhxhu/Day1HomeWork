using Day1HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "我的記帳本";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    public ActionResult Table()
        {
            // 第二版-------------- - START
            var model = new List<MyClass>(){
            new MyClass() {  Serial = "1", Type = "收入", Date="2016/8/1", Money="1000"},
            new MyClass() {  Serial = "2", Type = "支出", Date="2016/8/2", Money="500"},
            new MyClass() {  Serial = "3", Type = "收入", Date="2016/8/3", Money="1200"},
            };
            // 第二版-------------- - END

            // 第一版-------------- - START
            //var model = new MyClasses
            //{
            //    //Datas[0].Serial = "1",
            //    //Serial = "1",
            //    //Type = "支出",
            //    //Date = "2016/01/01",
            //    //Money = "2500"
            //};
            // 第一版-------------- - END

            return View(model);
        }

    }
}