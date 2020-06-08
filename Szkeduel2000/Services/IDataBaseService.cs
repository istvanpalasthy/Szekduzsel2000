using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szkeduel2000.Domain;

namespace Szkeduel2000.Services
{
    public interface IDataBaseService
    {
        //User


        //Schedule
        List<Schedule> GetSchedules(string email);

        string GetScheduleName(string email);
    }
}

