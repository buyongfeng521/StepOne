using DI;
using MODEL;
using Step.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Step.Logic
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            //List<MODEL.Ou_Permission> list = OperateContext.BLLSession.IOu_PermissionBLL.GetListBy(p => p.pIsDel == false);
            //IBLL.ISys_UserBLL user = SpringHelper.GetObject<IBLL.ISys_UserBLL>("BLL");
            
            //var linq = OperateContext.BLLSession.ISys_UserBLL.GetListBy(u=>u.IsDel == 0);
            //int i = 0;
            //2.加载视图
            return View();
        }
    }
}
