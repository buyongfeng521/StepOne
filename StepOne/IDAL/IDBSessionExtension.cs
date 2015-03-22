
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
	public partial interface IDBSession
    {
		ISys_UserDAL ISys_UserDAL{get;set;}
    }

}