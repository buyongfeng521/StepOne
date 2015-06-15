using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step.Helper
{
    public class OperateContext
    {
        public static IBLL.IBLLSession BLLSession = DI.SpringHelper.GetObject<IBLL.IBLLSession>("BLLSession");
    }
}
