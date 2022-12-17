using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbInterfaces;
namespace lb6NV
{
    
    class NumbService: INumbService 
    {
        string res = "error";
        string INumbService.Convert (int num)
        {
            res = "";
            res = Convert.ToString(num, 2);
            return res;
        }
    }
}
