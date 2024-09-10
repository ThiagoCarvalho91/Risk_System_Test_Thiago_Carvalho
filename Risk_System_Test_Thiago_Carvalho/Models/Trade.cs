using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Risk_System_Test_Thiago_Carvalho.Interfaces;

namespace Risk_System_Test_Thiago_Carvalho.Models
{
    public class Trade : ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }

        public Trade(double value, string sector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = sector;
            NextPaymentDate = nextPaymentDate;
        }
    }
}
