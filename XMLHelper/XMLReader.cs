using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web;
using System.Data;
using XMLHelper.External.Models;

namespace XMLHelper
{
    public class XMLReader
    {
        /// <summary>   
        /// Return list of doctors from XML.   
        /// </summary>   
        /// <returns>List of doctors</returns>   
        public List<Doctors> RetrunListOfDoctors()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/therapist.xml"); //Path of the xml script   
            DataSet ds = new DataSet(); //Using dataset to read xml file   
            ds.ReadXml(xmlData);
            var doctors = new List<Doctors>();
            doctors = (from rows in ds.Tables[0].AsEnumerable()
                        select new Doctors
            {
                Name = rows[0].ToString(), //Convert row to int   
                Cabinet = Convert.ToInt32(rows[1].ToString()),
                Work = rows[2].ToString(),
                Work_Th = rows[3].ToString(),
            }).ToList();
            return doctors;
        }
    }
}