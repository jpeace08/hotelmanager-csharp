using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SERVICE_DAL
    {
        //get services:
        public static List<SERVICE_DTO> getServices(string sqlQuery)
        {
            List<SERVICE_DTO> services;
            SERVICE_DTO service;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                services = new List<SERVICE_DTO>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    service = new SERVICE_DTO()
                    {
                        ServiceCode = tb.Rows[i]["MaDV"].ToString(),
                        ServiceName = tb.Rows[i]["TenDV"].ToString(),
                        ServiceCost = decimal.Parse(tb.Rows[i]["DonGia"].ToString())
                    };
                    services.Add(service);
                }
                return services;
            }
            else return null;
        }

        //add service:
        public static bool addService(SERVICE_DTO service)
        {
            string sqlQuery = "INSERT INTO [dbo].[DICH_VU] VALUES ('"+service.ServiceCode+"',N'"+service.ServiceName+"',"+service.ServiceCost+")";
            if (DataProvider.ExeSql(sqlQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //edit service:
        public static bool editService(SERVICE_DTO sERVICE_)
        {
            string sqlExe = "UPDATE [dbo].[DICH_VU] SET [TenDV] = N'"+sERVICE_.ServiceName+"',[DonGia] = "+sERVICE_.ServiceCost+"  WHERE MaDV = '"+sERVICE_.ServiceCode+"';";
            return DataProvider.ExeSql(sqlExe);
        }
    }
}
