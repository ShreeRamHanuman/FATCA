using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace FATCA.BLL
{
    /// <summary>
    /// this class is used to adding the number of spaces in the string.
    /// </summary>
    public static class PreApendSpaces
    {
        public static string PrependSpaces(int Size, string str)
        {
            
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < (Size - str.Length); i++)
            {
                sb.Append(" ");
            }
            sb.Append(str);
            return sb.ToString();
        }
    }
}
