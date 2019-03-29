using System.IO;
using System.ServiceModel;

namespace WCFWSDualHttpSample
{
    [ServiceContract(CallbackContract = typeof(IEchoCallback), SessionMode = SessionMode.Required)]
    public interface IEcho
    {
        [OperationContract]
        void Echo(string message);
    }

    public interface IEchoCallback
    {
        [OperationContract]
        void Echo(string message);
    }
}
