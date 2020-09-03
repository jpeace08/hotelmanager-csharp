using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SERVICE_BLL
    {
        //load get services:
        public static List<SERVICE_DTO> getServices(string sqlQuery)
        {
            return SERVICE_DAL.getServices(sqlQuery);
        }

        //load add services:
        public static bool addService(SERVICE_DTO service)
        {
            return SERVICE_DAL.addService(service);
        }

        //edit service:
        public static bool editService(SERVICE_DTO sERVICE_)
        {
            return SERVICE_DAL.editService(sERVICE_);
        }
    }
}
