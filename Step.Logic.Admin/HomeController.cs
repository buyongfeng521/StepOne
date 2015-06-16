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
            return View();
        }

        [HttpPost]
        public ActionResult Login(Sys_User user)
        {
            string strPassword = Common.EncryptHelper.GetMD5(user.UPassword);
            if (OperateContext.BLLSession.ISys_UserBLL.GetModelBy(u => u.UName == user.UName && u.UPassword == strPassword) != null)
            {
                //Redirect("~/home/index/");
            }
            return View();    
        }

    }
}
