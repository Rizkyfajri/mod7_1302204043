// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Newtonsoft.Json;

namespace mod7_1302204043
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config();
            try
            {

                
                BankTransferConfig model = config.ReadConfig();
                Console.WriteLine("Membaca file");
                //BankTransferConfig model = new BankTransferConfig();


                string message = (model.lang == "id") ? "masukan data anda": "Please insert your data";
                //string message1 = (model.lang == )
                Console.WriteLine(message);
                //Console.WriteLine(model.transfer.Threshold);

                int tempt_input = Convert.ToInt32(Console.ReadLine());
                if (tempt_input < model.transfer.Threshold)
                {
                    Console.WriteLine(model.transfer.Low_fee);
                }
                else
                {
                    Console.WriteLine(model.transfer.High_fee);
                }

                string transfer_met = (model.lang == "id") ? "pilih metode transfer" : "select transfer method";
                Console.WriteLine(transfer_met);
                int a = 4;
                //string[] tipe_trans = { model.Method };
                //List[] = model.Met    hod
                //Console.WriteLine(model.Method);
                //while (a < )
                //{
                //  Console.WriteLine(model.transfer.)
                //}
                var tipe_trans = model.Method;
                tipe_trans.ForEach(t =>Console.WriteLine(t));
                Console.ReadLine();
                string konfirmasi = (model.lang == "id") ? "konfirmasi" : "confirm";
                Console.WriteLine(konfirmasi);
                if (model.lang == "id")
                {
                    Console.WriteLine(model.confirm.id);
                }
                else
                {
                    Console.WriteLine(model.confirm.en);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("file config belum ada");
                config.WriteConfig();
                Console.WriteLine("file config sudah ada");
            }
        }
        public class Config
        {
            public BankTransferConfig ReadConfig()
            {
                BankTransferController controller = new BankTransferController();
                return controller.Readjson();
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
                    Method = new List<string>()
                    {
                        "RTO (real time)",
                        "SKN",
                        "RTGS",
                        "BI FAST"
                    },
                    confirm = new ConfirmModul()
                    {
                        en = "yes",
                        id = "ya"
                    }

                };
                BankTransferController controller = new BankTransferController();
                controller.WriteJson(model);
                
                string defaultValue = JsonConvert.SerializeObject(model, Formatting.Indented);
            } 
        }
    }
}