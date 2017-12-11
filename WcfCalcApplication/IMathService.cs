using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalcApplication
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMathService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Sub(double a, double b);

        [OperationContract]
        double Mul(double a, double b);

        [OperationContract]
        double Div(double a, double b);
    }
}
