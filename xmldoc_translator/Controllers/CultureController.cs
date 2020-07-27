using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;
using xmldoc_translator.Models;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace xmldoc_translator.Controllers
{
    public class CultureController : ApiController
    {
    [HttpGet]
    private string GetStationCultureValue(string name, string strCultureCode)
    {
      string val = name;
      try
      {
        if(strCultureCode != "en" && strCultureCode != "en-GB" && strCultureCode != "en-US")
        {
          DataSet ds = new DataSet();
          var stationPath = ConfigurationManager.AppSettings.Get("StationCulturePath") + "{0}.xml";
          stationPath = string.Format(stationPath, strCultureCode);
          ds.ReadXml(stationPath);
          DataRow[] dr = ds.Tables[1].Select("code = ''" + name + " ''");
          if(dr.Length > 0)
          {
            val = dr[0]["text"].ToString();
          }
        }
      }
      catch(Exception ex)
      {
        throw new Exception(ex.Message);
      }
      return val;
    }
   

    
  }
}
