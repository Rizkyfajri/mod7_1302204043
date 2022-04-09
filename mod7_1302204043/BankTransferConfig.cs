using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mod7_1302204043
{
    public class BankTransferConfig
    {
        public string lang { get; set; }
        public TransferModul transfer { get; set; }
        public List<string> Method { get; set; }
        public  ConfirmModul confirm  { get; set; }



    }
    public class TransferModul
    {
        public int Threshold { get; set; }
        public int Low_fee { get; set; }
        public int High_fee { get; set; }
    }
    public class ConfirmModul
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}
