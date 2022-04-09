// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Newtonsoft.Json;

namespace mod7_1302204043
{
    class Program
    {
        void Main(string[] args)
        {
            Config config = new Config();
            try
            {
                
                config.ReadConfig();

            }catch (Exception ex)
            {
                config.WriteConfig();
            }
        }
        public class Config
        {
            public string ReadConfig()
            {
                return null; // baca dulu file json dari direktori
            }
            public void WriteConfig()
            {
                //ini tulis cofig manual terus disimpan di direktori
                BankTransferConfig model = new BankTransferConfig()
                {
                    lang = "en",
                    transfer = new TransferModul()
                    {
                        Threshold = 25000000,
                        Low_fee = 6500,
                        High_fee = 15000
                    },
                    Method = new List<string>(),
                    confirm = new ConfirmModul()
                    {
                        en = "yes",
                        id = "ya"
                    }

                };
                string defaultValue = JsonConvert.SerializeObject(model, Formatting.Indented);
            } 
        }
    }
}