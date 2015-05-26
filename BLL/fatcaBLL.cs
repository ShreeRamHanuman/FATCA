//using System;
//using System.Collections.Generic;
////using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using FATCA.DLL;

//namespace FATCA.BLL
//{
//    public class fatcaBLL
//    {

//        public DataTable GetUserValidationData()
//        {
//            try
//            {
//                fatcaDAL objFactaDAL = new fatcaDAL();
//                return objFactaDAL.Read();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        public DataTable GetUserValidationData(string userName, string userPassword)
//        {
//            try
//            {
//                fatcaDAL objFactaDAL = new fatcaDAL();
//                return objFactaDAL.Read(userName, userPassword);
//            }
//            catch
//            {
//                throw;

//            }
//        }

//        //public DataTable GetUserValidationData(string userPassword)
//        //{
//        //    try
//        //    {
//        //        fatcaDAL objFactaDAL = new fatcaDAL();
//        //        return objFactaDAL.Read(userPassword);
//        //    }
//        //    catch
//        //    {
//        //        throw;
//        //    }
//        //}
//    }
//}
