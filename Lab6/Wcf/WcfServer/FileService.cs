using System;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FileService: IFileService
    {
        public string CreateFile(string name, string data)
        {
            using (FileStream fst = new FileStream(@"C:\" + name, FileMode.OpenOrCreate))
            {
                byte[] _data = Encoding.Default.GetBytes(data);
                //fst.WriteAsync(_data, 0, _data.Length);
                Console.WriteLine(name, data);
            }

            return (name + data);

        }
    }
}