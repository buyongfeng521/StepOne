using MODEL;
using Step.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Step.Logic.Admin
{
    public class HomeController:Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            //Sys_User user = OperateContext.BLLSession.ISys_UserBLL.GetModelBy(u => u.UName == "buyf");
            //if (user != null)
            //{
            //    user.UName = "buyf";
            //    user.UPassword = Common.EncryptHelper.GetMD5("888888");
            //    user.URealName = "buyongfeng";
            //    user.UEmail = "xxx@163.com";
            //    user.UTel = "136XXXXXXXX";
            //    user.Note = "备注";
            //    user.IsDel = 0;
            //    user.CreateDate = DateTime.Now;
            //    user.ModifyDate = DateTime.Now;
            //    OperateContext.BLLSession.ISys_UserBLL.Modify(user);
            //}
            //ViewBag.IsSuc = "成功";

            //Sys_User sys_User = OperateContext.BLLSession.ISys_UserBLL.GetListBy(u => u.UID == 1).FirstOrDefault();
            //if (sys_User != null)
            //{
            //    sys_User.UName = "buyf";
            //    sys_User.UPassword = Common.EncryptHelper.GetMD5("888888");

            //    OperateContext.BLLSession.ISys_UserBLL.Modify(sys_User);
            //}
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(Sys_User user)
        {
            if (!string.IsNullOrEmpty(user.UPassword))
            {
                string strPassword = Common.EncryptHelper.GetMD5(user.UPassword);
                if (OperateContext.BLLSession.ISys_UserBLL.GetModelBy(u => u.UName == user.UName && u.UPassword == strPassword) != null)
                {
                    //Response.Redirect("/Home/Index");
                    //Response.Redirect("Index");
                    return Content("ok");
                }
                else
                {
                    //return Content("<script>alert('用户名或密码错误');window.location.href='/Admin/Home/Login';</script>", "text/html");
                    return Content("密码或用户名错误");
                }
            }
            
            return View();    
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult FormElement()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return Redirect("/Admin/Home/Login");
        }


    }
}
