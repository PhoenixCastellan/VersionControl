using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApi.Service
{
    public class StudentApplicationImpl: IStudentApplication
    {
        private IStudentService _service;
        public StudentApplicationImpl(IStudentService service)
        {
            _service = service;
        }


        public string Add(string name)
        {
            return _service.Add(name);
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> Get(string id)
        {
            return new string[] { "valueA", "valueB" };
        }

        public bool Delete(string id)
        {
            return _service.Delete(id);
        }
    }
}