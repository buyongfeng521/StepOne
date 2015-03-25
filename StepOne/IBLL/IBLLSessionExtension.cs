
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
	public partial interface IBLLSession
    {
		ISys_UserBLL ISys_UserBLL{get;set;}
    }

}