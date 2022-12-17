using System.ServiceModel;

namespace NumbInterfaces
{
   [ServiceContract] 
   public interface INumbService
    {
        [OperationContract]
        string Convert(int num);
    }
}

