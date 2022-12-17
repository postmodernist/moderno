using System.ServiceModel;
using System.Threading.Tasks;

namespace WcfServer
{
    [ServiceContract]
    public interface IFileService
    {
        [OperationContract]
        string CreateFile(string name, string data);
    }
}