using System.IO;
using System.ServiceModel;

namespace WCFBasicHttpSample
{
    [ServiceContract]
    public interface IEcho
    {
        [OperationContract]
        string Echo(string message);

        [OperationContract]
        Stream DownloadStream();

        [OperationContract]
        void UploadStream(Stream stream);
    }
}
