using System;
using System.Collections.Generic;
using System.Text;

namespace Gecko
{
    public class MyFun
    {
        public static string Combine(params string[] strs)
        {
            string strReturn = "";
            for (int i = 0; i < strs.Length; i++)
            {
                strReturn += "\\" + strs[i];
            }
            if (strReturn.Length >= 1)
            {
                strReturn = strReturn.Substring(1);
            }
            return strReturn;
        }
    }
}
