using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTools
{
    class InvoiceDTO
    {
        public string InvoiceNo { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string CreateDate { get; set; }
        public string ImportPassel { get; set; }
        public decimal TotalYards { get; set; }
        public int TotalRoll { get; set; }
        public string ScheduleCode { get; set; }
    }
}
