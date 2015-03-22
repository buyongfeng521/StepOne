
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALMSSQL
{
	public partial class DBSession:IDAL.IDBSession
    {
		#region 01 数据接口 ISys_UserDAL
		ISys_UserDAL iSys_UserDAL;
		public ISys_UserDAL ISys_UserDAL
		{
			get
			{
				if(iSys_UserDAL==null)
					iSys_UserDAL= new Sys_UserDAL();
				return iSys_UserDAL;
			}
			set
			{
				iSys_UserDAL= value;
			}
		}
		#endregion

    }

}