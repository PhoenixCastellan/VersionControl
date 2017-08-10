using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApi.Service
{
    public interface IStudentService
    {
        string Add(string name);
        bool Delete(string id);
    }
}