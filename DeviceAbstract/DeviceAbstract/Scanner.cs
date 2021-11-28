using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceAbstract
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string documento)
        {
            Console.WriteLine("Scanner processing: " + documento);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
