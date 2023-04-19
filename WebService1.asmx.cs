using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication10
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCOUNTRIES=new DataTable();
        DBAccess ObjDBAccess=new DBAccess();
        DataTable dtUsers=new DataTable();
        
       
       
        
        [WebMethod]
        public String COUNTRIES()
        {
            dtCOUNTRIES.Columns.Add("produit");
            dtCOUNTRIES.Columns.Add("Quantite");
            dtCOUNTRIES.Rows.Add("sabon","12");
            dtCOUNTRIES.Rows.Add("javil", "12");
            dtCOUNTRIES.Rows.Add("tbassel", "12");
            dtCOUNTRIES.Rows.Add("khobz", "12");
            return JsonConvert.SerializeObject(dtCOUNTRIES);
        }
        [WebMethod]
        public string datatableforusers(string id)
        {
            string query = "Select * from Users where id='" + id + "'";
            ObjDBAccess.readDatathroughAdapter(query, dtUsers);
            string result=JsonConvert.SerializeObject(dtUsers);
            return result;
        }
    }
}
