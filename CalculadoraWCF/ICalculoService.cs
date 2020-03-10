using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWCF
{
    [ServiceContract]
    public interface ICalculoService
    {
        [OperationContract]
        decimal Somar(decimal num1, decimal num2);
        [OperationContract]
        decimal Subtrair(decimal num1, decimal num2);
        [OperationContract]
        decimal Multiplicar(decimal num1, decimal num2);
        [OperationContract]
        decimal Dividir(decimal num1, decimal num2);
    }
}
