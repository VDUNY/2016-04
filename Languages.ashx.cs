using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQuery
{
    /// <summary>
    /// Summary description for Languages
    /// </summary>
    public class Languages : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string prefix = context.Request.QueryString["prefix"];
            context.Response.ContentType = "application/json";

            var obj = new List<NameValue>();
            obj.Add(new NameValue { Value = 1, Name = "abc" });
            obj.Add(new NameValue { Value = 2, Name = "acbc" });
            obj.Add(new NameValue { Value = 3, Name = "abcfd" });
            obj.Add(new NameValue { Value = 4, Name = "assbc" });
            obj.Add(new NameValue { Value = 5, Name = "aaabc" });
            obj.Add(new NameValue { Value = 6, Name = "ddabc" });
            obj.Add(new NameValue { Value = 7, Name = "dggabc" });
            obj.Add(new NameValue { Value = 8, Name = "dabc" });
            obj.Add(new NameValue { Value = 9, Name = "vvabc" });
            obj.Add(new NameValue { Value = 10, Name = "vabc" });
            obj.Add(new NameValue { Value = 11, Name = "vgafftbc" });
            obj.Add(new NameValue { Value = 12, Name = "vabc" });
            obj.Add(new NameValue { Value = 13, Name = "vddabc" });
            var filtered = (from c in obj
                            where c.Name.IndexOf(prefix) == 0
                            select c).ToList();
            System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            string data = jss.Serialize(filtered);
            context.Response.Write(data);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}