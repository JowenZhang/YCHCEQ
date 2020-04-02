using Andafa.Mes.Bll.WebSiteBll;
using Andafa.Mes.MainWebSite.Tools;
using Andafa.Mes.Model.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andafa.Mes.MainWebSite.Controllers
{
    /// <summary>
    /// operator controller
    /// </summary>
    public class OperatorController : Controller
    {
        //
        // GET: /Operator/

        /// <summary>
        /// basic page action
        /// </summary>
        /// <returns>basic page</returns>
        public ActionResult BasicPage()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Redirect("/");
            }
            OperatorBll bll = new OperatorBll();
            List<WorkerSelectedWkcView> list = bll.GetWorkerSelectedWkc(userInfo.Item1);
            List<WorkerSelectedWkcView> tmp = list.Where(a => a.is_selected).ToList();
            ViewBag.WorkerWkc = list;
            if (tmp == null || tmp.Count <= 0)
            {
                return RedirectToAction("WorkerSelectedWkc", "Operator");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// worker selected wkc
        /// </summary>
        /// <returns>edit view</returns>
        public ActionResult WorkerSelectedWkc()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Redirect("/");
            }
            List<WorkerSelectedWkcView> list = ViewBag.WorkerWkc as List<WorkerSelectedWkcView>;
            if (list == null || list.Count <= 0)
            {
                OperatorBll bll = new OperatorBll();
                list = bll.GetWorkerSelectedWkc(userInfo.Item1);
            }
            ViewBag.WorkerWkc = list;
            return View("WorkerSelectedWkc", list == null || list.Count <= 0);
        }

        /// <summary>
        /// get worker selected wkc data
        /// </summary>
        /// <returns>worker selected wkc data</returns>
        public ActionResult GetWorkerSelectedWkcData()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            List<WorkerSelectedWkcView> list = ViewBag.WorkerWkc as List<WorkerSelectedWkcView>;
            if (list == null || list.Count <= 0)
            {
                OperatorBll bll = new OperatorBll();
                list = bll.GetWorkerSelectedWkc(userInfo.Item1);
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// post worker selected wkc data
        /// </summary>
        /// <param name="wkcNos">selected wkc data</param>
        /// <returns>insert result</returns>
        public ActionResult PostWorkerSelectedWkcData(string[] wkcNos)
        {
            if (wkcNos == null || wkcNos.Length <= 0)
            {
                return Json(new { res = false, msg = "未选中数据" }, JsonRequestBehavior.AllowGet);
            }
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Json(new { res = false, msg = "用户错误" }, JsonRequestBehavior.AllowGet);
            }
            OperatorBll bll = new OperatorBll();
            bool r = bll.PostWorkerSelectedWkc(userInfo.Item1, wkcNos.ToList());
            string msg = string.Empty;
            if (r)
            {
                msg = "成功";
            }
            else
            {
                msg = "失败";
            }
            return Json(new { res = r, msg = msg }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// worker select wka
        /// </summary>
        /// <returns>worker select wka view</returns>
        public ActionResult WorkerSelectedWka()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Redirect("/");
            }
            List<WorkerSelectedWkaView> list = null;
            OperatorBll bll = new OperatorBll();
            list = bll.GetWorkerSelectedWka(userInfo.Item1);
            ViewBag.WorkerWka = list;
            return View("WorkerSelectedWka", list == null || list.Count <= 0);
        }

        /// <summary>
        /// get worker selected wkc data
        /// </summary>
        /// <returns>worker selected wkc data</returns>
        public ActionResult GetWorkerSelectedWkaData()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            List<WorkerSelectedWkaView> list = ViewBag.WorkerWka as List<WorkerSelectedWkaView>;
            OperatorBll bll = new OperatorBll();
            list = bll.GetWorkerSelectedWka(userInfo.Item1);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// post worker selected wka data
        /// </summary>
        /// <param name="wkaNos">selected wkc data</param>
        /// <returns>insert result</returns>
        public ActionResult PostWorkerSelectedWkaData(string[] wkaNos)
        {
            //if (wkaNos == null || wkaNos.Length <= 0)
            //{
            //    return Json(new { res = false, msg = "未选中数据" }, JsonRequestBehavior.AllowGet);
            //}
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Json(new { res = false, msg = "用户错误" }, JsonRequestBehavior.AllowGet);
            }
            OperatorBll bll = new OperatorBll();
            bool r = bll.PostWorkerSelectedWka(userInfo.Item1, wkaNos == null || wkaNos.Length <= 0 ? null : wkaNos.ToList());
            string msg = string.Empty;
            if (r)
            {
                msg = "成功";
            }
            else
            {
                msg = "失败";
            }
            return Json(new { res = r, msg = msg }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// worker select order
        /// </summary>
        /// <returns>worker select order view</returns>
        public ActionResult WorkerSelectedOrder()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Redirect("/");
            }
            List<WorkerSelectedOrderView> list = null;
            OperatorBll bll = new OperatorBll();
            list = bll.GetWorkerSelectedOrderData(userInfo.Item1);
            ViewBag.WorkerOrder = list;
            return View("WorkerSelectedOrder", list == null || list.Count <= 0);
        }

        /// <summary>
        /// get worker selected order data
        /// </summary>
        /// <returns>worker selected order data</returns>
        public ActionResult GetWorkerSelectedOrderData()
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            Newtonsoft.Json.Converters.IsoDateTimeConverter formatter = new Newtonsoft.Json.Converters.IsoDateTimeConverter();
            formatter.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            if (userInfo == null)
            {
                return Content(JsonConvert.SerializeObject(null, formatter));
            }
            List<WorkerSelectedOrderView> list = ViewBag.WorkerOrder as List<WorkerSelectedOrderView>;
            OperatorBll bll = new OperatorBll();
            list = bll.GetWorkerSelectedOrderData(userInfo.Item1);
            return Content(JsonConvert.SerializeObject(list, formatter));
        }

        /// <summary>
        /// post worker selected order data
        /// </summary>
        /// <param name="wkaOrders">orders choose to the wka</param>
        /// <param name="mo_no">mo_no</param>
        /// <returns>insert result</returns>
        public ActionResult PostWorkerSelectedOrderData(List<Dictionary<string, string>> wkaOrders)
        {
            Tuple<string, string, string> userInfo = ControllerTool.GetCookie<Tuple<string, string, string>>("UserInfo");
            if (userInfo == null)
            {
                return Content(JsonConvert.SerializeObject(new { res = false, msg = "用户错误" }));
            }
            OperatorBll bll = new OperatorBll();
            bool r = bll.PostWorkerSelectedOrderData(userInfo.Item1, wkaOrders);
            string msg = string.Empty;
            if (r)
            {
                msg = "成功";
            }
            else
            {
                msg = "失败";
            }
            return Content(JsonConvert.SerializeObject(new { res = r, msg = msg }));
        }
    }
}
