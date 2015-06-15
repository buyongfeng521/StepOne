
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;

namespace BLLA
{
	public partial class BLLSession:IBLL.IBLLSession
    {
		#region 01 数据接口 ISys_UserDAL
		ISys_UserBLL iSys_UserBLL;
		public ISys_UserBLL ISys_UserBLL
		{
			get
			{
				if(iSys_UserBLL==null)
					iSys_UserBLL= new Sys_UserBLL();
				return iSys_UserBLL;
			}
			set
			{
				iSys_UserBLL= value;
			}
		}
		#endregion

    }

}