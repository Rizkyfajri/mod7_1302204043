using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mod7_1302204043
{
    public class BankTransferController
    {
        public void WriteJson(BankTransferConfig data)
        {
            string file = JsonConvert.SerializeObject(data,Formatting.Indented);
            File.WriteAllText(@"D:\Programs\Universitas\semester 4\Praktikum_KPL\Model_2\Project_7\mod7_1302204043\mod7_1302204043\Bank_Transfer_Config.json", file);

        }
        public BankTransferConfig Readjson()
        {
            dynamic data = File.ReadAllText(@"D:\Programs\Universitas\semester 4\Praktikum_KPL\Model_2\Project_7\mod7_1302204043\mod7_1302204043\Bank_Transfer_Config.json");
            //dynamic data = File.ReadAllText("D://Programs//Universitas//semester 4//Praktikum_KPL//Model_2//Project_7//mod7_1302204043//mod7_1302204043//Bank_Transfer_Config.json");
            BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(data);
            return config;
        }
    }
}
