using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherApi.Service;

namespace WeatherApi.Controllers
{
    public class ValuesController : ApiController
    {
        private IStudentApplication _studentApplication;

        public ValuesController(IStudentApplication application)
        {
            _studentApplication = application;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _studentApplication.Get();
        }

        // GET api/values/5
        public string Get(string id)
        {
            return string.Join(",", _studentApplication.Get(id));
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
    }
}
