using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApi.Service
{
    public interface IStudentApplication
    {
        string Add(string name);
        IEnumerable<string> Get();

        IEnumerable<string> Get(string id);

        bool Delete(string id);
    }
}