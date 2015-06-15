 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLA
{
	public partial class Sys_UserBLL : BaseBLL<MODEL.Sys_User>,IBLL.ISys_UserBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ISys_UserDAL;
		}
    }
}