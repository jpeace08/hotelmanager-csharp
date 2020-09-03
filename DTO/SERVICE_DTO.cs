using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SERVICE_DTO
    {
        private string serviceCode;
        private string serviceName;
        private decimal serviceCost;

        public string ServiceCode { get => serviceCode; set => serviceCode = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public decimal ServiceCost { get => serviceCost; set => serviceCost = value; }
    }
}
