using System;
using System.Collections.Generic;
using System.Text;

namespace APITester
{
    public class LicenceModel
    {
        
        public int LicenceNo { get; set; }
        public int CustomerNo { get; set; }
        public string UniqueKey { get; set; }
        public DateTime DateTo { get; set; }
        public string CompanyName { get; set; }

    }
}
