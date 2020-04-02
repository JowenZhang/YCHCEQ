using Andafa.Mes.Bll.WebSiteBll;
using Andafa.Mes.MainWebSite.Tools;
using Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andafa.Mes.MainWebSite.Controllers
{
    /// <summary>
    /// home page controller
    /// </summary>
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /// <summary>
        /// home index
        /// </summary>
        /// <returns>home index page</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// user login
        /// </summary>
        /// <param name="worker_no">worker_no</param>
        /// <returns>user info</returns>
        public ActionResult Login(string worker_no)
        {
            //valid user
            HomeBll bll = new HomeBll();
            Me_worker worker = bll.GetCurrentWorker(worker_no);
            if (worker == null)
            {
                return Json(new
                {
                    IsSucceed = false,
                    ActionDirection = "None",
                    Worker_no = string.Empty,
                    Worker_name = string.Empty,
                    Msg = "用户不存在"
                }, JsonRequestBehavior.AllowGet);
            }
            //user not exist, then return error
            if (string.IsNullOrWhiteSpace(worker.worker_no))
            {
                return Json(new
                {
                    IsSucceed = false,
                    ActionDirection = "None",
                    Worker_no = string.Empty,
                    Worker_name = string.Empty,
                    Msg = "用户不存在"
                }, JsonRequestBehavior.AllowGet);
            }
            //redirect page
            if (worker.job_no == "1001")
            {
                var userInfo = new Tuple<string, string, string>(worker.worker_no, worker.worker_name, "操作员");
                //NoCtrlController notCtrl = new NoCtrlController();
                ControllerTool.AddCookie("UserInfo", userInfo);
                return Json(new
                {
                    IsSucceed = true,
                    ActionDirection = "/Operator/BasicPage",
                    Worker_no = worker.worker_no,
                    Worker_name = worker.worker_name,
                    Msg = "登录成功"
                }, JsonRequestBehavior.AllowGet);
            }
            //else if (worker.job_no == "1004")
            //{
            //    var userInfo = new Tuple<string, string, string>(worker.worker_no, worker.worker_name, "检验员");
            //    //NoCtrlController notCtrl = new NoCtrlController();
            //    ControllerTool.AddCookie("UserInfo", userInfo);
            //    return Json(new
            //    {
            //        IsSucceed = true,
            //        ActionDirection = "/Inspector/BasicPage",
            //        Worker_no = worker.worker_no,
            //        Worker_name = worker.worker_name,
            //        Msg = "登录成功"
            //    }, JsonRequestBehavior.AllowGet);
            //}
            else
            {
                return Json(new
                {
                    IsSucceed = true,
                    ActionDirection = "None",
                    Worker_no = string.Empty,
                    Worker_name = string.Empty,
                    Msg = "登录失败"
                }, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// got develop
        /// </summary>
        /// <returns>develop info</returns>
        public ActionResult GetDevelop()
        {
            return Json(new
            {
                Company = "凌源铠钎网络文化传媒有限公司",
                Contact = "zjw1514@163.com"
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
