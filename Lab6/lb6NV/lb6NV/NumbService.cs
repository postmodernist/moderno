using System;
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
