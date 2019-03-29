using System;
using System.IO;
using System.ServiceModel.Activation;

namespace WCFWSDualHttpSample
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EchoService : IEcho
    {
        public void Echo(string message)
        {
        }
    }
}
