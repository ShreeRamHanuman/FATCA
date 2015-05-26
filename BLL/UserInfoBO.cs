using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace FATCA.BLL
{
    public class UserInfoBO
    {
        public static string userName { get; set; }
        public static string password { get; set; }
        public static string LastAccessed { get; set; }


        /// <summary>
        /// this below part is for checking the database from IBM server.
        /// </summary>
        public static string CACO { get; set; } // COMPANY
        public static string CAPOLNUM { get; set; }// POLICY NUMBER
        public static string CAINAME { get; set; }// INSURED NAME
        public static string CABMODE { get; set; }// MODE
        public static string CARULE { get; set; }// RULE
        public static string CAPOLFEE { get; set; }// POLFEE
        public static string CASPEC { get; set; } // SPEC
        public static string CASUBYY { get; set; } // FOR SUBMIT DATE
        public static string CASUBMM { get; set; } // FOR SUBMIT DATE
        public static string CASUBDD { get; set; } // FOR SUBMIT DATE

        public static string CAPDTOYY { get; set; } // FOR PAID DATE
        public static string CAPDTOMM { get; set; } // FOR PAID DATE
        public static string CAPDTODD { get; set; } // FOR PAID DATE

        // END OF LLDCA AS400 DATA FILE

        public static string CABNFO { get; set; }
        public static string CABAPL { get; set; }
        public static string CABSTATUS { get; set; }
        public static string FATCACLS { get; set; }
        public static string cdate { get; set; }
        public static string CUREDOCNM { get; set; }
        public static string CUREDOCDT { get; set; }
        //public static string FATCACLS { get; set; }
        //public static string cdate { get; set; }
        //public static string CUREDOCNM { get; set; }
        //public static string CUREDOCDT { get; set; }
        //public static string FATCACLS { get; set; }
    }

}
