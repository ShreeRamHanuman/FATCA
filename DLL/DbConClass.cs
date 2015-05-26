using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace FATCA.DLL
{
   public  class DbConClass
    {
    //  public static string path = "AppDomain.CurrentDomain.BaseDirectory + LastState.mdb";
       /// <summary>
       /// this class consist the connection strings, of IBM Server, MsSql Server and Access DATABASE(Local file)
       /// </summary>
       public static string ConnectionString // this is connection string class for SQL SERVER
       {

           get { return @"Data Source=tcp:10.40.80.18\SQLSERVER2005,1433;Initial Catalog=FATCA;Integrated Security=True"; }
       }

       public static string ConnectionStringIBMDB2 // this is for IBM Server
       {
           get
           {
               return @"Data Source =10.40.80.20; userid=DPOSMT; Password=lifesuck1; default collection=FATCA; librarylist=*USRLIBL";
               //return @"Data Source =10.40.80.20; userid=DPOSMT; Password=lifesuck1; default collection=LMEVULPRNP; librarylist=*USRLIBL"; // For Live Data
          
           }
       }

       public static string ConnectionStringMDB
       {
           
           get
           {
               return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\FATCA\LastState.mdb;" + "Jet OLEDB:Database Password=nepal123";
               /// the Password Databse Password is the Password which is required to open the database to Rerun the Program 
               /// Because in this access database the LastState Value is Stored in User Computer.
           }
       }
    }
}
