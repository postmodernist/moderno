using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
