using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mockup
{
    public class Common
    {
        public static string GenBillCode(int invenId, string prefix, DateTime OrderDate)
        {
            try
            {
                string code = "" + invenId;
                int codeLen = 6;

                if (code.Length < codeLen)
                {
                    int loop = codeLen - code.Length;
                    for (int i = 0; i < loop; i++)
                    {
                        code = "0" + code;
                    }
                }

                return prefix + code + String.Format("{0:ddMMyyHHmmss}", OrderDate);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
