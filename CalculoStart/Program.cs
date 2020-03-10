using CalculadoraWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace CalculoStart
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalculoService));
            Uri endereco = new Uri("http://localhost:8733");

            host.AddServiceEndpoint(typeof(ICalculoService), new BasicHttpBinding(), endereco);

            try
            {
                host.Open();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                ExibeInformacoesServico(host);
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
