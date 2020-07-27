using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Hosting;
using System.Web.Http;
using System.Xml;

namespace xmldoc_translator.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/value

    //public IEnumerable<string> Get()
    //{
    //  return new string[] { "asp.net", "azur", "aws" };
    //}

    // GET api/values/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }

    //public HttpResponseMessage Get()
    //{
    //  //Change the path
    //  XmlReader reader = XmlReader.Create("C:\\Users\\Lenovo Y510P\\Desktop\\excel\\en-tt.xml");

    //  XmlDocument doc = new XmlDocument();
    //  doc.Load(reader);

    //  HttpResponseMessage response = this.Request.
    //  CreateResponse(HttpStatusCode.OK);
    //  response.Content = new StringContent
    // (doc.OuterXml, Encoding.UTF8, "application/xml");
    //  return response;
    //}
  }
}
